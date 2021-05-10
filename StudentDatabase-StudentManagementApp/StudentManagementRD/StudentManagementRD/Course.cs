using System;
using System.Data.SqlClient;

namespace StudentManagementRD
{
    /// <summary>
    /// Description: The student class contains methods for reading, inserting, and updating data in the Course table.
    /// Author: David Lockwood
    /// Business Logic: One term consists of 3 courses.
    /// Date: 5/9/2021
    /// Last Update: Created method for deleting records in the Course table
    /// </summary>
    public class Course
    {
        object currentCourses;
        object allCourses;
        int term;

        DbConnection courseConnection = new DbConnection();

        /*This method retrieves the courses a student is currently taking. It is used for displaying the current courses in the BasicStudentInfo form
         input: studentID, string, needed for the WHERE clause to determine which student's classes are retrieved
        output: currentCourses, object, returned to be used as a DataSource for the grid view in the BasicStudentInfo form*/
        public object GetCurrentCourses(string studentID)
        {
            courseConnection.OpenConnection();
            currentCourses = courseConnection.ShowDataInGridView("SELECT Grades.CourseID AS Course, CourseName AS Course_Title, Term " +
                "FROM Grades INNER JOIN Course ON Grades.CourseID = Course.CourseID WHERE Grades.StudentID = '" + studentID + "' AND Term LIKE '2021-SPR%';");
            courseConnection.CloseConnection();
            return currentCourses;
        }
        /*This method retrieves all records of a student's courses. It is used to display all courses whether completed or in progress in data grid form
         input: studentID, string, used in the WHERE clause to determine which student's classes are retrieved
        output: allCourses, object, returned to be used as a DataSource for the grid view in the StudentCourses form*/
        public object GetAllCourses(string studentID)
        {
            courseConnection.OpenConnection();
            allCourses = courseConnection.ShowDataInGridView("SELECT Grades.CourseID AS Course, CourseName, Term, Grade " +
                "FROM Grades INNER JOIN Course ON Grades.CourseID = Course.CourseID WHERE Grades.StudentID = '" + studentID + "' ORDER BY Grades.CourseID");
            courseConnection.CloseConnection();
            return allCourses;
        }
        /*This method retrieves the number of a student's terms that are in the Grades table to calculate the student's current term. It is used to determine the student's
         current term and display it in the desired text box or label
        input: studentID, string, used in the WHERE clause to determine what student's term count to take
        output: term, int, returns the value of term after the calculation is performed*/
        public int GetTerm(string studentID)
        {
            courseConnection.OpenConnection();
            SqlDataReader dataReader = courseConnection.DataReader("SELECT COUNT(Term) AS CurrentTerm FROM Grades WHERE StudentID='" + studentID + "'");
            dataReader.Read();
            term = Convert.ToInt32(dataReader["CurrentTerm"]);
            courseConnection.CloseConnection();
            dataReader.Close();
            term = term / 3;
            return term;
        }
        public void AddNewCourse(string courseID, string courseName)
        {
            courseConnection.OpenConnection();
            courseConnection.ExecuteQueries("INSERT INTO Course VALUES ('" + courseID + "', '" + courseName + "')");
            courseConnection.CloseConnection();
        }
        public bool CheckCourseID(string courseID)
        {
            bool studentIDExists = false;
            courseConnection.OpenConnection();
            SqlDataReader dataReader = courseConnection.DataReader("SELECT CourseID FROM Course WHERE CourseID='" + courseID + "'");

            if (dataReader.HasRows)
            {
                studentIDExists = true;
            }
            courseConnection.CloseConnection();
            return studentIDExists;
        }
        public void UpdateCourseInfo(string courseID, string courseName)
        {
            courseConnection.OpenConnection();
            courseConnection.ExecuteQueries("UPDATE Course SET CourseName='" + courseName + "' WHERE CourseID='" + courseID + "'");
            courseConnection.CloseConnection();
        }
        public void DeleteCourse(string courseID)
        {
            courseConnection.OpenConnection();
            courseConnection.ExecuteQueries("DELETE FROM Course WHERE CourseID='" + courseID + "'");
            courseConnection.CloseConnection();
        }
    }
}
