using MaterialSkin.Controls;
using RGR.Message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR.Вход.Вход_в_режим_администратора
{
    public partial class EntAdmin : MaterialForm
    {
        private Main_page main_page;
        private string login;
        private int col_of_attempt;
        private string password;
        public EntAdmin()
        {
            InitializeComponent();
            password = "115599";
            main_page = new Main_page();
            col_of_attempt = 3;
            set_max_lenght();
        }
        private void set_max_lenght()
        {
            this.textBox_pasword.MaxLength = 20;
        }
        public void get_login(string Name)
        {
            login = Name;
        }
        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();

            main_page.Show();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string pass = this.textBox_pasword.Text;
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\Users\\admin\\Desktop\\ИС-31 Марцинкевич Е.С. Георгиева Д.О\\БД\\PlantRegister.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            if (pass != password)
            {
                col_of_attempt--;
                string sps = (col_of_attempt == 2) ? "попытки" : col_of_attempt == 1 ? "попытка" : "попыток";
                if (col_of_attempt == 0)
                {
                    this.Close();
                    main_page.Show();
                }
                SelfMessageBox mes = new SelfMessageBox($"Вы ввели неправильный код, у вас осталось {col_of_attempt} {sps}!");
                mes.Show();
            }
            else
            {

                string sqlExpression;
                sqlExpression = "UPDATE Autorization SET admin_mode= 'True' WHERE Name= '" + login + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                    Console.WriteLine("Обновлено объектов: {0}", number);
                }
                SelfMessageBox mes = new SelfMessageBox($"Вы ввели правильный код, вы получили доступ к функциям администратора.");
                
                
                main_page.admin_mode = true;
                main_page.Show();
                mes.Show();
                this.Close();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
