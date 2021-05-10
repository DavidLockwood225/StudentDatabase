using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace StudentManagementRD
{
    public partial class frmStudentBodyReport : Form
    {
        Bitmap memoryImage;
        public frmStudentBodyReport()
        {
            InitializeComponent();
        }

        private void frmStudentBodyReport_Load(object sender, EventArgs e)
        {
            DbConnection studentBodyConnection = new DbConnection();
            Grades studentBody = new Grades();

            decimal studentBodyGPA;
            decimal morningGPA;
            decimal nightGPA;
            string sumGrades = "0";
            string numberOfGrades = "0";

            //Total student body begin
            studentBodyGPA = 0;

            studentBodyConnection.OpenConnection();
            SqlDataReader dataReader = studentBodyConnection.DataReader("SELECT SUM(_Value) AS GPA FROM GradeValue INNER JOIN Grades ON GradeValue.Grade = Grades.Grade");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                sumGrades = dataReader["GPA"].ToString();
            }
            dataReader.Close();

            dataReader = studentBodyConnection.DataReader("SELECT COUNT(Grade) AS GradeCount FROM Grades");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                numberOfGrades = dataReader["GradeCount"].ToString();
            }

            studentBodyConnection.CloseConnection();
            dataReader.Close();

            if (Convert.ToInt32(numberOfGrades) != 0)
            {
                studentBodyGPA = decimal.Parse(sumGrades) / decimal.Parse(numberOfGrades);
            }

            lblStudentBodyGPA.Text = studentBodyGPA.ToString("0.00");
            //Total student body end

            //Morning students begin
            sumGrades = "0";
            numberOfGrades = "0";

            morningGPA = 0;

            studentBodyConnection.OpenConnection();
            dataReader = studentBodyConnection.DataReader("SELECT SUM(_Value) AS GPA FROM GradeValue INNER JOIN Grades ON GradeValue.Grade = Grades.Grade WHERE Term LIKE '%M'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                sumGrades = dataReader["GPA"].ToString();
            }

            dataReader.Close();

            dataReader = studentBodyConnection.DataReader("SELECT COUNT(Grade) AS GradeCount FROM Grades WHERE Term LIKE '%M'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                numberOfGrades = dataReader["GradeCount"].ToString();
            }

            studentBodyConnection.CloseConnection();
            dataReader.Close();

            if (Convert.ToInt32(numberOfGrades) != 0)
            {
                morningGPA = decimal.Parse(sumGrades) / decimal.Parse(numberOfGrades);
            }

            lblMorningGPA.Text = morningGPA.ToString("0.00");
            //morning students end

            //night students begin
            sumGrades = "0";
            numberOfGrades = "0";

            nightGPA = 0;

            studentBodyConnection.OpenConnection();
            dataReader = studentBodyConnection.DataReader("SELECT SUM(_Value) AS GPA FROM GradeValue INNER JOIN Grades ON GradeValue.Grade = Grades.Grade WHERE Term LIKE '%E'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                sumGrades = dataReader["GPA"].ToString();
            }

            dataReader.Close();

            dataReader = studentBodyConnection.DataReader("SELECT COUNT(Grade) AS GradeCount FROM Grades WHERE Term LIKE '%E'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                numberOfGrades = dataReader["GradeCount"].ToString();
            }

            studentBodyConnection.CloseConnection();
            dataReader.Close();

            if (Convert.ToInt32(numberOfGrades) != 0)
            {
                nightGPA = decimal.Parse(sumGrades) / decimal.Parse(numberOfGrades);
            }

            lblNightGPA.Text = nightGPA.ToString("0.00");
            //night students end

            studentBodyConnection.OpenConnection();
            dataReader = studentBodyConnection.DataReader("SELECT DISTINCT Parish FROM Origin ORDER BY Parish");
            dataReader.Read();
            if (dataReader.HasRows)
            {
                lblParish1.Text = dataReader.GetString(0);
                dataReader.Read();

                if (dataReader.HasRows)
                {
                    lblParish2.Text = dataReader.GetString(0);
                    dataReader.Read();

                    if (dataReader.HasRows)
                    {
                        lblParish3.Text = dataReader.GetString(0);
                        dataReader.Read();

                        if (dataReader.HasRows)
                        {
                            lblParish4.Text = dataReader.GetString(0);
                        }
                    }
                }
            }
            studentBodyConnection.CloseConnection();
            dataReader.Close();

            studentBodyConnection.OpenConnection();
            dataReader = studentBodyConnection.DataReader("SELECT COUNT(Parish) FROM Origin GROUP BY Parish ORDER BY Parish");
            dataReader.Read();
            if (dataReader.HasRows)
            {
                lblNumberOfStudents1.Text = dataReader.GetInt32(0).ToString();
                dataReader.Read();

                if (dataReader.HasRows)
                {
                    lblNumberOfStudents2.Text = dataReader.GetInt32(0).ToString();
                    dataReader.Read();

                    if (dataReader.HasRows)
                    {
                        lblNumberOfStudents3.Text = dataReader.GetInt32(0).ToString();
                        dataReader.Read();

                        if (dataReader.HasRows)
                        {
                            lblNumberOfStudents4.Text = dataReader.GetInt32(0).ToString();
                        }
                    }
                }
            }
            studentBodyConnection.CloseConnection();
            dataReader.Close();

            studentBodyConnection.OpenConnection();
            dataReader = studentBodyConnection.DataReader("SELECT DISTINCT DepartmentName FROM Department ORDER BY DepartmentName");
            dataReader.Read();
            if (dataReader.HasRows)
            {
                lblDepartment1.Text = dataReader.GetString(0);
                dataReader.Read();

                if (dataReader.HasRows)
                {
                    lblDepartment2.Text = dataReader.GetString(0);
                    dataReader.Read();

                    if (dataReader.HasRows)
                    {
                        lblDepartment3.Text = dataReader.GetString(0);
                    }
                }
            }
            studentBodyConnection.CloseConnection();
            dataReader.Close();

            studentBodyConnection.OpenConnection();
            dataReader = studentBodyConnection.DataReader("SELECT COUNT(Degree.DepartmentName) FROM Degree INNER JOIN Academics ON Degree.Degree = Academics.Degree GROUP BY Degree.DepartmentName");
            dataReader.Read();
            if (dataReader.HasRows)
            {
                lblNumberOfDeptStudents1.Text = dataReader.GetInt32(0).ToString();
                dataReader.Read();

                if (dataReader.HasRows)
                {
                    lblNumberOfDeptStudents2.Text = dataReader.GetInt32(0).ToString();
                    dataReader.Read();

                    if (dataReader.HasRows)
                    {
                        lblNumberOfDeptStudents3.Text = dataReader.GetInt32(0).ToString();
                    }
                }
            }
            studentBodyConnection.CloseConnection();
            dataReader.Close();

            studentBodyConnection.OpenConnection();
            dataReader = studentBodyConnection.DataReader("SELECT DepartmentHead FROM Department WHERE DepartmentName='" + lblDepartment1.Text + "'");
            dataReader.Read();
            if (dataReader.HasRows)
            {
                lblDepartmentHead1.Text = dataReader.GetString(0).ToString();
            }
            dataReader.Close();

            dataReader = studentBodyConnection.DataReader("SELECT DepartmentHead FROM Department WHERE DepartmentName='" + lblDepartment2.Text + "'");
            dataReader.Read();
            if (dataReader.HasRows)
            {
                lblDepartmentHead2.Text = dataReader.GetString(0).ToString();
            }
            dataReader.Close();

            dataReader = studentBodyConnection.DataReader("SELECT DepartmentHead FROM Department WHERE DepartmentName='" + lblDepartment3.Text + "'");
            dataReader.Read();
            if (dataReader.HasRows)
            {
                lblDepartmentHead3.Text = dataReader.GetString(0).ToString();
            }
            studentBodyConnection.CloseConnection();
            dataReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            PrintDocument sbrDocument;
            sbrDocument = new PrintDocument();
            sbrDocument.DocumentName = "Student Body Report";
            sbrDocument.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            printPreviewDialog1.Document = sbrDocument;
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
