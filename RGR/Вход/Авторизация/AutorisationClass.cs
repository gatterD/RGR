namespace RGR
{
    using MySqlX.XDevAPI;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web;
    using System.Windows.Forms;

    public class AutorisationClass : Search
    {

        private Autorization autoBD = new Autorization();
        public AutorisationClass(string Name, string Pass)
        {
            autoBD.Name = Name;
            autoBD.Password = Pass;
        }
        public bool autorization_oper_pas()
        {
            string filter = "SELECT COUNT(*) FROM Autorization WHERE Name LIKE '" + autoBD.Name + "'";
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
        public bool autorization_search_adm() 
        {
            string filter = "SELECT COUNT(*) FROM Autorization WHERE Name LIKE '" + autoBD.Name + "' and Password LIKE '" + autoBD.Password + "' and admin_mode LIKE 'True'";
            SqlCommand command = new SqlCommand(filter, connection);
            connection.Open();

            int admRights = (int)command.ExecuteScalar();
            if (admRights > 0)
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
        private object get_days()
        {
            string sqlExpression = "SELECT * FROM Autorization WHERE Name LIKE '" + autoBD.Name + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                object banTime = DateTime.Now;
                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3), reader.GetName(4));

                    while (reader.Read()) // построчно считываем данные
                    {
                        banTime = reader.GetValue(4);
                    }
                }
                reader.Close();
                connection.Close();
                return banTime;
            }
        }
        public bool cheking_ban_on_account()
        {
            object banTime = get_days();
            DateTime bantimeT;


            if (banTime.ToString() != "")
                bantimeT = DateTime.Parse(banTime.ToString());
            else
                return false;


            DateTime today = DateTime.Now;
            int col = (bantimeT.Date - today.Date).Days;
            if (col > 0)
            {
                MessageBox.Show($"Вы не сможете зайти в свой аккаунт ещё {col} дней.", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }
        public int get_col_days()
        {
            object banTime = get_days();
            DateTime bantimeT = DateTime.Parse(banTime.ToString());

            DateTime today = DateTime.Now;
            return (bantimeT.Date - today.Date).Days;
        }
    }
      
}
