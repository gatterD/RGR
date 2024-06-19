using System.Data;
using System.Data.SqlClient;

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
