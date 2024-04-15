namespace RGR.Message
{
    partial class SelfMessageBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_okay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(175, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 153);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_okay
            // 
            this.button_okay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_okay.Location = new System.Drawing.Point(205, 323);
            this.button_okay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_okay.Name = "button_okay";
            this.button_okay.Size = new System.Drawing.Size(105, 34);
            this.button_okay.TabIndex = 7;
            this.button_okay.Text = "Ок";
            this.button_okay.UseVisualStyleBackColor = true;
            this.button_okay.Click += new System.EventHandler(this.button_okay_Click);
            // 
            // ErrorMessage_LoginPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 370);
            this.ControlBox = false;
            this.Controls.Add(this.button_okay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 370);
            this.MinimumSize = new System.Drawing.Size(500, 370);
            this.Name = "ErrorMessage_LoginPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                               Внимание!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_okay;
    }
}