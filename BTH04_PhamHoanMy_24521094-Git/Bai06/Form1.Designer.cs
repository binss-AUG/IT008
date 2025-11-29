using System.ComponentModel;
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnBrowseDest = new System.Windows.Forms.Button();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sao chép tập tin";

            this.groupBox1.Location = new System.Drawing.Point(16, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 3);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đường Dẫn Thư Mục Nguồn";

            this.txtSource.Location = new System.Drawing.Point(19, 71);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(280, 20);
            this.txtSource.TabIndex = 3;

            this.btnBrowseSource.Location = new System.Drawing.Point(305, 69);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 4;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đường Dẫn Thư Mục Đích";

            this.txtDestination.Location = new System.Drawing.Point(19, 120);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(280, 20);
            this.txtDestination.TabIndex = 6;

            this.btnBrowseDest.Location = new System.Drawing.Point(305, 118);
            this.btnBrowseDest.Name = "btnBrowseDest";
            this.btnBrowseDest.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDest.TabIndex = 7;
            this.btnBrowseDest.Text = "Browse";
            this.btnBrowseDest.UseVisualStyleBackColor = true;
            this.btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);

            this.btnCopy.Location = new System.Drawing.Point(19, 156);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(361, 30);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Sao Chép";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);

            this.groupBox2.Location = new System.Drawing.Point(16, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 3);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tiến trình sao chép";

            this.progressBar1.Location = new System.Drawing.Point(19, 225);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(361, 23);
            this.progressBar1.TabIndex = 11;

            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(19, 254);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(361, 95);
            this.listBoxFiles.TabIndex = 12;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnBrowseDest);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sao chép tập tin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private TextBox txtSource;
        private TextBox txtDestination;
        private Button btnBrowseSource;
        private Button btnBrowseDest;
        private Button btnCopy;
        private GroupBox groupBox2;
        private Label label4;
        private ListBox listBoxFiles;
        private ProgressBar progressBar1;
    }
}

