namespace Bai05
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ChucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchLabel = new System.Windows.Forms.ToolStripLabel();
            this.SinhVienDataGridView = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ChucNangToolStripMenuItem
            // 
            this.ChucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.ThoatToolStripMenuItem});
            this.ChucNangToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.ChucNangToolStripMenuItem.Name = "ChucNangToolStripMenuItem";
            this.ChucNangToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.ChucNangToolStripMenuItem.Text = "Chức Năng";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addToolStripMenuItem.Text = "Thêm mới ";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // ThoatToolStripMenuItem
            // 
            this.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            this.ThoatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ThoatToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ThoatToolStripMenuItem.Text = "Thoát";
            this.ThoatToolStripMenuItem.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.searchTextBox,
            this.searchLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F);
            this.addButton.Image = global::Bai05.Properties.Resources.add_user;
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(134, 34);
            this.addButton.Text = "Thêm Mới";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchTextBox.AutoSize = false;
            this.searchTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchTextBox.Size = new System.Drawing.Size(370, 37);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(136, 34);
            this.searchLabel.Text = "Tìm Kiếm Theo Tên";
            // 
            // SinhVienDataGridView
            // 
            this.SinhVienDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SinhVienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SinhVienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.MSSV,
            this.TenSV,
            this.Khoa,
            this.DiemTB});
            this.SinhVienDataGridView.Location = new System.Drawing.Point(12, 81);
            this.SinhVienDataGridView.Name = "SinhVienDataGridView";
            this.SinhVienDataGridView.ReadOnly = true;
            this.SinhVienDataGridView.RowHeadersWidth = 51;
            this.SinhVienDataGridView.RowTemplate.Height = 24;
            this.SinhVienDataGridView.Size = new System.Drawing.Size(776, 357);
            this.SinhVienDataGridView.TabIndex = 2;
            // 
            // Index
            // 
            this.Index.HeaderText = "Số TT";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 75;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "Mã Số SV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            this.MSSV.Width = 170;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Tên Sinh Viên";
            this.TenSV.MinimumWidth = 6;
            this.TenSV.Name = "TenSV";
            this.TenSV.ReadOnly = true;
            this.TenSV.Width = 200;
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            this.Khoa.Width = 200;
            // 
            // DiemTB
            // 
            this.DiemTB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.HeaderText = "Điểm TB";
            this.DiemTB.MinimumWidth = 6;
            this.DiemTB.Name = "DiemTB";
            this.DiemTB.ReadOnly = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SinhVienDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quản Lí Sinh Viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SinhVienDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThoatToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripLabel searchLabel;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.DataGridView SinhVienDataGridView;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
    }
}

