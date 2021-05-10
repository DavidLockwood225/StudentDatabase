using System;
using System.Data.SqlClient;

namespace StudentManagementRD
{
    /// <summary>
    /// Description: The student class contains methods for reading, inserting, and updating data in the Grades table.
    /// Author: David Lockwood
    /// Date: 5/9/2021
    /// Last Update: Created method for deleting records in the Grades table
    /// </summary>
    class Grades
    {
        DbConnection gradesConnection = new DbConnection();
        decimal gpa;


        /*This method retrieves the sum of the student's grades and the number of grades and performs a calculation with them. It is used to display the student's GPA
         Input: studentID, string, used in the query's WHERE clause to retrieve the correct sum and grade count
        Output: gpa, decimal, contains the result of the calculations and returns it as a decimal to be displayed on the desired form in the desired text box or label*/
        public decimal GetGPA(string studentID)
        {
            string sumGrades = "0";
            string numberOfGrades = "0";

            gpa = 0;

            gradesConnection.OpenConnection();
            SqlDataReader dataReader = gradesConnection.DataReader("SELECT SUM(_Value) AS GPA FROM GradeValue INNER JOIN Grades ON GradeValue.Grade = Grades.Grade WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                sumGrades = dataReader["GPA"].ToString();
            }
            dataReader.Close();

            SqlDataReader dataReader2 = gradesConnection.DataReader("SELECT COUNT(Grade) AS GradeCount FROM Grades WHERE StudentID='" + studentID + "'");

            if (dataReader2.HasRows)
            {
                dataReader2.Read();
                numberOfGrades = dataReader2["GradeCount"].ToString();
            }
            gradesConnection.CloseConnection();
            dataReader.Close();

            if (Convert.ToInt32(numberOfGrades) != 0)
            {
                gpa = decimal.Parse(sumGrades) / decimal.Parse(numberOfGrades);
            }
            return gpa;
        }

        /*This method inserts a new record into the Grades table without the value for the Grade column. It is used to "Schedule" a new course by inserting the CourseID, StudentID, 
         * and Term but not the Grade
         Input: courseID, string, needed to insert the value into the CourseID column
        studentID, string, needed to insert the value into the StudentID column
        term, string, needed to insert the value into the Term column*/
        public void ScheduleNewCourse(string courseID, string studentID, string term)
        {
            gradesConnection.OpenConnection();
            gradesConnection.ExecuteQueries("INSERT INTO Grades (CourseID, StudentID, Term) VALUES ('" + courseID + "', '" + studentID + "', '" + term + "')");
            gradesConnection.CloseConnection();
        }
        /*This method updates an existing record in the Grades table when a value for the Grade column is present. Used to add a grade to an existing record, and possibly update Term
         if necessary.
        Input: courseID, string, needed for the WHERE clause to make sure the correct course is updated
        studentID, string, needed for the WHERE clause to make sure the correct student is updated
        grade, string, needed to update the value of the Grade column
        term, string, needed to update the value of the Term column*/
        public void UpdateCourseWithGrade(string courseID, string grade, string studentID, string term)
        {
            gradesConnection.OpenConnection();
            gradesConnection.ExecuteQueries("UPDATE Grades SET Grade='" + grade + "', Term='" + term + "' WHERE CourseID='" + courseID + "' AND StudentID='" + studentID + "'");
            gradesConnection.CloseConnection();
        }
        /*This method updates an existing record in the Grades table when a value for the Grade column is not present. Used to update the Term column
         input: courseID, string, needed for the WHERE clause to make sure the correct course is updated
        studentID, string, needed for the WHERE clause to make sure the correct student is updated
        term, string, needed to update the value of the Term column*/
        public void UpdateCourseWithoutGrade(string courseID, string studentID, string term)
        {
            gradesConnection.OpenConnection();
            gradesConnection.ExecuteQueries("UPDATE Grades SET Term='" + term + "' WHERE CourseID='" + courseID + "' AND StudentID=' " + studentID + "'");
            gradesConnection.CloseConnection();
        }
        /*This method deletes an existing record in the Grades table. Used to delete an entire course from a student's records
         input: courseID, string, needed for the WHERE clause to make sure the correct course is deleted
        studentID, string, needed for the WHERE clause to make sure the correct student's course is deleted*/
        public void DeleteStudentCourse(string courseID, string studentID)
        {
            gradesConnection.OpenConnection();
            gradesConnection.ExecuteQueries("DELETE FROM Grades WHERE CourseID='" + courseID + "' AND StudentID='" + studentID + "'");
            gradesConnection.CloseConnection();
        }
    }
}
