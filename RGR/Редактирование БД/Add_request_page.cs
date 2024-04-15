﻿using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RGR
{
    public partial class Add_request_page : MaterialForm
    {
        private PlantTable model = new PlantTable(); //Поле-кортеж базы данных
        private Checkers enter_checker = new Checkers(); // Поле-объект класса проверок пользовательских данных
        private Messages info = new Messages();
        private Main_page main_page; //Поле возврата на начальную страниц

        public Add_request_page() //Инициализация по умолчанию
        {
            InitializeComponent();
            this.textBox_name.MaxLength = 20;
            this.textBox_author.MaxLength = 20;
            this.textBox_number.MaxLength = 3;
            this.textBox_productivity.MaxLength = 1;
            this.textBox_frostResistance.MaxLength = 1;

        }

        public Add_request_page(Main_page page) //Инициализация со стартовой страницы
        {
            InitializeComponent();
            main_page = page;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка "Справка"
        {
            info.reference_message();
        }

        private void глоссарийToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка "Глоссарий"
        {
            info.glossary_message();
        }

        void return_home() //Метод возврата
        {
            main_page.Show();
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка "Выход"
        {
            return_home();
        }

        private void button_add_Click(object sender, EventArgs e) //Кнопка "Создать"
        {
            if (enter_checker.parent_and_frost_Checker(textBox_frostResistance.Text, textBox_number.Text, textBox_Pname.Text))
            { //Проверка требований к пользовательским данным
                model.Name = textBox_name.Text.Trim(); //Название сорта
                model.Category = comboBox_category.Text.Trim(); //Категория сорта
                model.Author = textBox_author.Text.Trim(); //Автор сорка

                if (textBox_number.Text.Length != 0) //Проверка на пустое поле
                    model.ParentVariety = Convert.ToInt32(textBox_number.Text); //Индекс родительского сорта

                if (textBox_productivity.Text.Length != 0) //Проверка на пустое поле
                    model.Productivity = Convert.ToInt32(textBox_productivity.Text); //Урожайность

                if (textBox_frostResistance.Text.Length != 0) //Проверка на пустое поле
                    model.FrostResistance = Convert.ToInt32(textBox_frostResistance.Text); //Морозостойкость

                model.PestResistance = richTextBox_pestResistance.Text.Trim(); //Устойчивость к вредителям
                model.DiseaseResistance = richTextBox_diseaseResistance.Text.Trim(); //Устойчивость к болезням

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\Users\\admin\\Desktop\\ИС-31 Марцинкевич Е.С. Георгиева Д.О\\БД\\PlantRegister.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                string sqlExpression;
                if (model.ParentVariety != null)
                {
                    sqlExpression = "INSERT INTO PlantTable (Name, Category, Author, ParentVariety, Productivity, FrostResistance, PestResistance, DiseaseResistance) " +
                        "VALUES ('" + model.Name + "', '" + model.Category + "', '" + model.Author + "', " + model.ParentVariety + ", " + model.Productivity + ", " +
                        "" + model.FrostResistance + ", '" + model.PestResistance + "', '" + model.DiseaseResistance + "')";
                }
                else
                {
                    sqlExpression = "INSERT INTO PlantTable (Name, Category, Author, ParentVariety, Productivity, FrostResistance, PestResistance, DiseaseResistance) " +
                        "VALUES ('" + model.Name + "', '" + model.Category + "', '" + model.Author + "', NULL, " + model.Productivity + ", " +
                        "" + model.FrostResistance + ", '" + model.PestResistance + "', '" + model.DiseaseResistance + "')";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                    Console.WriteLine("Добавлено объектов: {0}", number);
                }
                Console.Read();

                return_home(); //Возврат на начальную страницу

                MessageBox.Show("Сорт растения был создан.", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); //Сообщение об успешности создания нового сорта
            }
        }

        //Методы проверки соответствующих полей интерфейса
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

        private void comboBox_category_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Методы блокирующие кнопку "Создать" до момента заполнения обязательных полей
        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (enter_checker.button_add_ClickChecker(textBox_name.Text.Length,
                comboBox_category.Text.Length, textBox_author.Text.Length))
                button_add.Enabled = false;
            else
                button_add.Enabled = true;
        }

        private void comboBox_category_TextChanged(object sender, EventArgs e)
        {
            if (enter_checker.button_add_ClickChecker(textBox_name.Text.Length,
                comboBox_category.Text.Length, textBox_author.Text.Length))
                button_add.Enabled = false;
            else
                button_add.Enabled = true;
        }

        private void textBox_author_TextChanged(object sender, EventArgs e)
        {
            if (enter_checker.button_add_ClickChecker(textBox_name.Text.Length,
                comboBox_category.Text.Length, textBox_author.Text.Length))
                button_add.Enabled = false;
            else
                button_add.Enabled = true;
        }
    }
}