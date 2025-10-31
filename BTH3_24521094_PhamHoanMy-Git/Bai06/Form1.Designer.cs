using System.Windows.Forms;

namespace Bai06
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(10, 30);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(260, 22);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0.";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(10, 60);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(85, 30);
            this.btnBackspace.TabIndex = 1;
            this.btnBackspace.Text = "Backspace";
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(100, 60);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(40, 30);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(145, 60);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(40, 30);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(10, 95);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(40, 30);
            this.btnMC.TabIndex = 4;
            this.btnMC.Text = "MC";
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(55, 95);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 30);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(100, 95);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 30);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(145, 95);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 30);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(190, 95);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(40, 30);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(235, 95);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(40, 30);
            this.btnSqrt.TabIndex = 9;
            this.btnSqrt.Text = "sqrt";
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(10, 130);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(40, 30);
            this.btnMR.TabIndex = 10;
            this.btnMR.Text = "MR";
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(55, 130);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 30);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(100, 130);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 30);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(145, 130);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 30);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(190, 130);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(40, 30);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "*";
            // 
            // btnPercent
            // 
            this.btnPercent.Location = new System.Drawing.Point(235, 130);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(40, 30);
            this.btnPercent.TabIndex = 15;
            this.btnPercent.Text = "%";
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(10, 165);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(40, 30);
            this.btnMS.TabIndex = 16;
            this.btnMS.Text = "MS";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(55, 165);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 30);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(100, 165);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 30);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(145, 165);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 30);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(190, 165);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(40, 30);
            this.btnSubtract.TabIndex = 20;
            this.btnSubtract.Text = "-";
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Location = new System.Drawing.Point(235, 165);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(40, 30);
            this.btnReciprocal.TabIndex = 21;
            this.btnReciprocal.Text = "1/x";
            // 
            // btnMPlus
            // 
            this.btnMPlus.Location = new System.Drawing.Point(10, 200);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(40, 30);
            this.btnMPlus.TabIndex = 22;
            this.btnMPlus.Text = "M+";
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(55, 200);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 30);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(100, 200);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(40, 30);
            this.btnSign.TabIndex = 24;
            this.btnSign.Text = "+/-";
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(145, 200);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(40, 30);
            this.btnDecimal.TabIndex = 25;
            this.btnDecimal.Text = ".";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(190, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 30);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "+";
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(235, 200);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(40, 30);
            this.btnEquals.TabIndex = 27;
            this.btnEquals.Text = "=";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(279, 235);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEquals);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDisplay;
        private Button btnBackspace, btnCE, btnC, btnMC, btnMR, btnMS, btnMPlus;
        private Button btn7, btn8, btn9, btnDivide, btnSqrt;
        private Button btn4, btn5, btn6, btnMultiply, btnPercent;
        private Button btn1, btn2, btn3, btnSubtract, btnReciprocal;
        private Button btn0, btnSign, btnDecimal, btnAdd, btnEquals;
    }
}

