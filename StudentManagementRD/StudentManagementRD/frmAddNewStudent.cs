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
    public partial class frmAddNewStudent : Form
    {
        public frmAddNewStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student addNew = new Student();

            try
            {
                addNew.AddNewStudent(txtFirstName.Text, txtLastName.Text, dtpDateOfBirth.Value.Date.ToString("yyyy-MM-dd"), txtPhoneNumber.Text, txtEmail.Text, txtAddress.Text);
                addNew.AddNewOrigin(txtCity.Text, txtParish.Text, txtZipCode.Text);
                addNew.AddNewAcademics(dtpEnrollDate.Value.Date.ToString("yyyy-MM-dd"), dtpGraduationDate.Value.Date.ToString("yyyy-MM-dd"), txtDegree.Text);
                MessageBox.Show("Student successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
