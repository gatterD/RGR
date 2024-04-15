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
    public class Advanced_search : Search
    {
        private string filter;

        public Advanced_search() { }

        public Advanced_search(string name, string category, string author, string p_number,
            string productivity, string f_resistance, string p_resistance,
            string d_resistance, string p_name)
        {
            if (p_name.Length != 0 && p_number.Length == 0) //Проверка на пустое поле и отсутствие индекса
            {
                string l_filter = "SELECT * FROM PlantTable WHERE Name LIKE '"
                + p_name + "'"; //Строка запроса

                DataTable data_table = new DataTable("PlantTable"); //Пустая таблица для результатов запроса
                SqlDataAdapter sql_data_adapter = new SqlDataAdapter(l_filter, connection); //Запрос к БД

                sql_data_adapter.Fill(data_table); //Заполнение пустой таблицы результатами запроса
               
                p_number = data_table.Rows[0].Field<int>(0).ToString(); //Индекс родительского сорта по его названию
            }

            filter = "SELECT * FROM PlantTable WHERE ";

            if(name.Length != 0)
                filter = filter + "Name LIKE '" + name + "%' AND ";
            if (category.Length != 0)
                filter = filter + "Category LIKE '" + category + "' AND ";
            if (author.Length != 0)
                filter = filter + "Author LIKE '" + author + "%' AND ";
            if (p_number.Length != 0)
                filter = filter + "ParentVariety LIKE '" + p_number + "' AND ";
            if (productivity.Length != 0)
                filter = filter + "Productivity LIKE '" + productivity + "' AND ";
            if (f_resistance.Length != 0)
                filter = filter + "FrostResistance LIKE '" + f_resistance + "' AND ";
            if (p_resistance.Length != 0)
                filter = filter + "PestResistance LIKE '" + p_resistance + "%' AND ";
            if (d_resistance.Length != 0)
                filter = filter + "DiseaseResistance LIKE '" + d_resistance + "%' AND ";

            filter = filter.Remove(filter.Length - 4, 3);
        }

        public DataTable request()
        {
            DataTable data_table = new DataTable("PlantTable"); //Пустая таблица для результатов запроса
            SqlDataAdapter sql_data_adapter = new SqlDataAdapter(filter, connection); //Запрос к БД

            sql_data_adapter.Fill(data_table); //Заполнение пустой таблицы результатами запроса

            return data_table;
        }

    }
}
