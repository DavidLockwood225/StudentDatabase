using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementRD
{
    public class Academics
    {
        string degree;
        string enrollDate;
        string gradDate;

        DbConnection academic = new DbConnection();

        public string GetDegree(string studentID)
        {
            degree = "";

            academic.OpenConnection();
            SqlDataReader dataReader = academic.DataReader("SELECT Degree FROM Academics WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                degree = dataReader["Degree"].ToString();
            }
            academic.CloseConnection();
            dataReader.Close();
            return degree;
        }
        public string GetEnrollDate(string studentID)
        {
            enrollDate = "";

            academic.OpenConnection();
            SqlDataReader dataReader = academic.DataReader("SELECT EnrollmentDate FROM Academics WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                enrollDate = dataReader["EnrollmentDate"].ToString();
            }
            academic.CloseConnection();
            dataReader.Close();
            return enrollDate;
        }
        public string GetGradDate(string studentID)
        {
            gradDate = "";

            academic.OpenConnection();
            SqlDataReader dataReader = academic.DataReader("SELECT GraduationDate FROM Academics WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                gradDate = dataReader["GraduationDate"].ToString();
            }
            academic.CloseConnection();
            dataReader.Close();
            return gradDate;
        }
        public void AddNewAcademics(string enrollDate, string gradDate, string degree, string studentID)
        {
            string query;

            academic.OpenConnection();
            query = "INSERT INTO Academics VALUES ('" + studentID + "', '" + enrollDate + "', '" + gradDate + "', '" + degree + "')";
            academic.ExecuteQueries(query);
            academic.CloseConnection();
        }

        public void UpdateAcademics(string enrollDate, string gradDate, string degree, string studentID)
        {
            string query;

            academic.OpenConnection();

            SqlDataReader dataReader = academic.DataReader("SELECT * FROM Academics WHERE StudentID = '" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Close();
                query = "UPDATE Academics SET EnrollmentDate ='" + enrollDate + "', GraduationDate ='" + gradDate + "', Degree ='" + degree + "' WHERE StudentID ='" + studentID + "'";
                academic.ExecuteQueries(query);
            }
            else
            {
                MessageBox.Show("Unable to update student information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataReader.Close();
            }
            academic.CloseConnection();
        }
    }
}
