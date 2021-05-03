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
    public partial class frmStudentProfile : Form
    {
        public frmStudentProfile()
        {
            InitializeComponent();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            string firstName;
            string lastName;
            string studentID;
            string gpa;

            Student detailedStudent = new Student();
            Course smallCourse = new Course();
            
                if (txtStudentID.Text.Length >= 1)
                {
                    studentID = txtStudentID.Text;
                    txtFirstName.Text = detailedStudent.GetFirstName(studentID);
                    txtLastName.Text = detailedStudent.GetLastName(studentID);
                }
                else if (txtFirstName.Text.Length >= 1 && txtLastName.Text.Length >= 1)
                {
                    firstName = txtFirstName.Text;
                    lastName = txtLastName.Text;
                    txtStudentID.Text = detailedStudent.GetStudentID(firstName, lastName);
                }
                else
                {
                    MessageBox.Show("Error finding student. \n\nPlease make sure you have either the student's first name and last named entered correctly, or their student ID number entered correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            studentID = txtStudentID.Text;
            txtPhoneNumber.Text = detailedStudent.GetPhoneNumber(studentID);
            txtEmail.Text = detailedStudent.GetEmail(studentID);
            dtpDateOfBirth.Value = Convert.ToDateTime(detailedStudent.GetDateOfBirth(studentID));
            txtAddress.Text = detailedStudent.GetAddress(studentID);
            txtCity.Text = detailedStudent.GetCity(studentID);
            txtParish.Text = detailedStudent.GetParish(studentID);
            txtZipCode.Text = detailedStudent.GetZipCode(studentID);
            dtpEnrollDate.Value = Convert.ToDateTime(detailedStudent.GetEnrollDate(studentID));
            dtpGraduationDate.Value = Convert.ToDateTime(detailedStudent.GetGradDate(studentID));
            txtDegree.Text = detailedStudent.GetDegree(studentID);
            lblDepartment.Text = detailedStudent.GetDepartment(studentID);
            lblDepartmentHead.Text = detailedStudent.GetDepartmentHead(lblDepartment.Text);
            lblTerm.Text = smallCourse.GetTerm(studentID).ToString();
            txtDegree.Text = detailedStudent.GetDegree(studentID);
            if (lblTerm.Text == "1" || lblTerm.Text == "0")
            {
                lblGPA.Text = "N/A";
            }
            else
            {

                lblGPA.Text = detailedStudent.GetGPA(studentID).ToString("0.00");
            }
        }
    }
}
