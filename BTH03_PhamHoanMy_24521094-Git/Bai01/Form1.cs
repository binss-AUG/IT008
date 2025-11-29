using System;
using System.Windows.Forms;
using System.Drawing;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("1. Constructor");
            InitializeComponent();

            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
            this.Activated += Form1_Activited;
            this.Deactivate += Form1_Deactivite;
            this.FormClosing += Form1_Closing;
            this.FormClosed += Form1_Closed;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("2. Load");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("3. Shown");
        }

        private void Form1_Activited(object sender, EventArgs e)
        {
            prind("Activated - Click vào form");
        }

        private void Form1_Deactivite(object sender, EventArgs e)
        {
            prind("Deactivate - Click ra ngoài form");
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("FormClosing - Sắp đóng");

            DialogResult res = MessageBox.Show("Chắc chắn đóng?", "Xác nhận", MessageBoxButtons.OKCancel);

            if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("FormClosed - Đã đóng");
        }

        private void prind(string s)
        {
            textBox1.Text = s;
        }
    }
}