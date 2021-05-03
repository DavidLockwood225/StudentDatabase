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
    public partial class frmBasicStudentInfo : Form
    {
        public frmBasicStudentInfo()
        {
            InitializeComponent();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {           
            string firstName;
            string lastName;
            string studentID;

            Student basicStudent = new Student();
            Course presentCourses = new Course();

            try
            {
                if (txtBasicStudentID.Text.Length >= 1)
                {
                    studentID = txtBasicStudentID.Text;
                    txtBasicFirstName.Text = basicStudent.GetFirstName(studentID);
                    txtBasicLastName_.Text = basicStudent.GetLastName(studentID);
                    try
                    {
                        grdCurrentClasses.DataSource = presentCourses.GetCurrentCourses(studentID);
                        grdCurrentClasses.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        lblTerm.Text = presentCourses.GetTerm(studentID).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Error finding student's current courses. \n\nPlease make sure they are currently registered for class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    lblDegree_.Text = basicStudent.GetDegree(studentID);
                }
                else if (txtBasicFirstName.Text.Length >= 1 && txtBasicLastName_.Text.Length >= 1)
                {
                    firstName = txtBasicFirstName.Text;
                    lastName = txtBasicLastName_.Text;
                    txtBasicStudentID.Text = basicStudent.GetStudentID(firstName, lastName);
                    studentID = txtBasicStudentID.Text;
                    grdCurrentClasses.DataSource = presentCourses.GetCurrentCourses(studentID);
                    grdCurrentClasses.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    lblTerm.Text = presentCourses.GetTerm(studentID).ToString();
                    lblDegree_.Text = basicStudent.GetDegree(studentID);
                }
                else
                {
                    MessageBox.Show("Error finding student. \n\nPlease make sure you have either the student's first name and last named entered correctly, or their student ID number entered correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                
            }
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            frmAddNewStudent addNewStudent = new frmAddNewStudent();
            addNewStudent.ShowDialog();
        }

        private void btnDetailedStudentInfo_Click(object sender, EventArgs e)
        {
            frmStudentProfile studentProfile = new frmStudentProfile();
            studentProfile.ShowDialog();
        }
    }
}
