using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1: Form
    {
        private DateTime now = DateTime.Now;
        private string curPath = null;
        private string defNameApp = "Vjet Music 1.0 beta";
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            updateTime();
        }

        private void updateTime()
        {
            DateTime now = DateTime.Now;
            timeLabel.Text = $"Hôm nay là ngày {now:d} - Bây giờ là {now:T}";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                this.Text = defNameApp + " - " + openFileDialog1.SafeFileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
