using MaterialSkin;
using MaterialSkin.Controls;
using RGR.Message;
using RGR.Вход.Вход_в_режим_администратора;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RGR
{
    public partial class Main_page : MaterialForm
    {
        public bool admin_mode = false;
        private string acc_name;
        private Checkers enter_checker = new Checkers();
        private Messages info = new Messages();

        public Main_page()
        {
            InitializeComponent();
            ToolTip tips = new ToolTip();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500,
                Primary.Green600, Primary.Green300, Accent.Green700, TextShade.WHITE);
            tips.SetToolTip(this.button_simple_search, "Поиск");
            tips.SetToolTip(this.button_add, "Добавить");
            tips.SetToolTip(this.button_advanced_search, "Расширенный поиск");
            this.textBox_simple_search.MaxLength = 20;

        }
        public void get_acc_name(string Name)
        {
            acc_name = Name;
        }
        private void button_enter_Click(object sender, EventArgs e)
        {
            EntAdmin enter_page = new EntAdmin();

            this.Hide();
            enter_page.get_login(acc_name);
            enter_page.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_page_Activated(object sender, EventArgs e)
        {
            if (admin_mode)
            {
                button_add.Enabled = true;
                button_enter.Visible = false;
                button_exit.Visible = true;
            }
            else
            {
                button_add.Enabled = false;
                button_enter.Visible = true;
                button_exit.Visible = true;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            admin_mode = false;
            button_add.Enabled = false;
            button_enter.Visible = true;
            button_exit.Visible = false;
            Autorisation enter_page = new Autorisation();

            this.Close();
            enter_page.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.reference_message();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Add_request_page add_page = new Add_request_page(this);

            this.Hide();
            add_page.Show();
        }

        private void button_simple_search_Click(object sender, EventArgs e)
        {
            Search srch = new Search();
            string filter = "SELECT COUNT(*) FROM PlantTable WHERE Name LIKE '" + this.textBox_simple_search.Text + "'";
            SqlCommand command = new SqlCommand(filter, srch.connection);
            srch.connection.Open();
            int PlantCount = (int)command.ExecuteScalar();

            if (this.textBox_simple_search.Text == "")
            {
                srch.connection.Close();

                Arbirary_search new_search = new Arbirary_search(textBox_simple_search.Text);

                Match_page match_page = new Match_page(new_search.request(), this);

                this.Hide();
                match_page.Show();
            }
            else if (PlantCount > 0)
            {
                srch.connection.Close();

                Arbirary_search new_search = new Arbirary_search(textBox_simple_search.Text);

                Match_page match_page = new Match_page(new_search.request(), this);

                this.Hide();
                match_page.Show();
                SelfMessageBox mes = new SelfMessageBox($"Найдено {PlantCount} растений.");
                mes.Show();
            }
            else
            {
                SelfMessageBox mes = new SelfMessageBox($"Такого растения нет в БД.");
                mes.Show();
                srch.connection.Close();
            }

        }

        private void button_advanced_search_Click(object sender, EventArgs e)
        {
            Advanced_search_page advanced_page = new Advanced_search_page(this, textBox_simple_search.Text);

            this.Hide();
            advanced_page.Show();
        }

        private void simple_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_LetterOnly(e);
        }

        private void simple_search_Enter(object sender, KeyEventArgs e)
        {

        }
    }
}
