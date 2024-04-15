using MaterialSkin;
using MaterialSkin.Controls;
using MySqlX.XDevAPI.Common;
using RGR.Message;
using RGR.Вход.Регистрация;
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

namespace RGR
{
    public partial class Autorisation : MaterialForm
    {
        private Main_page main_page;
        private AutoRegis client = new AutoRegis();
        private Registration reg;


        public Autorisation()
        {
            InitializeComponent();
            main_page = new Main_page();
        }
        public bool result_search_log_pas()
        {
            string filter = "SELECT COUNT(*) FROM Autorization WHERE Name LIKE '" + textBox_login.Text + "' and Password LIKE '" + textBox_pasword.Text + "'";
            SqlCommand command = new SqlCommand(filter, client.connection);
            client.connection.Open();
            int UserCount = (int) command.ExecuteScalar();
            if (UserCount > 0)
            {
                client.connection.Close();
                return true;
            }
            else
            {
                client.connection.Close();
                return false;
            }
        }
        public bool result_search_adm()
        {
            string filter = "SELECT COUNT(*) FROM Autorization WHERE Name LIKE '" + textBox_login.Text + "' and Password LIKE '" + textBox_pasword.Text + "' and admin_mode LIKE 'True'";
            SqlCommand command = new SqlCommand(filter, client.connection);
            client.connection.Open();
            
            int admRights = (int)command.ExecuteScalar();
            if (admRights > 0)
            {
                client.connection.Close();
                return true;
            }
            else
            {
                client.connection.Close();
                return false;
            }
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            
            if (result_search_log_pas())
            {
                main_page.admin_mode = result_search_adm();

                main_page.Show();
                this.Hide();

                if(main_page.admin_mode)
                {
                    MessageBox.Show("Вы вошли как администратор.", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вы вошли как пользователь.", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {

                string sound = @"C:\Users\admin\Desktop\ИС-31 Марцинкевич Е.С. Георгиева Д.О.\RGR\RGR\Resources\goofy-ahh-laugh-meme.wav";
                string text = "Вы ввели неправильный логин или пароль!\r\nВведите информацию заново, проверив правильность введенных вами данных";
                SelfMessageBox ErrorPage = new SelfMessageBox(text, sound);
                ErrorPage.Show();

                textBox_login.Text = "";
                textBox_pasword.Text = "";
            }
        }

        private void Enter_administrator_Load(object sender, EventArgs e)
        {

        }

        private void transfer_cursor_enter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox_pasword.Focus();
            }
        }

        private void cheking_result(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_enter_Click(sender, e);
                textBox_login.Focus();
            }
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            reg = new Registration(this);
            reg.Show();
            this.Hide();
        }
    }
}
