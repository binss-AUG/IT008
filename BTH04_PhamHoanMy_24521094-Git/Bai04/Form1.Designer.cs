using System.Drawing;
using System.Reflection;

namespace Bai04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaoVanBanMoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoTapTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LuuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DinhDangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FontToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.SizeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.BoldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThongToolStripMenuItem,
            this.DinhDangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HeThongToolStripMenuItem
            // 
            this.HeThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaoVanBanMoiToolStripMenuItem,
            this.MoTapTinToolStripMenuItem,
            this.toolStripSeparator1,
            this.LuuToolStripMenuItem,
            this.ThoatToolStripMenuItem});
            this.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem";
            this.HeThongToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.HeThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // TaoVanBanMoiToolStripMenuItem
            // 
            this.TaoVanBanMoiToolStripMenuItem.Image = global::Bai04.Properties.Resources.new_file__1_;
            this.TaoVanBanMoiToolStripMenuItem.Name = "TaoVanBanMoiToolStripMenuItem";
            this.TaoVanBanMoiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TaoVanBanMoiToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.TaoVanBanMoiToolStripMenuItem.Text = "Tạo văn bản mới";
            this.TaoVanBanMoiToolStripMenuItem.Click += new System.EventHandler(this.TaoVanBanMoiToolStripMenuItem_Click);
            // 
            // MoTapTinToolStripMenuItem
            // 
            this.MoTapTinToolStripMenuItem.Image = global::Bai04.Properties.Resources.open_document;
            this.MoTapTinToolStripMenuItem.Name = "MoTapTinToolStripMenuItem";
            this.MoTapTinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MoTapTinToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.MoTapTinToolStripMenuItem.Text = "Mở tập tin";
            this.MoTapTinToolStripMenuItem.Click += new System.EventHandler(this.MoTapTinToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(282, 6);
            // 
            // LuuToolStripMenuItem
            // 
            this.LuuToolStripMenuItem.Image = global::Bai04.Properties.Resources.save_file;
            this.LuuToolStripMenuItem.Name = "LuuToolStripMenuItem";
            this.LuuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.LuuToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.LuuToolStripMenuItem.Text = "Lưu nội dung văn bản";
            this.LuuToolStripMenuItem.Click += new System.EventHandler(this.LuuToolStripMenuItem_Click);
            // 
            // ThoatToolStripMenuItem
            // 
            this.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            this.ThoatToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.ThoatToolStripMenuItem.Text = "Thoát";
            this.ThoatToolStripMenuItem.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);
            // 
            // DinhDangToolStripMenuItem
            // 
            this.DinhDangToolStripMenuItem.Name = "DinhDangToolStripMenuItem";
            this.DinhDangToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.DinhDangToolStripMenuItem.Text = "Định dạng";
            this.DinhDangToolStripMenuItem.Click += new System.EventHandler(this.DinhDangToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.FontToolStripComboBox,
            this.SizeToolStripComboBox,
            this.BoldToolStripButton,
            this.ItalicToolStripButton,
            this.UnderToolStripButton,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Bai04.Properties.Resources.new_file__1_;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // FontToolStripComboBox
            // 
            this.FontToolStripComboBox.Name = "FontToolStripComboBox";
            this.FontToolStripComboBox.Size = new System.Drawing.Size(121, 28);
            this.FontToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.FontToolStripComboBox_SelectedIndexChanged);
            // 
            // SizeToolStripComboBox
            // 
            this.SizeToolStripComboBox.Name = "SizeToolStripComboBox";
            this.SizeToolStripComboBox.Size = new System.Drawing.Size(121, 28);
            this.SizeToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.SizeToolStripComboBox_SelectedIndexChanged);
            // 
            // BoldToolStripButton
            // 
            this.BoldToolStripButton.BackColor = System.Drawing.Color.White;
            this.BoldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BoldToolStripButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoldToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldToolStripButton.Image")));
            this.BoldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldToolStripButton.Name = "BoldToolStripButton";
            this.BoldToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.BoldToolStripButton.Text = "B";
            this.BoldToolStripButton.Click += new System.EventHandler(this.BoldToolStripButton_Click);
            // 
            // ItalicToolStripButton
            // 
            this.ItalicToolStripButton.BackColor = System.Drawing.Color.White;
            this.ItalicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ItalicToolStripButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItalicToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicToolStripButton.Image")));
            this.ItalicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicToolStripButton.Name = "ItalicToolStripButton";
            this.ItalicToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.ItalicToolStripButton.Text = "I";
            this.ItalicToolStripButton.Click += new System.EventHandler(this.ItalicToolStripButton_Click);
            // 
            // UnderToolStripButton
            // 
            this.UnderToolStripButton.BackColor = System.Drawing.Color.White;
            this.UnderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UnderToolStripButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderToolStripButton.Image")));
            this.UnderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderToolStripButton.Name = "UnderToolStripButton";
            this.UnderToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.UnderToolStripButton.Text = "U";
            this.UnderToolStripButton.Click += new System.EventHandler(this.UnderToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.ShowColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = " |*.txt| |*.rtf";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = " |*.rtf";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(798, 364);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DinhDangToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox FontToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox SizeToolStripComboBox;
        private System.Windows.Forms.ToolStripButton BoldToolStripButton;
        private System.Windows.Forms.ToolStripButton ItalicToolStripButton;
        private System.Windows.Forms.ToolStripButton UnderToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem TaoVanBanMoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoTapTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LuuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThoatToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

