using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1: Form
    {
        private bool[] soldSeats = new bool[15];
        private bool[] selectedSeats = new bool[15];
        private int[] seatPrices = new int[15];

        public Form1()
        {
            InitializeComponent();
            SetSeatPrices();
            SetEventHandlers();
        }

        private void SetSeatPrices()
        {
            for (int i = 0; i < 15; i++)
            {
                if (i < 5) seatPrices[i] = 8000;    
                else if (i < 10) seatPrices[i] = 6500; 
                else seatPrices[i] = 5000;          
            }
        }

        private void SetEventHandlers()
        {
            for (int i = 0; i < 15; i++)
            {
                btnSeats[i].Click += SeatClick;
            }

            btnSelect.Click += SelectClick;
            btnCancel.Click += CancelClick;
            btnExit.Click += ExitClick;
        }

        private void SeatClick(object sender, EventArgs e)
        {
            Button seat = (Button)sender;
            int seatIndex = (int)seat.Tag;

            if (soldSeats[seatIndex])
            {
                MessageBox.Show($"Vé ở vị trí {seatIndex + 1} đã được bán!");
                return;
            }

            if (selectedSeats[seatIndex])
            {
                seat.BackColor = Color.White;
                selectedSeats[seatIndex] = false;
            }
            else
            {
                seat.BackColor = Color.Blue;
                selectedSeats[seatIndex] = true;
            }
        }

        private void SelectClick(object sender, EventArgs e)
        {
            int total = 0;

            for (int i = 0; i < 15; i++)
            {
                if (selectedSeats[i])
                {
                    btnSeats[i].BackColor = Color.Yellow;
                    soldSeats[i] = true;
                    selectedSeats[i] = false;
                    total += seatPrices[i];
                }
            }

            txtTotal.Text = total.ToString();
        }

        private void CancelClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                if (selectedSeats[i])
                {
                    btnSeats[i].BackColor = Color.White;
                    selectedSeats[i] = false;
                }
            }

            txtTotal.Text = "0";
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
