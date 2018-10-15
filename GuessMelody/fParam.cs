using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessMelody
{
    public partial class fParam : Form
    {
        public fParam()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = cbAllDir.Checked;
            Victorina.gameDuration = Convert.ToInt32(cbGameDuration.Text);
            Victorina.musicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Victorina.randomStart = cbRandomStart.Checked;
            Victorina.WriteParams();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Set();
            Hide();
        }

        private void btnSelFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbAllDir.Checked? SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fbd.SelectedPath;
                lbMusicList.Items.Clear();
                lbMusicList.Items.AddRange(musicList);
                Victorina.list.Clear();
                Victorina.list.AddRange(musicList);
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lbMusicList.Items.Clear();
        }

        private void fParam_Load(object sender, EventArgs e)
        {
            Set();
            lbMusicList.Items.Clear();
            lbMusicList.Items.AddRange(Victorina.list.ToArray());
        }

        void Set()
        {
            cbAllDir.Checked = Victorina.allDirectories;
            cbGameDuration.Text = Victorina.gameDuration.ToString();
            cbMusicDuration.Text = Victorina.musicDuration.ToString();
            cbRandomStart.Checked = Victorina.randomStart;
        }
    }
}
