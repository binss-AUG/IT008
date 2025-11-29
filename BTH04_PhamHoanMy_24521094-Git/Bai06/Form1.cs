using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = folderDialog.SelectedPath;
            }
        }

        private void btnBrowseDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = folderDialog.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource.Text) || !Directory.Exists(txtSource.Text))
            {
                MessageBox.Show("Kiểm tra lại đường dẫn nguồn");
                return;
            }

            if (string.IsNullOrEmpty(txtDestination.Text))
            {
                MessageBox.Show("Kiểm tra lại đường dẫn đích");
                return;
            }

            try
            {
                progressBar1.Value = 0;
                listBoxFiles.Items.Clear();

                string[] files = Directory.GetFiles(txtSource.Text);
                progressBar1.Maximum = files.Length;

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(txtDestination.Text, fileName);

                    listBoxFiles.Items.Add("Đang sao chép: " + fileName);
                    listBoxFiles.SelectedIndex = listBoxFiles.Items.Count - 1;

                    File.Copy(file, destFile, true);

                    progressBar1.Value++;
                    Application.DoEvents();
                }

                MessageBox.Show("File copy completed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}