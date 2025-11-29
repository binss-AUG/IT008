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

namespace Bai05
{
    public partial class Form1: Form
    {
        DBhelper db = new DBhelper();
        public Form1()
        {
            InitializeComponent();
            loadTable();
        }
        
        private void loadTable(string searchkey = "")
        {
            string sql = "";

            if (searchkey == "")
            {
                sql = "select * from SinhVien";
            }
            else
            {
                sql = $"select * from SinhVien where MSSV like '%{searchkey}%' or TenSV like N'%{searchkey}%' or Khoa like N'%{searchkey}%'";
            }

            SinhVienDataGridView.DataSource = db.getTable(sql);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            call_addForm();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            call_addForm();
            
        }

        private void call_addForm()
        {
            addForm addform = new addForm();
            addform.ShowDialog();
            loadTable();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            loadTable(searchTextBox.Text);
        }
    }
}
