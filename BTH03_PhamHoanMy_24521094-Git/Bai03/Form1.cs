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
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            this.BackColor = Color.FromArgb(R, G, B);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            button1.Location = new Point((ClientSize.Width - button1.Width) / 2, 
                                         (ClientSize.Height - button1.Height) / 2);
        }
    }
}
