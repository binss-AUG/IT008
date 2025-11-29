using System.Drawing;
using System.Windows.Forms;

namespace Bai09
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblMajor = new System.Windows.Forms.Label();
            this.cboMajor = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lstAvailableCourses = new System.Windows.Forms.ListBox();
            this.lstSelectedCourses = new System.Windows.Forms.ListBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(150, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nhập Liệu Sinh Viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblStudentInfo.Location = new System.Drawing.Point(20, 45);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(150, 20);
            this.lblStudentInfo.TabIndex = 1;
            this.lblStudentInfo.Text = "Thông Tin Sinh Viên";
            // 
            // lblStudentID
            // 
            this.lblStudentID.Location = new System.Drawing.Point(40, 75);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(100, 20);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Mã Sinh Viên";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(150, 75);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(200, 22);
            this.txtStudentID.TabIndex = 3;
            // 
            // lblFullName
            // 
            this.lblFullName.Location = new System.Drawing.Point(40, 105);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 20);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Họ Tên";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(150, 105);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.TabIndex = 5;
            // 
            // lblMajor
            // 
            this.lblMajor.Location = new System.Drawing.Point(40, 135);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(100, 20);
            this.lblMajor.TabIndex = 6;
            this.lblMajor.Text = "Chuyên Ngành";
            // 
            // cboMajor
            // 
            this.cboMajor.Items.AddRange(new object[] {
            "Hệ Thống Thông Tin"});
            this.cboMajor.Location = new System.Drawing.Point(150, 135);
            this.cboMajor.Name = "cboMajor";
            this.cboMajor.Size = new System.Drawing.Size(200, 24);
            this.cboMajor.TabIndex = 7;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(40, 165);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(100, 20);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Giới Tính";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Controls.Add(this.radFemale);
            this.grpGender.Location = new System.Drawing.Point(150, 155);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(150, 40);
            this.grpGender.TabIndex = 9;
            this.grpGender.TabStop = false;
            // 
            // radMale
            // 
            this.radMale.Location = new System.Drawing.Point(10, 15);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(50, 20);
            this.radMale.TabIndex = 0;
            this.radMale.Text = "Nam";
            // 
            // radFemale
            // 
            this.radFemale.Location = new System.Drawing.Point(66, 15);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(50, 20);
            this.radFemale.TabIndex = 1;
            this.radFemale.Text = "Nữ";
            // 
            // lblCourses
            // 
            this.lblCourses.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblCourses.Location = new System.Drawing.Point(20, 205);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(200, 20);
            this.lblCourses.TabIndex = 10;
            this.lblCourses.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // lstAvailableCourses
            // 
            this.lstAvailableCourses.ItemHeight = 16;
            this.lstAvailableCourses.Location = new System.Drawing.Point(40, 230);
            this.lstAvailableCourses.Name = "lstAvailableCourses";
            this.lstAvailableCourses.Size = new System.Drawing.Size(120, 84);
            this.lstAvailableCourses.TabIndex = 11;
            // 
            // lstSelectedCourses
            // 
            this.lstSelectedCourses.ItemHeight = 16;
            this.lstSelectedCourses.Location = new System.Drawing.Point(200, 230);
            this.lstSelectedCourses.Name = "lstSelectedCourses";
            this.lstSelectedCourses.Size = new System.Drawing.Size(120, 84);
            this.lstSelectedCourses.TabIndex = 12;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(166, 245);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(28, 25);
            this.btnAddCourse.TabIndex = 13;
            this.btnAddCourse.Text = ">";
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(166, 275);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(28, 25);
            this.btnRemoveCourse.TabIndex = 14;
            this.btnRemoveCourse.Text = "<";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Lưu Thông Tin";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(350, 270);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Xóa Chọn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colFullName,
            this.colMajor,
            this.colGender,
            this.colCourseCount});
            this.dataGridView1.Location = new System.Drawing.Point(20, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Họ Tên";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            // 
            // colMajor
            // 
            this.colMajor.HeaderText = "Chuyên Ngành";
            this.colMajor.MinimumWidth = 6;
            this.colMajor.Name = "colMajor";
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Giới Tính";
            this.colGender.MinimumWidth = 6;
            this.colGender.Name = "colGender";
            // 
            // colCourseCount
            // 
            this.colCourseCount.HeaderText = "Số Môn";
            this.colCourseCount.MinimumWidth = 6;
            this.colCourseCount.Name = "colCourseCount";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStudentInfo);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.cboMajor);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.lstAvailableCourses);
            this.Controls.Add(this.lstSelectedCourses);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.grpGender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private Label lblStudentInfo;
        private Label lblStudentID;
        private Label lblFullName;
        private Label lblMajor;
        private Label lblGender;
        private Label lblCourses;
        private TextBox txtStudentID;
        private TextBox txtFullName;
        private ComboBox cboMajor;
        private RadioButton radMale;
        private RadioButton radFemale;
        private GroupBox grpGender;
        private ListBox lstAvailableCourses;
        private ListBox lstSelectedCourses;
        private Button btnAddCourse;
        private Button btnRemoveCourse;
        private Button btnSave;
        private Button btnClear;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMSSV;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colMajor;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colCourseCount;
    }
}

