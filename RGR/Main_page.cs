using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR
{
    public partial class Main_page : MaterialForm
    {
        public bool admin_mode = false;
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

        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            Autorisation enter_page = new Autorisation();

            this.Hide();
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
            Arbirary_search new_search = new Arbirary_search(simple_search.Text);

            Match_page match_page = new Match_page(new_search.request(), this);

            this.Hide();
            match_page.Show();
        }

        private void button_advanced_search_Click(object sender, EventArgs e)
        {
            Advanced_search_page advanced_page = new Advanced_search_page(this, simple_search.Text);

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
