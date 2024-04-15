using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RGR
{
    public partial class Variety_page : MaterialForm
    {
        private Messages info = new Messages();
        private Checkers enter_checker = new Checkers();
        private Main_page main_page;
        private Match_page return_page;
        private PlantTable model;
        private Variety_page child_page;
        private bool position;

        public Variety_page()
        {
            InitializeComponent();
        }

        public Variety_page(Match_page page, Main_page m_page, PlantTable current)
        {
            InitializeComponent();
            main_page = m_page;
            return_page = page;
            model = current;
            position = true;
        }

        public Variety_page(Main_page m_page, PlantTable current, Variety_page r_page)
        {
            InitializeComponent();
            main_page = m_page;
            model = current;
            child_page = r_page;
            position = false;
        }

        private void глоссарийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.glossary_message();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.reference_message();
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(position)
            {
                return_page.Show();
                this.Close();
            }
            else
            {
                child_page.Show();
                this.Close();
            }
        }

        private void вНачалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_page.Show();
            this.Close();
        }

        private void Variety_page_Load(object sender, EventArgs e)
        {
            textBox_name.Text = model.Name;
            comboBox_category.Text = model.Category;
            textBox_author.Text = model.Author;
            textBox_number.Text = model.ParentVariety.ToString();
            textBox_productivity.Text = model.Productivity.ToString();
            textBox_frostResistance.Text = model.FrostResistance.ToString();
            richTextBox_pestResistance.Text = model.PestResistance;
            richTextBox_diseaseResistance.Text = model.DiseaseResistance;

            if(model.ParentVariety != null)
            {
                Parent_request request = new Parent_request(textBox_number.Text);
                textBox_Pname.Text = request.parent_name();
            }
            else
            {
                button_parent.Enabled = false;
            }

            if(main_page.admin_mode)
            {
                textBox_name.ReadOnly = textBox_author.ReadOnly = textBox_number.ReadOnly =
                    textBox_Pname.ReadOnly = textBox_productivity.ReadOnly =
                    textBox_frostResistance.ReadOnly = richTextBox_pestResistance.ReadOnly =
                    richTextBox_diseaseResistance.ReadOnly =  false;

                comboBox_category.Enabled = 
                    button_change.Enabled = button_delete.Enabled = true;
            }
            else
            {
                comboBox_category.Enabled =
                    button_change.Enabled = button_delete.Enabled = false;
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (enter_checker.parent_and_frost_Checker(textBox_frostResistance.Text, textBox_number.Text, textBox_Pname.Text))
            { //Проверка требований к пользовательским данным
                model.Name = textBox_name.Text.Trim(); //Название сорта
                model.Category = comboBox_category.Text.Trim(); //Категория сорта
                model.Author = textBox_author.Text.Trim(); //Автор сорка

                if (textBox_number.Text.Length != 0) //Проверка на пустое поле
                    model.ParentVariety = Convert.ToInt32(textBox_number.Text); //Индекс родительского сорта
                else
                    model.ParentVariety = null;

                if (textBox_productivity.Text.Length != 0) //Проверка на пустое поле
                    model.Productivity = Convert.ToInt32(textBox_productivity.Text); //Урожайность
                else
                    model.Productivity = null;

                if (textBox_frostResistance.Text.Length != 0) //Проверка на пустое поле
                    model.FrostResistance = Convert.ToInt32(textBox_frostResistance.Text); //Морозостойкость
                else
                    model.FrostResistance = null;

                model.PestResistance = richTextBox_pestResistance.Text.Trim(); //Устойчивость к вредителям
                model.DiseaseResistance = richTextBox_diseaseResistance.Text.Trim(); //Устойчивость к болезням

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\Users\\admin\\Desktop\\ИС-31 Марцинкевич Е.С. Георгиева Д.О\\БД\\PlantRegister.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                string sqlExpression;
                if (model.ParentVariety != null)
                {
                    sqlExpression = "UPDATE PlantTable SET Name= '"
                    + model.Name + "' , Category= '"
                    + model.Category + "' , Author= '"
                    + model.Author + "' , ParentVariety='"
                    + model.ParentVariety + "', Productivity= "
                    + model.Productivity + " , FrostResistance= "
                    + model.FrostResistance + " , PestResistance= '"
                    + model.PestResistance + "' , DiseaseResistance= '"
                    + model.PestResistance + "' WHERE CustomID= '" + model.CustomID + "'";
                }
                else
                {
                    sqlExpression = "UPDATE PlantTable SET Name= '"
                    + model.Name + "' , Category= '"
                    + model.Category + "' , Author= '"
                    + model.Author + "' , ParentVariety=NULL , Productivity= "
                    + model.Productivity + " , FrostResistance= "
                    + model.FrostResistance + " , PestResistance= '"
                    + model.PestResistance + "' , DiseaseResistance= '"
                    + model.PestResistance + "' WHERE CustomID= '" + model.CustomID + "'";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                    Console.WriteLine("Обновлено объектов: {0}", number);
                }

                main_page.Show();
                return_page.Close();
                this.Close();

                MessageBox.Show("Сорт растения был изменен.", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); //Сообщение об успешности создания нового сорта
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить сорта растения?\n", 
                "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\Users\\admin\\Desktop\\ИС-31 Марцинкевич Е.С. Георгиева Д.О\\БД\\PlantRegister.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                string sqlExpression = "DELETE  FROM PlantTable WHERE CustomID='"+model.CustomID+"'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                    Console.WriteLine("Удалено объектов: {0}", number);
                }

                main_page.Show();
                this.Close();

                MessageBox.Show("Сорт растения был удален.", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_parent_Click(object sender, EventArgs e)
        {
            if (model.ParentVariety != null)
            {
                Parent_request request = new Parent_request(textBox_number.Text);
                PlantTable parent_model = new PlantTable();
                parent_model = request.parent_request();

                Variety_page parent_page = new Variety_page(main_page, parent_model, this);

                this.Hide();
                parent_page.Show();
            }
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            Export helper = new Export("VarietyPage.docx");

            var items = new Dictionary<string, string>
            {
                {"CustomID",  model.CustomID.ToString()},
                {"Name", model.Name },
                {"Category", model.Category },
                {"Author", model.Author },
                {"ParentVariety", model.ParentVariety.ToString() },
                {"ParentN", textBox_Pname.Text },
                {"Productivity", model.Productivity.ToString() },
                {"FrostResistance", model.FrostResistance.ToString() },
                {"PestResistance", model.PestResistance },
                {"DiseaseResistance", model.DiseaseResistance }
            };

            if(helper.process(items))
                MessageBox.Show("Файл скачан успешно.", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Ошибка скачивания.", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox_category_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_LetterOnly(e);
        }

        private void textBox_author_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_LetterOnly(e);
        }

        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_DigitOnly(e);
        }

        private void textBox_Pname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_LetterOnly(e);
        }

        private void textBox_productivity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_DigitOnly(e);
        }

        private void textBox_frostResistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_DigitOnly(e);
        }

        private void richTextBox_pestResistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_LetterORDigitOrPunctuationMarks(e);
        }

        private void richTextBox_diseaseResistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_LetterORDigitOrPunctuationMarks(e);
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (enter_checker.button_add_ClickChecker(textBox_name.Text.Length,
                comboBox_category.Text.Length, textBox_author.Text.Length))
                button_change.Enabled = false;
            else
                button_change.Enabled = true;
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enter_checker.button_add_ClickChecker(textBox_name.Text.Length,
                comboBox_category.Text.Length, textBox_author.Text.Length))
                button_change.Enabled = false;
            else
                button_change.Enabled = true;
        }

        private void textBox_author_TextChanged(object sender, EventArgs e)
        {
            if (enter_checker.button_add_ClickChecker(textBox_name.Text.Length,
                comboBox_category.Text.Length, textBox_author.Text.Length))
                button_change.Enabled = false;
            else
                button_change.Enabled = true;
        }
    }
}
