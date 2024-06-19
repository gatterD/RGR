using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;

namespace RGR
{
    public partial class Match_page : MaterialForm
    {
        private DataTable data_table;
        private Main_page return_page;
        private Advanced_search_page search_page;
        private Messages info = new Messages();
        private bool position;

        public Match_page()
        {
            InitializeComponent();
        }

        public Match_page(DataTable d_table, Main_page page)
        {
            InitializeComponent();
            data_table = d_table;
            return_page = page;
            position = true;
        }

        public Match_page(DataTable d_table, Advanced_search_page page, Main_page main_page)
        {
            InitializeComponent();
            data_table = d_table;
            search_page = page;
            return_page = main_page;
            position = false;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.reference_message();
        }

        private void глоссарийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.glossary_message();
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (position)
            {
                return_page.Show();
                this.Close();
            }
            else
            {
                search_page.Show();
                this.Close();
            }
        }

        private void вНачалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return_page.Show();
            if (!position)
                search_page.Close();
            this.Close();
        }

        private void Match_page_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "plantRegisterDataSet.PlantTable". При необходимости она может быть перемещена или удалена.
            //this.plantTableTableAdapter.Fill(this.plantRegisterDataSet.PlantTable);
            dataGridView.DataSource = data_table;
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Index != -1 && dataGridView.CurrentRow.Index != dataGridView.RowCount - 1)
            {
                PlantTable model = new PlantTable();

                model.CustomID =
                    Convert.ToInt32(dataGridView.CurrentRow.Cells["customIDDataGridViewTextBoxColumn"].Value);
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\Users\admin\Desktop\ИС-31 Марцинкевич Е.С. Георгиева Д.О\БД\PlantRegister.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                string sqlExpression = "SELECT * FROM PlantTable Where CustomID LIKE " + model.CustomID;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read()) // построчно считываем данные
                        {
                            object id = reader.GetValue(0);
                            object name = reader.GetValue(1);
                            object Category = reader.GetValue(2);
                            object Author = reader.GetValue(3);
                            object ParentVariety = reader.GetValue(4);
                            object Productivity = reader.GetValue(5);
                            object FrostResistance = reader.GetValue(6);
                            object PestResistance = reader.GetValue(7);
                            object DiseaseResistance = reader.GetValue(8);




                            model.CustomID = Convert.ToInt32(id);
                            model.Name = Convert.ToString(name);
                            model.Category = Convert.ToString(Category);
                            model.Author = Convert.ToString(Author);
                            if (!(ParentVariety == DBNull.Value)) model.ParentVariety = Convert.ToInt32(ParentVariety);
                            else model.ParentVariety = null;
                            if (!(Productivity == DBNull.Value)) model.Productivity = Convert.ToDouble(Productivity);
                            else model.Productivity = null;
                            model.FrostResistance = Convert.ToInt32(FrostResistance);
                            model.PestResistance = Convert.ToString(PestResistance);
                            model.DiseaseResistance = Convert.ToString(DiseaseResistance);

                            Console.WriteLine("{0} \t{1} \t{2} \t{3} \t{4} \t{5} \t{6} \t{7} \t{8}",
                                id, name, Category, Author, ParentVariety, Productivity, FrostResistance, PestResistance, DiseaseResistance);
                        }
                    }
                    reader.Close();
                }

                Variety_page current_variety = new Variety_page(this, return_page, model);

                this.Hide();
                current_variety.Show();
            }
        }
    }
}
