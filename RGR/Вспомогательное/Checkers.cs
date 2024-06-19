using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RGR
{
    public class Checkers : Search
    {
        public bool enter_Cheker_LetterOnly(KeyPressEventArgs e) //Проверка только на буквы и пробел.
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (int)Keys.Back)
                return false;
            else
                return true;
        }

        public bool enter_Cheker_DigitOnly(KeyPressEventArgs e) //Проверка на цыфры.
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (int)Keys.Back)
                return false;
            else
                return true;
        }

        public bool enter_Cheker_LetterORDigitOrPunctuationMarks(KeyPressEventArgs e)
        { //Проверка на буквы, цыфры, некоторые знаки препинания и пробел.
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '.' ||
                e.KeyChar == ',' || e.KeyChar == ' ' || e.KeyChar == '-' ||
                e.KeyChar == (int)Keys.Back)
                return false;
            else
                return true;
        }

        public bool button_add_ClickChecker(int l_name, int l_category, int l_author) //Метод проверки заполнения обязательных полей интерфейса
        {
            if (l_name == 0 || l_category == 0 || l_author == 0)
                return true;
            else
                return false;
        }

        public bool parent_and_frost_Checker(string f_resis, string number, string name) //Метод проверки пользовательских данных
        {
            bool main_checker = true; //Триггер
            int frost_resistance; //Показатель морозостойскости
            //Характеристика морозостойскости должна быть в пределе от 1 до 5
            if (f_resis.Length != 0) //Проверка на пустое поле
            {
                frost_resistance = Convert.ToInt32(f_resis);

                if (frost_resistance > 5 || frost_resistance < 1) //Проверка данных
                {
                    MessageBox.Show("Некорректная морозостойкость!\nОбратитесь к глоссарию.",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error); //Сообщение об ошибке

                    main_checker = false; //Изменение триггера
                }
            }
            //Проверка существует ли указанный родительский индекс
            if (number.Length != 0) //Проверка на пустое поле
            {
                string filter = "SELECT * FROM PlantTable WHERE CustomID LIKE '"
                    + number + "'"; //Строка запроса

                DataTable data_table = new DataTable("PlantTable"); //Пустая таблица для результатов запроса
                SqlDataAdapter sql_data_adapter = new SqlDataAdapter(filter, connection); //Запрос к БД

                sql_data_adapter.Fill(data_table); //Заполнение пустой таблицы результатами запроса

                if (data_table.Rows.Count != 1) //Проверка имеется ли хоть один результат в запросе
                {
                    MessageBox.Show("Несуществующий индекс сорта!",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error); //Сообщение об ошибке

                    main_checker = false; //Изменение триггера
                }
            }
            //Проверка существует ли указанное название родительского сорта
            if (name.Length != 0 && number.Length == 0) //Проверка на пустое поле и отсутствие индекса
            {
                string filter = "SELECT * FROM PlantTable WHERE Name LIKE '"
                    + name + "'"; //Строка запроса

                DataTable data_table = new DataTable("PlantTable"); //Пустая таблица для результатов запроса
                SqlDataAdapter sql_data_adapter = new SqlDataAdapter(filter, connection); //Запрос к БД

                sql_data_adapter.Fill(data_table); //Заполнение пустой таблицы результатами запроса

                if (data_table.Rows.Count != 1) //Проверка имеется ли хоть один результат в запросе
                {
                    MessageBox.Show("Несуществующие название сорта!",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error); //Сообщение об ошибке

                    main_checker = false; //Изменение триггера
                }
            }

            return main_checker; //Возврат триггера после всех проверок
        }
    }
}
