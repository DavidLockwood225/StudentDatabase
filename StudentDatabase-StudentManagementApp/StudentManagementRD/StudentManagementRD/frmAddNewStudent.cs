using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagementRD
{
    public partial class frmAddNewStudent : Form
    {
        Student addNew = new Student();
        Academics insertAcademics = new Academics();
        Origin insertOrigin = new Origin();
        DbConnection newStudent = new DbConnection();
        bool idCheck;

        public frmAddNewStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text.Length >= 3 && txtStudentID.Text.Length <= 6 && txtFirstName.Text.Length >= 1 && txtLastName.Text.Length >= 1 && txtPhoneNumber.Text.Length >= 1 
                    && txtEmail.Text.Length >= 1 && txtAddress.Text.Length >= 1)
                {
                    idCheck = addNew.CheckStudentID(txtStudentID.Text);
                    if (idCheck == false)
                    {
                        addNew.AddNewStudent(txtStudentID.Text, txtFirstName.Text, txtLastName.Text, dtpDateOfBirth.Value.Date.ToString("yyyy-MM-dd"), txtPhoneNumber.Text, txtEmail.Text, txtAddress.Text);

                        if (txtCity.Text.Length >= 1 && txtParish.Text.Length >= 1 && txtZipCode.Text.Length >= 1)
                        {
                            insertOrigin.AddNewOrigin(txtCity.Text, txtParish.Text, txtZipCode.Text, txtStudentID.Text);
                        }
                        else
                        {
                            MessageBox.Show("Unable to update student's city, parish and zip code. Make sure the student's first name and last name are entered correctly and" +
                                " try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCity.Focus();
                            return;
                        }

                        if (txtDegree.Text.Length >= 1)
                        {
                            insertAcademics.AddNewAcademics(dtpEnrollDate.Value.ToString("yyyy-MM-dd"), dtpGraduationDate.Value.ToString("yyyy-MM-dd"), txtDegree.Text, txtStudentID.Text);
                        }
                        else
                        {
                            MessageBox.Show("Unable to update student's enrollment date, graduation date and degree. Make sure the student's first name and last name are entered correctly and" +
                                 " try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dtpEnrollDate.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student ID already exists in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Unable to update student information. Please make sure the student's first name, last name, phone number, email, and address are entered correctly.", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                    return;
                }
                newStudent.OpenConnection();
                SqlDataReader dataReader = newStudent.DataReader("SELECT * FROM Student WHERE StudentID ='" + txtStudentID.Text + "'");

                if (dataReader.HasRows)
                {
                    MessageBox.Show("Student successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to add student. \n\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                newStudent.CloseConnection();
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit this form?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
