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
        Student detailedStudent = new Student();
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
            
            Course smallCourse = new Course();

            if (txtStudentID.Text.Length >= 1)
            {
                studentID = txtStudentID.Text;
                txtFirstName.Text = detailedStudent.GetFirstName(studentID);
                txtLastName.Text = detailedStudent.GetLastName(studentID);

                if (txtFirstName.Text == "" && txtLastName.Text == "")
                {
                    MessageBox.Show("Student does not exist in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (txtFirstName.Text.Length >= 1 && txtLastName.Text.Length >= 1)
            {
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                txtStudentID.Text = detailedStudent.GetStudentID(firstName, lastName);

                if (txtStudentID.Text == "")
                {
                    MessageBox.Show("Student does not exist in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error finding student. \n\nPlease make sure you have either the student's first name and last named entered correctly, or their student ID number entered correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtStudentID.Text.Length >= 1 && txtFirstName.Text.Length >= 1 && txtLastName.Text.Length >= 1)
            {
                studentID = txtStudentID.Text;

                if (Convert.ToInt32(studentID) >= 1)
                {
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
            else
            {
                MessageBox.Show("Error finding student. \n\nPlease make sure you have the student's information entered correctly.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text.Length >= 1 && txtFirstName.Text.Length >= 1 && txtLastName.Text.Length >= 1 && txtPhoneNumber.Text.Length >= 1 && txtEmail.Text.Length >= 1 
                && txtAddress.Text.Length >= 1)
            {
                detailedStudent.GetStudentID(txtFirstName.Text, txtLastName.Text);

                if (Convert.ToInt32(txtStudentID.Text) >= 1)
                {
                    detailedStudent.UpdateStudent(txtFirstName.Text, txtLastName.Text, dtpDateOfBirth.Value.Date.ToString("yyyy-MM-dd"), txtPhoneNumber.Text,
                        txtEmail.Text, txtAddress.Text, txtStudentID.Text);
                }
                else
                {
                    MessageBox.Show("Error updating student. \n\nPlease make sure you have the student's information entered correctly.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error updating student. \n\nPlease make sure you have the student's information entered correctly.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtCity.Text.Length >= 1 && txtParish.Text.Length >= 1 && txtZipCode.Text.Length >= 1 && txtStudentID.Text.Length >= 1)
            {
                detailedStudent.GetStudentID(txtFirstName.Text, txtLastName.Text);

                if (Convert.ToInt32(txtStudentID.Text) >= 1)
                {
                    detailedStudent.UpdateOrigin(txtCity.Text, txtParish.Text, txtZipCode.Text, txtStudentID.Text);
                    detailedStudent.UpdateAcademics(dtpEnrollDate.Value.Date.ToString("yyyy-MM-dd"), dtpGraduationDate.Value.Date.ToString("yyyy-MM-dd"), txtDegree.Text, txtStudentID.Text);
                }
            }
        }        
    }
}
