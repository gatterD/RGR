namespace RGR
{
    partial class Autorisation
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
            this.label_login = new System.Windows.Forms.Label();
            this.label_pasword = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_pasword = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(66, 110);
            this.label_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(70, 20);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Логин:";
            // 
            // label_pasword
            // 
            this.label_pasword.AutoSize = true;
            this.label_pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pasword.Location = new System.Drawing.Point(66, 150);
            this.label_pasword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pasword.Name = "label_pasword";
            this.label_pasword.Size = new System.Drawing.Size(84, 20);
            this.label_pasword.TabIndex = 1;
            this.label_pasword.Text = "Пароль:";
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(161, 109);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(201, 26);
            this.textBox_login.TabIndex = 2;
            this.textBox_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.transfer_cursor_enter);
            // 
            // textBox_pasword
            // 
            this.textBox_pasword.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox_pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pasword.Location = new System.Drawing.Point(161, 148);
            this.textBox_pasword.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pasword.Name = "textBox_pasword";
            this.textBox_pasword.PasswordChar = '*';
            this.textBox_pasword.Size = new System.Drawing.Size(201, 26);
            this.textBox_pasword.TabIndex = 3;
            this.textBox_pasword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cheking_result);
            // 
            // button_enter
            // 
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter.Location = new System.Drawing.Point(70, 195);
            this.button_enter.Margin = new System.Windows.Forms.Padding(4);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(125, 43);
            this.button_enter.TabIndex = 4;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(317, 264);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(125, 43);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Выход";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_registration
            // 
            this.button_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_registration.Location = new System.Drawing.Point(215, 195);
            this.button_registration.Margin = new System.Windows.Forms.Padding(4);
            this.button_registration.Name = "button_registration";
            this.button_registration.Size = new System.Drawing.Size(147, 43);
            this.button_registration.TabIndex = 6;
            this.button_registration.Text = "Регистрация";
            this.button_registration.UseVisualStyleBackColor = true;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // Autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 320);
            this.ControlBox = false;
            this.Controls.Add(this.button_registration);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_pasword);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_pasword);
            this.Controls.Add(this.label_login);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(455, 320);
            this.MinimumSize = new System.Drawing.Size(455, 320);
            this.Name = "Autorisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                          Авторизация";
            this.Load += new System.EventHandler(this.Enter_administrator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_pasword;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_pasword;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_registration;
    }
}