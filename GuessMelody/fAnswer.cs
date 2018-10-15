using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace GuessMelody
{
    public partial class fAnswer : Form
    {
        int timeAnswer = 10;
        public fAnswer()
        {
            InitializeComponent();
        }

        private void fAnswer_Load(object sender, EventArgs e)
        {
            timeAnswer = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeAnswer--;
            lblTimeAnswer.Text = timeAnswer.ToString();
            if (timeAnswer == 0)
            {
                timer1.Stop();
                //SoundPlayer sp = new SoundPlayer(@"Resources\Sound_11096.wav");
                //sp.Play();
            }
        }

        private void fAnswer_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void lblShowAnswer_Click(object sender, EventArgs e)
        {
            var mp3File = TagLib.File.Create(Victorina.answer);
            lblShowAnswer.Text = mp3File.Tag.FirstAlbumArtist + " " + mp3File.Tag.Title;
        }
    }
}
