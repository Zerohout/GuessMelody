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
using System.IO;
using TagLib;

namespace GuessMelody
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int musicDuration = Victorina.musicDuration;
        bool[] players = new bool[2];


        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Victorina.list.Count == 0)
            {
                EndGame();
            }
            else
            {
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.list.Count);
                wmp.URL = Victorina.list[n];
                Victorina.answer = wmp.URL;
                wmp.Ctlcontrols.play();
                Victorina.list.RemoveAt(n);
                lblMusicCounter.Text = Victorina.list.Count.ToString();
                players[0] = false;
                players[1] = false;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmp.Ctlcontrols.stop();
            timer1.Stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblMusicCounter.BackColor = Color.Empty;
            lblMusicCounter.Text = Victorina.list.Count.ToString();
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Maximum = Victorina.gameDuration;
            lblMusicDuration.Text = musicDuration.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            lblMusicDuration.Text = musicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (musicDuration == 0)
            {
                MakeMusic();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        void GamePause()
        {
            timer1.Stop();
            wmp.Ctlcontrols.pause();
        }

        void GamePlay()
        {
            timer1.Start();
            wmp.Ctlcontrols.play();
        }

        void EndGame()
        {
            timer1.Stop();
            wmp.Ctlcontrols.stop();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) return;
            if (players[0] == false && e.KeyData == Keys.A)
            {
                GamePause();
                fAnswer fa = new fAnswer();
                fa.lblAnswer.Text = "Игрок 1";
                //SoundPlayer sp = new SoundPlayer(@"Resources\1.wav");
                //sp.PlaySync();
                players[0] = true;
                if (fa.ShowDialog() == DialogResult.Yes)
                {
                    lblCounter1.Text = Convert.ToString(Convert.ToUInt32(lblCounter1.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
            if (players[1] == false && e.KeyData == Keys.P)
            {
                GamePause();
                fAnswer fa = new fAnswer();
                fa.lblAnswer.Text = "Игрок 2";
                //SoundPlayer sp = new SoundPlayer(@"Resources\2.wav");
                //sp.PlaySync();
                players[1] = true;
                if (fa.ShowDialog() == DialogResult.Yes)
                {
                    lblCounter2.Text = Convert.ToString(Convert.ToUInt32(lblCounter2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void wmp_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
            {
                if (wmp.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    wmp.Ctlcontrols.currentPosition = rnd.Next(0, (int)wmp.currentMedia.duration / 2);
                }
            }
        }

        private void lblCounter1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) (sender as Label).Text = Convert.ToString(Convert.ToUInt32((sender as Label).Text) + 1);
            if (e.Button == MouseButtons.Right) (sender as Label).Text = Convert.ToString(Convert.ToUInt32((sender as Label).Text) - 1);
        }
    }
}
