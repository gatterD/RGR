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
    public class Arbirary_search : Search
    {
        private string search;

        public Arbirary_search() { }

        public Arbirary_search(string current_search)
        {
            search = current_search;
        }

        public DataTable request()
        {
            string filter = "SELECT * FROM PlantTable WHERE Name LIKE '" + search + "%'";
          
            DataTable data_table = new DataTable("PlantTable"); //Пустая таблица для результатов запроса
            SqlDataAdapter sql_data_adapter = new SqlDataAdapter(filter, connection); //Запрос к БД

            sql_data_adapter.Fill(data_table); //Заполнение пустой таблицы результатами запроса

            return data_table;
        }
    }
}
