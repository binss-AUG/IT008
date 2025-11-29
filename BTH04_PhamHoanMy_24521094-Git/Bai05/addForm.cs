using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;


namespace Bai05
{
    public partial class addForm: Form
    {
        DBhelper db = new DBhelper();

        private string[] dsKhoa = {
            "Khoa Công nghệ Phần mềm",
            "Khoa Hệ thống Thông tin",
            "Khoa Khoa học Máy tính",
            "Khoa Mạng Máy tính và Truyền thông",
            "Khoa Kỹ thuật Máy tính",
            "Khoa Công nghệ Thông tin",
            "Khoa An toàn Thông tin",
            "Khoa Thương mại Điện tử",
            "Khoa Khoa học và Kỹ thuật Thông tin",
            "Khoa Truyền thông và Mạng máy tính",
            "Khoa Công nghệ Đa phương tiện"};

        public addForm()
        {
            InitializeComponent();
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(MSSVText.Text) || 
                string.IsNullOrWhiteSpace(TenText.Text) ||
                string.IsNullOrWhiteSpace(DTBText.Text))
            {
                MessageBox.Show("Nhập thiếu thông tin!");
                return;
            }

            if (!MSSVText.Text.All(char.IsDigit))
            {
                MessageBox.Show($"Vui lòng kiểm tra lại Mã Số Sinh Viên");
                return;
            }

            if (!TenText.Text.All(c=> char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show($"Vui lòng kiểm tra lại Tên Sinh Viên");
                return;
            }

            string mssv = MSSVText.Text;
            string ten = TenText.Text;
            string khoa = KhoacomboBox.Text;
            float diem = -1;
            if (!float.TryParse(DTBText.Text, out diem) || diem < 0 || 10 < diem)
            {
                MessageBox.Show("Điểm số chưa hợp lệ! Chú ý sử dụng dấu . với thang điểm 10");
                return;
            }

            string sql = $"insert into SINHVIEN (MSSV, TenSV, Khoa, DiemTB) values ('{mssv}', N'{ten}', N'{khoa}', '{diem}')";

            if (db.exeQuery(sql))
            {
                MessageBox.Show("Đã thêm thành công!");
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addForm_Load(object sender, EventArgs e)
        {
            this.KhoacomboBox.Items.AddRange(dsKhoa);
            this.KhoacomboBox.SelectedIndex = 0;
        }

    }
}
