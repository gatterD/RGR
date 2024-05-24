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
        private Registration reg;
        private AutorisationClass AuCl;

        public Autorisation()
        {
            InitializeComponent();
            set_max_lenght();
            main_page = new Main_page();
        }
        private void set_max_lenght()
        {
            this.textBox_login.MaxLength = 20;
            this.textBox_pasword.MaxLength = 20;
        }
        public bool result_search_log_pas()
        {
            AuCl = new AutorisationClass(textBox_login.Text, textBox_pasword.Text);
            return AuCl.autorization_oper_pas();
        }
        public bool result_search_adm()
        {
            AuCl = new AutorisationClass(textBox_login.Text, textBox_pasword.Text);
            return AuCl.autorization_search_adm();
            
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
                main_page.get_acc_name(this.textBox_login.Text); 
                
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
                string image = "C:\\Users\\admin\\Desktop\\ИС-31 Марцинкевич Е.С. Георгиева Д.О\\RGR\\RGR\\Images\\3x.png";
                SelfMessageBox ErrorPage = new SelfMessageBox(text, sound,image);
                ErrorPage.Show();

                textBox_login.Text = "";
                textBox_pasword.Text = "";
            }
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
