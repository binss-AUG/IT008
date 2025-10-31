using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        private List<Student> students;

        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
            InitializeCourses();
            AttachEventHandlers();
        }

        private void InitializeCourses()
        {
            lstAvailableCourses.Items.AddRange(new string[] {
                "Cơ Sở Dữ Liệu",
                "Cơ Sở DL NC",
                "PTTK Hệ Thống thông tin"
            });
        }

        private void AttachEventHandlers()
        {
            btnSave.Click += SaveClick;
            btnClear.Click += ClearClick;
            btnAddCourse.Click += AddCourseClick;
            btnRemoveCourse.Click += RemoveCourseClick;
            dataGridView1.SelectionChanged += DataGridViewSelectionChanged;
        }

        private bool isMSSV(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (!('0' <= s[i] && s[i] <= '9')) return false;
            }
            return true;
        }

        private bool isFullName(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (!('a' <= s[i] && s[i] <= 'z') && !('A' <= s[i] && s[i] <= 'Z') && s[i] != ' ') return false;
            }
            return true;
        }

        private void AddCourseClick(object sender, EventArgs e)
        {
            if (lstAvailableCourses.SelectedItem != null)
            {
                string selectedCourse = lstAvailableCourses.SelectedItem.ToString();
                lstSelectedCourses.Items.Add(selectedCourse);
                lstAvailableCourses.Items.Remove(selectedCourse);
            }
        }

        private void RemoveCourseClick(object sender, EventArgs e)
        {
            if (lstSelectedCourses.SelectedItem != null)
            {
                string selectedCourse = lstSelectedCourses.SelectedItem.ToString();
                lstAvailableCourses.Items.Add(selectedCourse);
                lstSelectedCourses.Items.Remove(selectedCourse);
            }
        }

        private void SaveClick(object sender, EventArgs e)
        {
            if (!isMSSV(txtStudentID.Text) ||
                !isFullName(txtFullName.Text) ||
                string.IsNullOrEmpty(cboMajor.Text) ||
                (!radMale.Checked && !radFemale.Checked))
            {
                MessageBox.Show("Vui lòng nhập chính xác thông tin!");
                return;
            }

            string studentID = txtStudentID.Text;
            string fullName = txtFullName.Text;
            string major = cboMajor.Text;
            string gender = radMale.Checked ? "Nam" : "Nữ";

            List<string> selectedCourses = new List<string>();
            foreach (var item in lstSelectedCourses.Items)
            {
                selectedCourses.Add(item.ToString());
            }
            int courseCount = selectedCourses.Count;

            int existingIndex = FindStudentIndex(studentID);

            if (existingIndex == -1)
            {
                Student newStudent = new Student
                {
                    StudentID = studentID,
                    FullName = fullName,
                    Major = major,
                    Gender = gender,
                    CourseCount = courseCount,
                    Courses = selectedCourses
                };
                students.Add(newStudent);
                RefreshDataGridView();
                ClearInputs();
                MessageBox.Show("Thêm mới sinh viên thành công!");
            }
            else
            {
                students[existingIndex].FullName = fullName;
                students[existingIndex].Major = major;
                students[existingIndex].Gender = gender;
                students[existingIndex].CourseCount = courseCount;
                students[existingIndex].Courses = selectedCourses;
                RefreshDataGridView();
                ClearInputs();
                MessageBox.Show("Cập nhật sinh viên thành công!");
            }
        }

        private void ClearClick(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void DataGridViewSelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string studentID = selectedRow.Cells["colMSSV"].Value.ToString();

                int studentIndex = FindStudentIndex(studentID);
                if (studentIndex != -1)
                {
                    Student student = students[studentIndex];
                    txtStudentID.Text = student.StudentID;
                    txtFullName.Text = student.FullName;
                    cboMajor.Text = student.Major;

                    if (student.Gender == "Nam")
                        radMale.Checked = true;
                    else
                        radFemale.Checked = true;

                    lstSelectedCourses.Items.Clear();
                    foreach (var course in student.Courses)
                    {
                        lstSelectedCourses.Items.Add(course);
                    }

                    lstAvailableCourses.Items.Clear();
                    InitializeCourses();
                    foreach (var course in student.Courses)
                    {
                        if (lstAvailableCourses.Items.Contains(course))
                        {
                            lstAvailableCourses.Items.Remove(course);
                        }
                    }
                }
            }
        }

        private int FindStudentIndex(string studentID)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentID == studentID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var student in students)
            {
                dataGridView1.Rows.Add(student.StudentID, student.FullName, student.Major, student.Gender, student.CourseCount);
            }
        }

        private void ClearInputs()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            cboMajor.SelectedIndex = -1;
            radMale.Checked = false;
            radFemale.Checked = false;

            foreach (var item in lstSelectedCourses.Items)
            {
                lstAvailableCourses.Items.Add(item);
            }
            lstSelectedCourses.Items.Clear();
        }
    }

    public class Student
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public string Major { get; set; }
        public string Gender { get; set; }
        public int CourseCount { get; set; }
        public List<string> Courses { get; set; }
    }
}