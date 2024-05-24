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
        public void adding_new_user()
        {

        }
    }
}
