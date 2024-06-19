namespace RGR.Вход.Регистрация
{
    partial class Registration
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
            this.textBox_pasword = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_pasword = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.button_registration = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_pasword
            // 
            this.textBox_pasword.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox_pasword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.textBox_pasword.Location = new System.Drawing.Point(174, 132);
            this.textBox_pasword.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_pasword.Name = "textBox_pasword";
            this.textBox_pasword.PasswordChar = '*';
            this.textBox_pasword.Size = new System.Drawing.Size(201, 30);
            this.textBox_pasword.TabIndex = 7;
            this.textBox_pasword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cheking_result);
            this.textBox_pasword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lock_spacebar);
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox_login.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.textBox_login.Location = new System.Drawing.Point(174, 93);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(201, 30);
            this.textBox_login.TabIndex = 6;
            this.textBox_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.transfer_cursor_enter);
            this.textBox_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lock_spacebar);
            // 
            // label_pasword
            // 
            this.label_pasword.AutoSize = true;
            this.label_pasword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_pasword.Location = new System.Drawing.Point(79, 134);
            this.label_pasword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pasword.Name = "label_pasword";
            this.label_pasword.Size = new System.Drawing.Size(81, 25);
            this.label_pasword.TabIndex = 5;
            this.label_pasword.Text = "Пароль:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_login.Location = new System.Drawing.Point(79, 94);
            this.label_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(71, 25);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "Логин:";
            // 
            // button_registration
            // 
            this.button_registration.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_registration.Location = new System.Drawing.Point(71, 192);
            this.button_registration.Margin = new System.Windows.Forms.Padding(4);
            this.button_registration.Name = "button_registration";
            this.button_registration.Size = new System.Drawing.Size(154, 43);
            this.button_registration.TabIndex = 8;
            this.button_registration.Text = "Регистрация";
            this.button_registration.UseVisualStyleBackColor = true;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_cancel.Location = new System.Drawing.Point(250, 192);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(125, 43);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Вернуться";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 320);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_registration);
            this.Controls.Add(this.textBox_pasword);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_pasword);
            this.Controls.Add(this.label_login);
            this.MaximumSize = new System.Drawing.Size(455, 320);
            this.MinimumSize = new System.Drawing.Size(455, 320);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                             Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pasword;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_pasword;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.Button button_cancel;
    }
}