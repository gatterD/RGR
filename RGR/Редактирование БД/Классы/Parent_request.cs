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
    public class Parent_request : Request
    {
        private string parent_index;
        private DataTable data_table;

        public Parent_request() { }

        public Parent_request(string current)
        {
            parent_index = current;
        }

        private void request()
        {
            string filter = "SELECT * FROM PlantTable WHERE CustomID LIKE '"
                    + parent_index + "'"; //Строка запроса

            data_table = new DataTable("PlantTable"); //Пустая таблица для результатов запроса
            SqlDataAdapter sql_data_adapter = new SqlDataAdapter(filter, connection); //Запрос к БД

            sql_data_adapter.Fill(data_table);
        }

        public string parent_name()
        {
            request();

            return data_table.Rows[0].Field<string>(1);
        }

        public PlantTable parent_request()
        {
            request();
            
            PlantTable model = new PlantTable();

            model.CustomID = data_table.Rows[0].Field<int>(0);
            model.Name = data_table.Rows[0].Field<string>(1);
            model.Category = data_table.Rows[0].Field<string>(2);
            model.Author = data_table.Rows[0].Field<string>(3);
            if (!data_table.Rows[0].IsNull(4))
                model.ParentVariety = data_table.Rows[0].Field<int>(4);
            if (!data_table.Rows[0].IsNull(5))
                model.Productivity = data_table.Rows[0].Field<double>(5);
            if (!data_table.Rows[0].IsNull(6))
                model.FrostResistance = data_table.Rows[0].Field<int>(6);
            if (!data_table.Rows[0].IsNull(7))
                model.PestResistance = data_table.Rows[0].Field<string>(7);
            if (!data_table.Rows[0].IsNull(8))
                model.DiseaseResistance = data_table.Rows[0].Field<string>(8);

            return model;
        }
    }
}
