namespace RGR
{
    partial class Main_page
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_page));
            this.simple_search = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_enter = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_advanced_search = new System.Windows.Forms.Button();
            this.button_simple_search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_search = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // simple_search
            // 
            this.simple_search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.simple_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simple_search.Location = new System.Drawing.Point(33, 113);
            this.simple_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simple_search.Name = "simple_search";
            this.simple_search.Size = new System.Drawing.Size(273, 26);
            this.simple_search.TabIndex = 0;
            this.simple_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.simple_search_Enter);
            this.simple_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.simple_search_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(450, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // button_enter
            // 
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button_enter.Image = ((System.Drawing.Image)(resources.GetObject("button_enter.Image")));
            this.button_enter.Location = new System.Drawing.Point(242, 269);
            this.button_enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(187, 70);
            this.button_enter.TabIndex = 5;
            this.button_enter.Text = "Войти в режим администратора";
            this.button_enter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button_exit.Image = global::RGR.Properties.Resources.Vykhod24;
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_exit.Location = new System.Drawing.Point(33, 269);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(179, 70);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Выйти из аккаунта";
            this.button_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Visible = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_add
            // 
            this.button_add.Enabled = false;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Image = global::RGR.Properties.Resources.Rezhim_redaktirovania24;
            this.button_add.Location = new System.Drawing.Point(394, 110);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(35, 35);
            this.button_add.TabIndex = 6;
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_advanced_search
            // 
            this.button_advanced_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.button_advanced_search.Image = global::RGR.Properties.Resources.Rasshirenny_poisk24;
            this.button_advanced_search.Location = new System.Drawing.Point(353, 110);
            this.button_advanced_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_advanced_search.Name = "button_advanced_search";
            this.button_advanced_search.Size = new System.Drawing.Size(35, 35);
            this.button_advanced_search.TabIndex = 4;
            this.button_advanced_search.UseVisualStyleBackColor = true;
            this.button_advanced_search.Click += new System.EventHandler(this.button_advanced_search_Click);
            // 
            // button_simple_search
            // 
            this.button_simple_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_simple_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_simple_search.Image = global::RGR.Properties.Resources.Poisk24;
            this.button_simple_search.Location = new System.Drawing.Point(312, 110);
            this.button_simple_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_simple_search.Name = "button_simple_search";
            this.button_simple_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_simple_search.Size = new System.Drawing.Size(35, 35);
            this.button_simple_search.TabIndex = 1;
            this.button_simple_search.UseVisualStyleBackColor = true;
            this.button_simple_search.Click += new System.EventHandler(this.button_simple_search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 127);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.BackColor = System.Drawing.Color.Transparent;
            this.label_search.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_search.Location = new System.Drawing.Point(28, 86);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(68, 25);
            this.label_search.TabIndex = 9;
            this.label_search.Text = "Поиск";
            // 
            // Main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.ControlBox = false;
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.button_advanced_search);
            this.Controls.Add(this.button_simple_search);
            this.Controls.Add(this.simple_search);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(450, 350);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "Main_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "              Реестр сортов растений";
            this.Activated += new System.EventHandler(this.Main_page_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox simple_search;
        private System.Windows.Forms.Button button_simple_search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button button_advanced_search;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_search;
    }
}

