﻿using MaterialSkin.Controls;
using RGR.Страница_сорта;
using System;
using System.Data;
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
        private Changing chan_var;
        private Delete_request del_sort_tr;
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
            set_max_lenght();
        }

        public Variety_page(Main_page m_page, PlantTable current, Variety_page r_page)
        {
            InitializeComponent();
            main_page = m_page;
            model = current;
            child_page = r_page;
            position = false;
            set_max_lenght();
        }
        private void set_max_lenght()
        {
            this.textBox_name.MaxLength = 20;
            this.textBox_author.MaxLength = 20;
            this.textBox_number.MaxLength = 3;
            this.textBox_productivity.MaxLength = 3;
            this.textBox_frostResistance.MaxLength = 1;
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
            if (position)
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

            if (model.ParentVariety != null)
            {
                Parent_request request = new Parent_request(textBox_number.Text);
                textBox_Pname.Text = request.parent_name();
            }
            else
            {
                button_parent.Enabled = false;
            }

            if (main_page.admin_mode)
            {
                textBox_name.ReadOnly = textBox_author.ReadOnly = textBox_number.ReadOnly =
                    textBox_Pname.ReadOnly = textBox_productivity.ReadOnly =
                    textBox_frostResistance.ReadOnly = richTextBox_pestResistance.ReadOnly =
                    richTextBox_diseaseResistance.ReadOnly = false;

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
                chan_var = new Changing(textBox_name.Text.Trim(), comboBox_category.Text.Trim(), textBox_author.Text.Trim(),
                    textBox_number.Text, textBox_productivity.Text, textBox_frostResistance.Text, richTextBox_pestResistance.Text.Trim(),
                    richTextBox_diseaseResistance.Text.Trim(), model.CustomID);
                chan_var.change_sort();

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
                del_sort_tr = new Delete_request(model);
                del_sort_tr.del_sort();

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
            var query = "select * from PlantTable where CustomID LIKE '" + model.CustomID + "'";

            var datatable = new DataTable();

            queryReturnData(query, datatable);
            ExportToWord(datatable);
        }
        public DataTable queryReturnData(string query, DataTable dataTable)
        {
            string con = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\Users\\admin\\Desktop\\ИС-31 Марцинкевич Е.С. Георгиева Д.О\\БД\\PlantRegister.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();

            SqlDataAdapter SDA = new SqlDataAdapter(query, myCon);
            SDA.SelectCommand.ExecuteNonQuery();

            SDA.Fill(dataTable);
            return dataTable;
        }
        private void ExportToWord(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                Export word = new Export(dataTable);
                word.createWord();
            }
            else
            {
                MessageBox.Show("No data to export!");
            }
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
