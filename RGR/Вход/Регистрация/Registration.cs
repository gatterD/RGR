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

namespace RGR.Вход.Регистрация
{
    public partial class Registration : MaterialForm
    {
        private Autorisation auto_reg;
        private RegistrationClass Reg_var;
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
            Reg_var = new RegistrationClass(textBox_login.Text, textBox_pasword.Text);
            return Reg_var.registration_oper_pas();
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
                        Reg_var = new RegistrationClass(textBox_login.Text, textBox_pasword.Text);
                        Reg_var.adding_new_user();
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
                    Reg_var = new RegistrationClass(textBox_login.Text, textBox_pasword.Text);
                    Reg_var.adding_new_user();
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
