using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Media;

namespace RGR.Message
{
    public partial class SelfMessageBox : MaterialForm
    {
        private string connectionWAV;
        public SelfMessageBox()
        {
            InitializeComponent();
        }
        public SelfMessageBox(string text = "Информация",
            string conn = "C:\\Users\\admin\\Desktop\\ИС-31 Марцинкевич Е.С. Георгиева Д.О\\RGR\\RGR\\Resources\\windows-10-error-sound.wav",
            string PicBoxConn = "C:\\Users\\admin\\Desktop\\ИС-31 Марцинкевич Е.С. Георгиева Д.О\\RGR\\RGR\\Images\\icons8-warning-50.png")
        {
            InitializeComponent();
            this.connectionWAV = conn;
            this.label1.Text = text;
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Image = Image.FromFile(PicBoxConn);
            runWAV_sound();
        }

        private void button_okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void runWAV_sound()
        {
            SoundPlayer sndPlayer = new SoundPlayer(connectionWAV);
            sndPlayer.Play();
        }
    }
}
