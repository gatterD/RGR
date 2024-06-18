using MaterialSkin.Controls;
using Microsoft.Office.Core;
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
    public partial class ResAcc : MaterialForm
    {
        private string login;
        private int col_of_attempt;
        private string password;
        private Autorisation auto;
        SelfMessageBox mes;
        public ResAcc()
        {
            InitializeComponent();
            password = "335577";
            auto = new Autorisation();
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

            auto.Show();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            button_return.Visible = false;
            string pass = this.textBox_pasword.Text;
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\Users\\admin\\Desktop\\ИС-31 Марцинкевич Е.С. Георгиева Д.О\\БД\\PlantRegister.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            if (pass != password)
            {
                col_of_attempt--;
                string sps = (col_of_attempt == 2) ? "попытки" : col_of_attempt == 1 ? "попытка" : "попыток";
                if (col_of_attempt == 0)
                {
                    this.Close();

                    DateTime newTime = DateTime.Now.AddDays(360);
                    string sqlExpression = "UPDATE Autorization SET DataBan = '" + newTime.Date.ToString() + "' WHERE Name= '" + login + "'";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        int number = command.ExecuteNonQuery();
                        Console.WriteLine("Обновлено объектов: {0}", number);
                    }

                    mes = new SelfMessageBox("Вы ввели код неправильно три раза, ваш аккаунт заблокирован на год, и не подлежит разблокировке до момента истечения срока!");
                    auto.Show(); 
                    mes.Show();
                    
                    return;
                }
                mes = new SelfMessageBox($"Вы ввели неправильный код, у вас осталось {col_of_attempt} {sps}!");
                mes.Show();
            }
            else
            {

                string sqlExpression = "UPDATE Autorization SET DataBan = NULL WHERE Name= '" + login + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                    Console.WriteLine("Обновлено объектов: {0}", number);
                }
                mes = new SelfMessageBox($"Вы ввели правильный код, вы получили доступ к аккаунту.");


                auto.Show();
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
