using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagementRD
{
    public partial class frmProgressReport : Form
    {
        string prStudentID;
        string gradDate;
        Student prStudent = new Student();
        Academics prAcademics = new Academics();
        Course prCourse = new Course();
        Grades prGrades = new Grades();
        DbConnection prConnection = new DbConnection();
        Bitmap memoryImage;

        public frmProgressReport(string studentID)
        {
            InitializeComponent();
            prStudentID = studentID;
        }

        private void frmProgressReport_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = prStudent.GetFirstName(prStudentID);
            lblLastName.Text = prStudent.GetLastName(prStudentID);
            lblDegree.Text = prAcademics.GetDegree(prStudentID);
            lblTerm.Text = "Winter 2020";
            lblGPA.Text = prGrades.GetGPA(prStudentID).ToString("0.00");
            gradDate = prAcademics.GetGradDate(prStudentID);            
            lblGradDate.Text = Convert.ToDateTime(gradDate).ToString("MM/dd/yyyy");
            lblReportDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

            prConnection.OpenConnection();
            SqlDataReader dataReader = prConnection.DataReader("SELECT CourseName FROM Course INNER JOIN Grades ON Course.CourseID = Grades.CourseID WHERE StudentID='" + prStudentID
                + "' AND Term LIKE '2020-WIN%' ORDER BY CourseName");
            dataReader.Read();
            if (dataReader.HasRows)
            {
                lblClass1.Text = dataReader.GetString(0);
                dataReader.Read();

                if (dataReader.HasRows)
                {
                    lblClass2.Text = dataReader.GetString(0);
                    dataReader.Read();

                    if (dataReader.HasRows)
                    {
                        lblClass3.Text = dataReader.GetString(0);
                    }
                }
            }
            dataReader.Close();

            dataReader = prConnection.DataReader("SELECT Grade FROM Grades INNER JOIN Course ON Grades.CourseID = Course.CourseID WHERE StudentID ='" + prStudentID + "' AND " +
                "Term LIKE '2020-WIN%' ORDER BY CourseName");
            dataReader.Read();
            if (dataReader.HasRows)
            {
                lblGrade1.Text = dataReader.GetString(0);
                dataReader.Read();

                if (dataReader.HasRows)
                {
                    lblGrade2.Text = dataReader.GetString(0);
                    dataReader.Read();

                    if (dataReader.HasRows)
                    {
                        lblGrade3.Text = dataReader.GetString(0);
                    }
                }
            }
            dataReader.Close();
            prConnection.CloseConnection();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            PrintDocument prDocument;
            prDocument = new PrintDocument();
            prDocument.DocumentName = lblFirstName.Text + lblLastName.Text + "Progress Report";
            prDocument.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            printPreviewDialog1.Document = prDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = CreateGraphics();
            Size s = Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Location.X, Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
