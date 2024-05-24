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
    public partial class Advanced_search_page : MaterialForm
    {
        private Messages info = new Messages();
        private Checkers enter_checker = new Checkers();
        private Main_page return_page;
        private string search_name;

        public Advanced_search_page()
        {
            InitializeComponent();
            set_max_lenght();
        }

        public Advanced_search_page(Main_page page, string current_name)
        {
            InitializeComponent();
            set_max_lenght();
            return_page = page;
            search_name = current_name;
        }

        private void Advanced_search_page_Load(object sender, EventArgs e)
        {
            textBox_name.Text = search_name;
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return_page.Show();
            this.Close();
        }

        private void глоссарийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.glossary_message();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.reference_message();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (enter_checker.parent_and_frost_Checker(textBox_frostResistance.Text, textBox_number.Text, textBox_Pname.Text))
            {
                Advanced_search new_search
                    = new Advanced_search(textBox_name.Text, comboBox_category.Text,
                    textBox_author.Text, textBox_number.Text, textBox_productivity.Text,
                    textBox_frostResistance.Text, richTextBox_pestResistance.Text,
                    richTextBox_diseaseResistance.Text, textBox_Pname.Text);

                Match_page match_page = new Match_page(new_search.request(), this, return_page);

                this.Hide();
                match_page.Show();
            }
        }
        private void set_max_lenght()
        {
            this.textBox_name.MaxLength = 20;
            this.textBox_author.MaxLength = 20;
            this.textBox_number.MaxLength = 3;
            this.textBox_productivity.MaxLength = 2;
            this.textBox_frostResistance.MaxLength = 1;
        }
        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_LetterOnly(e);
        }

        private void textBox_author_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_LetterOnly(e);
        }

        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_DigitOnly(e);
        }

        private void textBox_Pname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_LetterOnly(e);
        }

        private void textBox_productivity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_DigitOnly(e);
        }

        private void textBox_frostResistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_DigitOnly(e);
        }

        private void richTextBox_pestResistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_LetterORDigitOrPunctuationMarks(e);
        }

        private void richTextBox_diseaseResistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enter_checker.enter_Cheker_LetterORDigitOrPunctuationMarks(e);
        }

        private void comboBox_category_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void next_option_select(object sender, EventArgs e)
        {
            textBox_author.Focus();
        }

        private void next_CatOption_select_KeyEnterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) comboBox_category.Focus();
        }

        private void next_option_select_KeyEnterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SelectNextControl((TextBox)sender, true, true, true, true);
        }

        private void next_RichOption_select_KeyEnterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SelectNextControl((TextBox)sender, true, true, true, true);
        }

        private void next_NumberOption_select_KeyEnterPress(object sender, KeyEventArgs e)
        {
            textBox_number.Focus();
        }
    }
}
