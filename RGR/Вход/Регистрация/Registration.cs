using MaterialSkin.Controls;
using MySqlX.XDevAPI;
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

namespace RGR.Вход.Регистрация
{
    public partial class Registration : MaterialForm
    {
        private Autorisation auto_reg;
        private AutoRegis clientAutoReg = new AutoRegis();
        private Autorization autoBD = new Autorization();
        public Registration()
        {
            InitializeComponent();
            set_max_lenght();
        }

        public Registration(Autorisation client)
        {
            InitializeComponent();
            set_max_lenght();
            auto_reg = client;
        }
        private void set_max_lenght()
        {
            this.textBox_login.MaxLength = 20;
            this.textBox_pasword.MaxLength = 20;
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            auto_reg.Show();
            this.Close();   
        }

        private void transfer_cursor_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_pasword.Focus();
            }
        }

        private void cheking_result(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_registration_Click(sender, e);
                textBox_login.Focus();
            }
        }
        public bool result_search_log_pas()
        {
            autoBD.Name = textBox_login.Text;
            autoBD.Password = textBox_pasword.Text;
            string filter = "SELECT COUNT(*) FROM Autorization WHERE Name LIKE '" + autoBD.Name + "'";
            SqlCommand command = new SqlCommand(filter, clientAutoReg.connection);
            clientAutoReg.connection.Open();
            int UserCount = (int)command.ExecuteScalar();
            if (UserCount > 0)
            {
                clientAutoReg.connection.Close();
                return true;
            }
            else
            {
                clientAutoReg.connection.Close();
                return false;
            }
        }
        private void add_new_user()
        {
            autoBD.Name = textBox_login.Text;
            autoBD.Password = textBox_pasword.Text;
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\Users\\admin\\Desktop\\ИС-31 Марцинкевич Е.С. Георгиева Д.О\\БД\\PlantRegister.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
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
        private void button_registration_Click(object sender, EventArgs e)
        {
            if(result_search_log_pas())
            {
                MessageBox.Show("Данный логин уже существует, введите другое имя пользователя.", "Внимение!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_login.Text = "";
                textBox_pasword.Text = "";
            }
            else
            {
                
                if (textBox_login.Text == "")
                {
                    MessageBox.Show("Вы не ввели логин, для регистрации он обязателен.", "Внимение!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(textBox_login.Text == "")
                {
                    if(MessageBox.Show("Вы не ввели пароль, уверены что хотите продолжить регистрацию?", "Вы уверены?", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        add_new_user();
                        auto_reg.Show();
                        this.Close();
                    }
                    else
                    {
                        textBox_login.Text = "";
                        textBox_pasword.Text = "";
                    }
                }
                else
                {
                    add_new_user();
                    auto_reg.Show();
                    this.Close();
                }
            }
        }

        private void lock_spacebar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}
