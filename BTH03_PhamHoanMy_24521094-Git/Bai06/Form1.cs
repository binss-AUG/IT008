using System.Drawing;
using System.Windows.Forms;

namespace Bai09
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblStudentInfo;
        private Label lblStudentID;
        private Label lblFullName;
        private Label lblMajor;
        private Label lblGender;
        private Label lblSubjects;
        private TextBox txtStudentID;
        private TextBox txtFullName;
        private ComboBox cboMajor;
        private RadioButton radMale;
        private RadioButton radFemale;
        private GroupBox grpGender;
        private CheckBox chkDatabase;
        private CheckBox chkDatabaseResearch;
        private CheckBox chkSystemAnalysis;
        private Button btnSave;
        private Button btnClear;
        private DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Tiêu đề chính
            this.lblTitle = new Label();
            this.lblTitle.Text = "Nhập Liệu Sinh Viên";
            this.lblTitle.Location = new System.Drawing.Point(150, 10);
            this.lblTitle.Size = new System.Drawing.Size(200, 25);
            this.lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Thông tin sinh viên
            this.lblStudentInfo = new Label();
            this.lblStudentInfo.Text = "Thông Tin Sinh Viên";
            this.lblStudentInfo.Location = new System.Drawing.Point(20, 45);
            this.lblStudentInfo.Size = new System.Drawing.Size(150, 20);
            this.lblStudentInfo.Font = new Font("Arial", 9, FontStyle.Bold);

            // Mã sinh viên
            this.lblStudentID = new Label();
            this.lblStudentID.Text = "Mã Sinh Viên";
            this.lblStudentID.Location = new System.Drawing.Point(40, 75);
            this.lblStudentID.Size = new System.Drawing.Size(100, 20);

            this.txtStudentID = new TextBox();
            this.txtStudentID.Location = new System.Drawing.Point(150, 75);
            this.txtStudentID.Size = new System.Drawing.Size(150, 20);

            // Họ tên
            this.lblFullName = new Label();
            this.lblFullName.Text = "Họ Tên";
            this.lblFullName.Location = new System.Drawing.Point(40, 105);
            this.lblFullName.Size = new System.Drawing.Size(100, 20);

            this.txtFullName = new TextBox();
            this.txtFullName.Location = new System.Drawing.Point(150, 105);
            this.txtFullName.Size = new System.Drawing.Size(200, 20);

            // Chuyên ngành
            this.lblMajor = new Label();
            this.lblMajor.Text = "Chuyên Ngành";
            this.lblMajor.Location = new System.Drawing.Point(40, 135);
            this.lblMajor.Size = new System.Drawing.Size(100, 20);

            this.cboMajor = new ComboBox();
            this.cboMajor.Location = new System.Drawing.Point(150, 135);
            this.cboMajor.Size = new System.Drawing.Size(150, 20);
            this.cboMajor.Items.AddRange(new object[] { "Công nghệ thông tin", "Kỹ thuật phần mềm", "Khoa học máy tính", "Mạng máy tính" });

            // Giới tính
            this.lblGender = new Label();
            this.lblGender.Text = "Giới Tính";
            this.lblGender.Location = new System.Drawing.Point(40, 165);
            this.lblGender.Size = new System.Drawing.Size(100, 20);

            this.grpGender = new GroupBox();
            this.grpGender.Location = new System.Drawing.Point(150, 155);
            this.grpGender.Size = new System.Drawing.Size(200, 40);
            this.grpGender.Text = "";

            this.radMale = new RadioButton();
            this.radMale.Text = "Nam";
            this.radMale.Location = new System.Drawing.Point(10, 15);
            this.radMale.Size = new System.Drawing.Size(50, 20);
            this.radMale.Checked = true;

            this.radFemale = new RadioButton();
            this.radFemale.Text = "Nữ";
            this.radFemale.Location = new System.Drawing.Point(70, 15);
            this.radFemale.Size = new System.Drawing.Size(50, 20);

            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Controls.Add(this.radFemale);

            // Môn học
            this.lblSubjects = new Label();
            this.lblSubjects.Text = "Chọn Các Môn Học Tham Gia";
            this.lblSubjects.Location = new System.Drawing.Point(20, 205);
            this.lblSubjects.Size = new System.Drawing.Size(180, 20);
            this.lblSubjects.Font = new Font("Arial", 9, FontStyle.Bold);

            this.chkDatabase = new CheckBox();
            this.chkDatabase.Text = "Cơ Sở Dữ Liệu";
            this.chkDatabase.Location = new System.Drawing.Point(40, 230);
            this.chkDatabase.Size = new System.Drawing.Size(120, 20);

            this.chkDatabaseResearch = new CheckBox();
            this.chkDatabaseResearch.Text = "Cơ Sở DL NC";
            this.chkDatabaseResearch.Location = new System.Drawing.Point(40, 255);
            this.chkDatabaseResearch.Size = new System.Drawing.Size(120, 20);

            this.chkSystemAnalysis = new CheckBox();
            this.chkSystemAnalysis.Text = "PTTK Hệ Thống thông tin";
            this.chkSystemAnalysis.Location = new System.Drawing.Point(40, 280);
            this.chkSystemAnalysis.Size = new System.Drawing.Size(180, 20);

            // Nút chức năng
            this.btnSave = new Button();
            this.btnSave.Text = "Lưu Thông Tin";
            this.btnSave.Location = new System.Drawing.Point(250, 230);
            this.btnSave.Size = new System.Drawing.Size(100, 30);

            this.btnClear = new Button();
            this.btnClear.Text = "Xóa Chọn";
            this.btnClear.Location = new System.Drawing.Point(250, 270);
            this.btnClear.Size = new System.Drawing.Size(100, 30);

            // DataGridView
            this.dataGridView1 = new DataGridView();
            this.dataGridView1.Location = new System.Drawing.Point(20, 320);
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tạo columns cho DataGridView
            DataGridViewTextBoxColumn colMSSV = new DataGridViewTextBoxColumn();
            colMSSV.HeaderText = "MSSV";
            colMSSV.Name = "colMSSV";

            DataGridViewTextBoxColumn colFullName = new DataGridViewTextBoxColumn();
            colFullName.HeaderText = "Họ Tên";
            colFullName.Name = "colFullName";

            DataGridViewTextBoxColumn colMajor = new DataGridViewTextBoxColumn();
            colMajor.HeaderText = "Chuyên Ngành";
            colMajor.Name = "colMajor";

            DataGridViewTextBoxColumn colGender = new DataGridViewTextBoxColumn();
            colGender.HeaderText = "Giới Tính";
            colGender.Name = "colGender";

            DataGridViewTextBoxColumn colSubjectCount = new DataGridViewTextBoxColumn();
            colSubjectCount.HeaderText = "Số Môn";
            colSubjectCount.Name = "colSubjectCount";

            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                colMSSV, colFullName, colMajor, colGender, colSubjectCount
            });

            // Form
            this.Text = "Quản lý sinh viên";
            this.Size = new System.Drawing.Size(550, 500);
            this.Controls.AddRange(new Control[] {
                this.lblTitle,
                this.lblStudentInfo,
                this.lblStudentID, this.txtStudentID,
                this.lblFullName, this.txtFullName,
                this.lblMajor, this.cboMajor,
                this.lblGender, this.grpGender,
                this.lblSubjects,
                this.chkDatabase, this.chkDatabaseResearch, this.chkSystemAnalysis,
                this.btnSave, this.btnClear,
                this.dataGridView1
            });
        }
    }
}