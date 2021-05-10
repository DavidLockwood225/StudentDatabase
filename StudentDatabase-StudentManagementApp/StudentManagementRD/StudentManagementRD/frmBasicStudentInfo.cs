using System;
using System.Windows.Forms;

namespace StudentManagementRD
{
    public partial class frmBasicStudentInfo : Form
    {
        Student basicStudent = new Student();
        Academics basicAcademics = new Academics();
        Course presentCourses = new Course();

        public frmBasicStudentInfo()
        {
            InitializeComponent();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {           
            string studentID;

            try
            {
                if (txtBasicStudentID.Text.Length >= 3 && txtBasicStudentID.Text.Length <= 6)
                {
                    studentID = txtBasicStudentID.Text;
                    bool studentIDCheck = basicStudent.CheckStudentID(studentID);

                    if (studentIDCheck == true)
                    {
                        txtBasicFirstName.Text = basicStudent.GetFirstName(studentID);
                        txtBasicLastName_.Text = basicStudent.GetLastName(studentID);
                        try
                        {
                            grdCurrentClasses.DataSource = presentCourses.GetCurrentCourses(studentID);
                            grdCurrentClasses.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                            lblTerm.Text = presentCourses.GetTerm(studentID).ToString();
                            if (Convert.ToInt32(lblTerm.Text) < 1 && lblTerm.Text != "")
                            {
                                lblTerm.Text = "1";
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error finding student's current courses. \n\nPlease make sure they are currently registered for class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        lblDegree_.Text = basicAcademics.GetDegree(studentID);
                    }
                    else
                    {
                        MessageBox.Show("Student ID does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Error finding student. \n\nPlease make sure you have the Student ID entered correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Cannot connect to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnViewStudentList_Click(object sender, EventArgs e)
        {
            basicStudent = new Student();
            grdCurrentClasses.DataSource = basicStudent.GetStudentList();
            grdCurrentClasses.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void frmBasicStudentInfo_Load(object sender, EventArgs e)
        {
            txtBasicStudentID.Focus();
        }

        private void btnStudentCourses_Click(object sender, EventArgs e)
        {
            frmStudentCourses studentCourses = new frmStudentCourses();
            studentCourses.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo);

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
                txtBasicStudentID.Text = "";
                txtBasicFirstName.Text = "";
                txtBasicLastName_.Text = "";
                grdCurrentClasses.Columns.Clear();
            }
        }

        private void btnProgressReport_Click(object sender, EventArgs e)
        {
            if (txtBasicStudentID.Text.Length >= 3 && txtBasicStudentID.Text.Length <= 6)
            {
                bool studentIDCheck = basicStudent.CheckStudentID(txtBasicStudentID.Text);

                if (studentIDCheck == true)
                {
                    frmProgressReport progressReport = new frmProgressReport(txtBasicStudentID.Text);
                    progressReport.ShowDialog();
                }
                else
                {
                    MessageBox.Show("A valid student ID is required to view a Progress Report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A valid student ID is required to view a Progress Report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmStudentBodyReport studentBodyReport = new frmStudentBodyReport();
            studentBodyReport.ShowDialog();
        }
    }
}
