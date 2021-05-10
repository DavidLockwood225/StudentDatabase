using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementRD
{
    public partial class frmStudentCourses : Form
    {
        Student courseStudent = new Student();
        Course allCourses = new Course();
        DbConnection allCourseConnection = new DbConnection();
        public frmStudentCourses()
        {
            InitializeComponent();
        }

        private void btnSearchForCourses_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text.Length >= 3 && txtStudentID.Text.Length <= 6)
            {
                bool idCheck = courseStudent.CheckStudentID(txtStudentID.Text);

                if (idCheck == true)
                {
                    lblFirstName.Text = courseStudent.GetFirstName(txtStudentID.Text);
                    lblLastName.Text = courseStudent.GetLastName(txtStudentID.Text);
                    grdAllCourses.DataSource = allCourses.GetAllCourses(txtStudentID.Text);
                    grdAllCourses.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                else
                {
                    MessageBox.Show("Student ID does not exist in the database. \n\nPlease make sure you have the student ID entered correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unable to find student's courses. \n\nPlease make sure you have the student ID entered correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit this form?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to clear the form?", "Confirm Clear", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                txtStudentID.Text = "";
                lblFirstName.Text = "";
                lblLastName.Text = "";
                grdAllCourses.Columns.Clear();
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            grdAllCourses.DataSource = allCourseConnection.ShowDataInGridView("SELECT * FROM Course ORDER BY CourseID");
            grdAllCourses.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnAddNewCourse_Click(object sender, EventArgs e)
        {
            frmAddNewCourse addNewCourse = new frmAddNewCourse();
            addNewCourse.ShowDialog();
        }
    }
}
