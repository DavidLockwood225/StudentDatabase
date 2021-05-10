using System;
using System.Windows.Forms;

namespace StudentManagementRD
{
    public partial class frmStudentProfile : Form
    {
        Student detailedStudent = new Student();
        Academics academicInfo = new Academics();
        Origin originInfo = new Origin();
        Course smallCourse = new Course();
        Department departmentInfo = new Department();
        Grades detailedGrades = new Grades();
        public frmStudentProfile()
        {
            InitializeComponent();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            string studentID;

            if (txtStudentID.Text.Length >= 3 && txtStudentID.Text.Length <= 6)
            {
                studentID = txtStudentID.Text;
                txtFirstName.Text = detailedStudent.GetFirstName(studentID);
                txtLastName.Text = detailedStudent.GetLastName(studentID);

                if (txtFirstName.Text == "" && txtLastName.Text == "")
                {
                    MessageBox.Show("Student does not exist in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtPhoneNumber.Text = detailedStudent.GetPhoneNumber(studentID);
                txtEmail.Text = detailedStudent.GetEmail(studentID);
                dtpDateOfBirth.Value = Convert.ToDateTime(detailedStudent.GetDateOfBirth(studentID));
                txtAddress.Text = detailedStudent.GetAddress(studentID);
                txtCity.Text = originInfo.GetCity(studentID);
                txtParish.Text = originInfo.GetParish(studentID);
                txtZipCode.Text = originInfo.GetZipCode(studentID);
                dtpEnrollDate.Value = Convert.ToDateTime(academicInfo.GetEnrollDate(studentID));
                dtpGraduationDate.Value = Convert.ToDateTime(academicInfo.GetGradDate(studentID));
                txtDegree.Text = academicInfo.GetDegree(studentID);
                lblDepartment.Text = departmentInfo.GetDepartment(studentID);
                lblDepartmentHead.Text = departmentInfo.GetDepartmentHead(lblDepartment.Text);
                lblTerm.Text = smallCourse.GetTerm(studentID).ToString();

                if (lblTerm.Text == "1" || lblTerm.Text == "0")
                {
                    lblGPA.Text = "N/A";
                }
                else
                {
                    lblGPA.Text = detailedGrades.GetGPA(studentID).ToString("0.00");
                }

            }
            else
            {
                MessageBox.Show("Error finding student. \n\nPlease make sure you have the Student ID entered correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text.Length >= 3 && txtStudentID.Text.Length <= 6 && txtFirstName.Text.Length >= 1 && txtLastName.Text.Length >= 1 && txtPhoneNumber.Text.Length >= 1 && txtEmail.Text.Length >= 1
                && txtAddress.Text.Length >= 1)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to update this student?", "Confirm Update", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    detailedStudent.UpdateStudent(txtFirstName.Text, txtLastName.Text, dtpDateOfBirth.Value.Date.ToString("yyyy-MM-dd"), txtPhoneNumber.Text,
                            txtEmail.Text, txtAddress.Text, txtStudentID.Text);

                    if (txtCity.Text.Length >= 1 && txtParish.Text.Length >= 1 && txtZipCode.Text.Length >= 1 && txtStudentID.Text.Length >= 1)
                    {
                        originInfo.UpdateOrigin(txtCity.Text, txtParish.Text, txtZipCode.Text, txtStudentID.Text);

                        if (txtDegree.Text.Length >= 1)
                        {
                            academicInfo.UpdateAcademics(dtpEnrollDate.Value.Date.ToString("yyyy-MM-dd"), dtpGraduationDate.Value.Date.ToString("yyyy-MM-dd"), txtDegree.Text, txtStudentID.Text);                            
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error updating student. \n\nPlease make sure you have the student's information entered correctly.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentID.Focus();
                return;
            }
            MessageBox.Show("Successfully updated student.", "Update success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to clear the form?", "Confirm Clear", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                txtStudentID.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtPhoneNumber.Text = "";
                txtEmail.Text = "";
                dtpDateOfBirth.Value = DateTimePicker.MinimumDateTime;
                txtAddress.Text = "";
                txtCity.Text = "";
                txtParish.Text = "";
                txtZipCode.Text = "";
                dtpEnrollDate.Value = DateTimePicker.MinimumDateTime;
                dtpGraduationDate.Value = DateTimePicker.MinimumDateTime;
                txtDegree.Text = "";
                lblDepartment.Text = "";
                lblDepartmentHead.Text = "";
                lblTerm.Text = "";
                lblGPA.Text = "";
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
    }
}
