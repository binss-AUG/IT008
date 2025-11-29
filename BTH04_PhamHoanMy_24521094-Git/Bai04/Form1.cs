using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        private bool isItalic = false;
        private bool isBold = false;
        private bool isUnder = false;
        private Font curFont;
        private float[] sizeList = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        private bool isSave = true;
        private string curPath = "";
        private bool isFirstTime = true;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            setDefaut();
        }

        private void InitializeData()
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                FontToolStripComboBox.Items.Add(font.Name);
            }

            foreach (float size in sizeList)
            {
                SizeToolStripComboBox.Items.Add(size);
            }
        }

        private void DinhDangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                ApplyFont(fontDialog1.Font);
            }
        }

        private void ApplyFont(Font font)
        {
            curFont = font;
            richTextBox1.SelectionFont = curFont;
            //if (richTextBox1.SelectionLength > 0)
            //{
            //    richTextBox1.SelectionFont = curFont;
            //}
            //else
            //{
            //    richTextBox1.Font = curFont;
            //}
            //FontToolStripComboBox.Text = curFont.Name;
            //SizeToolStripComboBox.Text = curFont.Size.ToString();
        }

        private void ApplyFontStyle()
        {
            FontStyle style = FontStyle.Regular;
            if (isBold) style |= FontStyle.Bold;
            if (isItalic) style |= FontStyle.Italic;
            if (isUnder) style |= FontStyle.Underline;

            Font newFont = new Font(curFont.FontFamily, curFont.Size, style);
            ApplyFont(newFont);
        }

        private void setDefaut()
        {
            if (!isSave && !isFirstTime)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu văn bản hiện tại?", "Cảnh báo",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (!SaveFile()) return;
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            isFirstTime = false;
            curFont = new Font("Tahoma", 14);
            isBold = false;
            BoldToolStripButton.BackColor = Color.White;
            isItalic = false;
            ItalicToolStripButton.BackColor = Color.White;
            isUnder = false;
            UnderToolStripButton.BackColor = Color.White;
            richTextBox1.Text = "";
            richTextBox1.Font = curFont;
            FontToolStripComboBox.Text = "Tahoma";
            SizeToolStripComboBox.Text = "14";
            curPath = "";
            isSave = true;
            this.Text = "Soạn thảo văn bản - [Văn bản mới]";
        }

        private void TaoVanBanMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setDefaut();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            setDefaut();
        }

        private void BoldToolStripButton_Click(object sender, EventArgs e)
        {
            isBold = !isBold;
            BoldToolStripButton.BackColor = isBold ? Color.LightGray : Color.White;
            ApplyFontStyle();
        }

        private void ItalicToolStripButton_Click(object sender, EventArgs e)
        {
            isItalic = !isItalic;
            ItalicToolStripButton.BackColor = isItalic ? Color.LightGray : Color.White;
            ApplyFontStyle();
        }

        private void UnderToolStripButton_Click(object sender, EventArgs e)
        {
            isUnder = !isUnder;
            UnderToolStripButton.BackColor = isUnder ? Color.LightGray : Color.White;
            ApplyFontStyle();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isSave = false;
            if (!string.IsNullOrEmpty(curPath))
            {
                this.Text = $"Soạn thảo văn bản - {Path.GetFileName(curPath)} *";
            }
            else
            {
                this.Text = "Soạn thảo văn bản - [Văn bản mới] *";
            }
        }

        private void LuuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFile())
            {
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu văn bản trước khi thoát?", "Cảnh báo",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (!SaveFile()) return;
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            Application.Exit();
        }

        private void MoTapTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu văn bản hiện tại?", "Cảnh báo",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (!SaveFile()) return;
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    curPath = openFileDialog1.FileName;
                    if (Path.GetExtension(curPath).ToLower() == ".rtf")
                    {
                        richTextBox1.LoadFile(curPath);
                    }
                    else
                    {
                        richTextBox1.Text = File.ReadAllText(curPath);
                    }
                    isSave = true;
                    this.Text = $"Soạn thảo văn bản - {Path.GetFileName(curPath)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi mở file: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SaveFile()
        {
            if (string.IsNullOrEmpty(curPath))
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    curPath = saveFileDialog1.FileName;
                }
                else
                {
                    return false;
                }
            }

            try
            {
                if (Path.GetExtension(curPath).ToLower() == ".rtf")
                {
                    richTextBox1.SaveFile(curPath);
                }
                else
                {
                    File.WriteAllText(curPath, richTextBox1.Text);
                }
                isSave = true;
                this.Text = $"Soạn thảo văn bản - {Path.GetFileName(curPath)}";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu file: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FontToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FontToolStripComboBox.SelectedItem != null)
            {
                string fontName = FontToolStripComboBox.SelectedItem.ToString();
                float fontSize = curFont.Size;
                Font newFont = new Font(fontName, fontSize, curFont.Style);
                ApplyFont(newFont);
            }
        }

        private void SizeToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SizeToolStripComboBox.SelectedItem != null)
            {
                float fontSize = float.Parse(SizeToolStripComboBox.SelectedItem.ToString());
                Font newFont = new Font(curFont.FontFamily, fontSize, curFont.Style);
                ApplyFont(newFont);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MoTapTinToolStripMenuItem_Click(sender, e);
        }
    }
}