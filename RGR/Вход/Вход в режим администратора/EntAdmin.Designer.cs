namespace RGR.Вход.Вход_в_режим_администратора
{
    partial class EntAdmin
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
            this.button_return = new System.Windows.Forms.Button();
            this.button_enter = new System.Windows.Forms.Button();
            this.textBox_pasword = new System.Windows.Forms.TextBox();
            this.label_pasword = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_return
            // 
            this.button_return.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_return.Location = new System.Drawing.Point(249, 197);
            this.button_return.Margin = new System.Windows.Forms.Padding(4);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(125, 43);
            this.button_return.TabIndex = 9;
            this.button_return.Text = "Вернуться";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_enter
            // 
            this.button_enter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_enter.Location = new System.Drawing.Point(73, 197);
            this.button_enter.Margin = new System.Windows.Forms.Padding(4);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(125, 43);
            this.button_enter.TabIndex = 8;
            this.button_enter.Text = "Ввод";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // textBox_pasword
            // 
            this.textBox_pasword.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox_pasword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.textBox_pasword.Location = new System.Drawing.Point(173, 116);
            this.textBox_pasword.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pasword.Name = "textBox_pasword";
            this.textBox_pasword.PasswordChar = '*';
            this.textBox_pasword.Size = new System.Drawing.Size(201, 30);
            this.textBox_pasword.TabIndex = 7;
            // 
            // label_pasword
            // 
            this.label_pasword.AutoSize = true;
            this.label_pasword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_pasword.Location = new System.Drawing.Point(68, 119);
            this.label_pasword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pasword.Name = "label_pasword";
            this.label_pasword.Size = new System.Drawing.Size(50, 25);
            this.label_pasword.TabIndex = 6;
            this.label_pasword.Text = "Код:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(455, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // EntAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(455, 320);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_pasword);
            this.Controls.Add(this.label_pasword);
            this.MaximumSize = new System.Drawing.Size(455, 320);
            this.MinimumSize = new System.Drawing.Size(455, 320);
            this.Name = "EntAdmin";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "            Вход в режим администратора    ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.TextBox textBox_pasword;
        private System.Windows.Forms.Label label_pasword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}