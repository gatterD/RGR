namespace RGR
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class RegistrationClass : Search
    {
        private Autorization autoBD = new Autorization();
        public RegistrationClass(string Name, string Pass)
        {
            autoBD.Name = Name;
            autoBD.Password = Pass;
        }
        public bool registration_oper_pas()
        {
            string filter = "SELECT COUNT(*) FROM Autorization WHERE Name LIKE '" + autoBD.Name + "' and Password LIKE '" + autoBD.Password + "'";
            SqlCommand command = new SqlCommand(filter, connection);
            connection.Open();
            int UserCount = (int)command.ExecuteScalar();
            if (UserCount > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public void adding_new_user()
        {
            string sqlExpression = "INSERT INTO Autorization (Name, Password, admin_mode) " +
                        "VALUES ('" + autoBD.Name + "', '" + autoBD.Password + "', 'False')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
            Console.Read();
            MessageBox.Show("Пользователь успешно зарегистрирован.", "Пользователь зарегистрирован.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
