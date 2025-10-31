using System.Drawing;
using System.Windows.Forms;

namespace Bai07
{
    partial class Form1
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
            this.SuspendLayout();
            this.btnSeats = new Button[15];
            //
            // Màn ảnh
            //
            this.lblScreen = new Label();
            this.lblScreen.Text = "MÀN ẢNH";
            this.lblScreen.Location = new System.Drawing.Point((this.ClientSize.Width - lblScreen.Width)/2, 20);
            this.lblScreen.Size = new System.Drawing.Size(100, 20);
            this.lblScreen.TextAlign = ContentAlignment.MiddleCenter;
            this.lblScreen.BorderStyle = BorderStyle.FixedSingle;
            //
            // Tạo các ghế
            //
            int seatWidth = 30;
            int seatHeight = 30;
            int spacing = 35;
            int def_x = (this.ClientSize.Width - seatWidth*5 - spacing/2)/2;
            int x = def_x;
            int y = 60;

            for (int i = 0; i < 15; i++)
            {
                this.btnSeats[i] = new Button();
                this.btnSeats[i].Text = (i + 1).ToString();
                this.btnSeats[i].Location = new System.Drawing.Point(x, y);
                this.btnSeats[i].Size = new System.Drawing.Size(seatWidth, seatHeight);
                this.btnSeats[i].BackColor = Color.White;
                this.btnSeats[i].Tag = i;

                x += spacing;
                if ((i + 1) % 5 == 0)
                {
                    x = def_x;
                    y += spacing;
                }
            }
            //
            // Các nút chức năng
            //
            this.btnSelect = new Button();
            this.btnSelect.Text = "Chọn";
            this.btnSelect.Location = new System.Drawing.Point(30, 220);
            this.btnSelect.Size = new System.Drawing.Size(70, 30);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Location = new System.Drawing.Point(110, 220);
            this.btnCancel.Size = new System.Drawing.Size(70, 30);

            this.btnExit = new Button();
            this.btnExit.Text = "Kết thúc";
            this.btnExit.Location = new System.Drawing.Point(190, 220);
            this.btnExit.Size = new System.Drawing.Size(70, 30);
            //
            // Hiển thị tổng tiền
            //
            this.lblTotal = new Label();
            this.lblTotal.Text = "Tổng tiền:";
            this.lblTotal.Location = new System.Drawing.Point(30, 260);
            this.lblTotal.Size = new System.Drawing.Size(80, 20);

            this.txtTotal = new TextBox();
            this.txtTotal.Location = new System.Drawing.Point(110, 260);
            this.txtTotal.Size = new System.Drawing.Size(150, 20);
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Text = "0";
            //
            // Form1
            //
            this.Text = "Rạp chiếu phim";
            this.Size = new System.Drawing.Size(300, 350);
            this.Controls.AddRange(new Control[] {
                this.lblScreen,
                this.btnSelect, this.btnCancel, this.btnExit,
                this.lblTotal, this.txtTotal
            });

            foreach (Button seat in btnSeats)
            {
                this.Controls.Add(seat);
            }

        }

        #endregion
        private Label lblScreen;
        private Button[] btnSeats;
        private Button btnSelect;
        private Button btnCancel;
        private Button btnExit;
        private Label lblTotal;
        private TextBox txtTotal;
    }
}

