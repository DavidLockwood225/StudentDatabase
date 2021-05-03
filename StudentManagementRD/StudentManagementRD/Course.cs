using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementRD
{
    public class Course
    {
        object currentCourses;
        int term;
        public object GetCurrentCourses(string studentID)
        {
            DbConnection courseConnection = new DbConnection();
            courseConnection.OpenConnection();
            currentCourses = courseConnection.ShowDataInGridView("SELECT Grades.CourseID AS Course, CourseName AS Course_Title, Term " +
                "FROM Grades INNER JOIN Course ON Grades.CourseID = Course.CourseID WHERE Grades.StudentID = " + studentID + " AND Term LIKE '2021-SPR%';");
            courseConnection.CloseConnection();
            return currentCourses;
        }
        public int GetTerm(string studentID)
        {
            DbConnection termConnection = new DbConnection();
            termConnection.OpenConnection();
            SqlDataReader dataReader = termConnection.DataReader("SELECT COUNT(Term) AS CurrentTerm FROM Grades WHERE StudentID=" + studentID);
            dataReader.Read();
            term = Convert.ToInt32(dataReader["CurrentTerm"]);
            termConnection.CloseConnection();
            term = term / 3;
            return term;
        }
    }

}
