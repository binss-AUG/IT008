using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1: Form
    {
        private List<Account> accounts;
        private int currentSTT = 1;

        public Form1()
        {
            InitializeComponent();
            accounts = new List<Account>();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            btnAddUpdate.Click += AddUpdateClick;
            btnDelete.Click += DeleteClick;
            btnExit.Click += ExitClick;
            dataGridView1.SelectionChanged += DataGridViewSelectionChanged;
        }

        private void AddUpdateClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNumber.Text) ||
                string.IsNullOrEmpty(txtCustomerName.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtBalance.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string accountNumber = txtAccountNumber.Text;
            string customerName = txtCustomerName.Text;
            string address = txtAddress.Text;
            decimal balance = decimal.Parse(txtBalance.Text);

            int existingIndex = FindAccountIndex(accountNumber);

            if (existingIndex == -1)
            {
                Account newAccount = new Account
                {
                    STT = currentSTT++,
                    AccountNumber = accountNumber,
                    CustomerName = customerName,
                    Address = address,
                    Balance = balance
                };
                accounts.Add(newAccount);
                RefreshDataGridView();
                CalculateTotal();
                ClearInputs();
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            else
            {
                accounts[existingIndex].CustomerName = customerName;
                accounts[existingIndex].Address = address;
                accounts[existingIndex].Balance = balance;
                RefreshDataGridView();
                CalculateTotal();
                ClearInputs();
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Text;

            if (string.IsNullOrEmpty(accountNumber))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản cần xóa!");
                return;
            }

            int existingIndex = FindAccountIndex(accountNumber);

            if (existingIndex == -1)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                accounts.RemoveAt(existingIndex);
                RefreshDataGridView();
                CalculateTotal();
                ClearInputs();
                MessageBox.Show("Xóa tài khoản thành công");
            }
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridViewSelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtAccountNumber.Text = selectedRow.Cells["colAccountCode"].Value.ToString();
                txtCustomerName.Text = selectedRow.Cells["colCustomerName"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["colAddress"].Value.ToString();
                txtBalance.Text = selectedRow.Cells["colBalance"].Value.ToString();
            }
        }

        private int FindAccountIndex(string accountNumber)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].AccountNumber == accountNumber)
                {
                    return i;
                }
            }
            return -1;
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var account in accounts)
            {
                dataGridView1.Rows.Add(account.STT, account.AccountNumber, account.CustomerName, account.Address, account.Balance);
            }
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (var account in accounts)
            {
                total += account.Balance;
            }
            txtTotal.Text = total.ToString();
        }

        private void ClearInputs()
        {
            txtAccountNumber.Clear();
            txtCustomerName.Clear();
            txtAddress.Clear();
            txtBalance.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class Account
    {
        public int STT { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }
    }
}
