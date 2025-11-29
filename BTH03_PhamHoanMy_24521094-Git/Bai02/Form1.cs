using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1: Form
    {
        private Point startPoint;
        private Point endPoint;
        private bool isDraw = false;
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            
            int x = rand.Next(100, this.Width) - 100;
            int y = rand.Next(100, this.Height) - 100;
            using (Brush brush = new SolidBrush(Color.Black))
            using (Font font = new Font("Cosolas", 13))
            {
                g.DrawString("Paint Event", font, brush, x, y);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Invalidate();
        }
    }
}
