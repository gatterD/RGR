using System;
using System.Data.SqlClient;

namespace RGR
{

    public class Delete_request : Request
    {

        private PlantTable model = new PlantTable(); //Поле-кортеж базы данны

        public Delete_request(PlantTable modelGet)
        {
            model = modelGet;
        }

        public void del_sort()
        {

            string sqlExpression = "UPDATE PlantTable SET ParentVariety=NULL WHERE ParentVariety= '" + model.CustomID + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Обновлено объектов: {0}", number);
            }
            sqlExpression = "DELETE  FROM PlantTable WHERE CustomID='" + model.CustomID + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Удалено объектов: {0}", number);
            }
        }
    }
}
