namespace RGR
{
    partial class Match_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вНачалоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.глоссарийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.customIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentVarietyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frostResistanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pestResistanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseResistanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantRegisterDataSet = new RGR.PlantRegisterDataSet();
            this.plantTableTableAdapter = new RGR.PlantRegisterDataSetTableAdapters.PlantTableTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantRegisterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяToolStripMenuItem,
            this.вНачалоToolStripMenuItem,
            this.глоссарийToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // вНачалоToolStripMenuItem
            // 
            this.вНачалоToolStripMenuItem.Name = "вНачалоToolStripMenuItem";
            this.вНачалоToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.вНачалоToolStripMenuItem.Text = "В начало";
            this.вНачалоToolStripMenuItem.Click += new System.EventHandler(this.вНачалоToolStripMenuItem_Click);
            // 
            // глоссарийToolStripMenuItem
            // 
            this.глоссарийToolStripMenuItem.Name = "глоссарийToolStripMenuItem";
            this.глоссарийToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.глоссарийToolStripMenuItem.Text = "Глоссарий";
            this.глоссарийToolStripMenuItem.Click += new System.EventHandler(this.глоссарийToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.parentVarietyDataGridViewTextBoxColumn,
            this.productivityDataGridViewTextBoxColumn,
            this.frostResistanceDataGridViewTextBoxColumn,
            this.pestResistanceDataGridViewTextBoxColumn,
            this.diseaseResistanceDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.plantTableBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 86);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(937, 407);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // customIDDataGridViewTextBoxColumn
            // 
            this.customIDDataGridViewTextBoxColumn.DataPropertyName = "CustomID";
            this.customIDDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.customIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customIDDataGridViewTextBoxColumn.Name = "customIDDataGridViewTextBoxColumn";
            this.customIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentVarietyDataGridViewTextBoxColumn
            // 
            this.parentVarietyDataGridViewTextBoxColumn.DataPropertyName = "ParentVariety";
            this.parentVarietyDataGridViewTextBoxColumn.HeaderText = "Родительский сорт";
            this.parentVarietyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentVarietyDataGridViewTextBoxColumn.Name = "parentVarietyDataGridViewTextBoxColumn";
            this.parentVarietyDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentVarietyDataGridViewTextBoxColumn.Width = 125;
            // 
            // productivityDataGridViewTextBoxColumn
            // 
            this.productivityDataGridViewTextBoxColumn.DataPropertyName = "Productivity";
            this.productivityDataGridViewTextBoxColumn.HeaderText = "Урожайность";
            this.productivityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productivityDataGridViewTextBoxColumn.Name = "productivityDataGridViewTextBoxColumn";
            this.productivityDataGridViewTextBoxColumn.ReadOnly = true;
            this.productivityDataGridViewTextBoxColumn.Visible = false;
            this.productivityDataGridViewTextBoxColumn.Width = 125;
            // 
            // frostResistanceDataGridViewTextBoxColumn
            // 
            this.frostResistanceDataGridViewTextBoxColumn.DataPropertyName = "FrostResistance";
            this.frostResistanceDataGridViewTextBoxColumn.HeaderText = "Морозостойкость";
            this.frostResistanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frostResistanceDataGridViewTextBoxColumn.Name = "frostResistanceDataGridViewTextBoxColumn";
            this.frostResistanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.frostResistanceDataGridViewTextBoxColumn.Visible = false;
            this.frostResistanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // pestResistanceDataGridViewTextBoxColumn
            // 
            this.pestResistanceDataGridViewTextBoxColumn.DataPropertyName = "PestResistance";
            this.pestResistanceDataGridViewTextBoxColumn.HeaderText = "Устойчивость к вредителям";
            this.pestResistanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pestResistanceDataGridViewTextBoxColumn.Name = "pestResistanceDataGridViewTextBoxColumn";
            this.pestResistanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.pestResistanceDataGridViewTextBoxColumn.Visible = false;
            this.pestResistanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // diseaseResistanceDataGridViewTextBoxColumn
            // 
            this.diseaseResistanceDataGridViewTextBoxColumn.DataPropertyName = "DiseaseResistance";
            this.diseaseResistanceDataGridViewTextBoxColumn.HeaderText = "Устойчивость к болезням";
            this.diseaseResistanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diseaseResistanceDataGridViewTextBoxColumn.Name = "diseaseResistanceDataGridViewTextBoxColumn";
            this.diseaseResistanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.diseaseResistanceDataGridViewTextBoxColumn.Visible = false;
            this.diseaseResistanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // plantTableBindingSource
            // 
            this.plantTableBindingSource.DataMember = "PlantTable";
            this.plantTableBindingSource.DataSource = this.plantRegisterDataSet;
            // 
            // plantRegisterDataSet
            // 
            this.plantRegisterDataSet.DataSetName = "PlantRegisterDataSet";
            this.plantRegisterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plantTableTableAdapter
            // 
            this.plantTableTableAdapter.ClearBeforeFill = true;
            // 
            // Match_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 505);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(961, 505);
            this.MinimumSize = new System.Drawing.Size(961, 505);
            this.Name = "Match_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страница совпадений";
            this.Load += new System.EventHandler(this.Match_page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantRegisterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private PlantRegisterDataSet plantRegisterDataSet;
        private System.Windows.Forms.BindingSource plantTableBindingSource;
        private PlantRegisterDataSetTableAdapters.PlantTableTableAdapter plantTableTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem глоссарийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вНачалоToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn customIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentVarietyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productivityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frostResistanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pestResistanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseResistanceDataGridViewTextBoxColumn;
    }
}