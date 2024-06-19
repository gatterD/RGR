using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace RGR
{
    public partial class Add_request_page : MaterialForm
    {
        private Checkers enter_checker = new Checkers(); // Поле-объект класса проверок пользовательских данных
        private Messages info = new Messages();
        private Main_page main_page; //Поле возврата на начальную страниц
        private Add_request adding;

        public Add_request_page() //Инициализация по умолчанию
        {
            InitializeComponent();
            set_max_lenght();

        }

        public Add_request_page(Main_page page) //Инициализация со стартовой страницы
        {
            InitializeComponent();
            set_max_lenght();
            main_page = page;
        }
        private void set_max_lenght()
        {
            this.textBox_name.MaxLength = 20;
            this.textBox_author.MaxLength = 20;
            this.textBox_number.MaxLength = 3;
            this.textBox_productivity.MaxLength = 2;
            this.textBox_frostResistance.MaxLength = 1;
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
                adding = new Add_request(textBox_name.Text.Trim(), comboBox_category.Text.Trim(), textBox_author.Text.Trim(),
                    textBox_number.Text, textBox_productivity.Text, textBox_frostResistance.Text, richTextBox_pestResistance.Text.Trim(),
                    richTextBox_diseaseResistance.Text.Trim());
                adding.adding_new_sort();

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