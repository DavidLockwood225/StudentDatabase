using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace StudentManagementRD
{
    public class Student
    {
        string firstName;
        string lastName;
        string studentID;
        string degree;
        string phoneNumber;
        string email;
        string dateOfBirth;
        string address;
        string city;
        string parish;
        string zipCode;
        string enrollDate;
        string gradDate;
        string departmentName;
        string departmentHead;
        decimal gpa;

        DbConnection studentConnection = new DbConnection();
        public string GetFirstName(string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT firstName, lastName FROM Student WHERE StudentID=" + studentID);
            
            if (dataReader.HasRows)
            {
                dataReader.Read();
            }
            else
            {
                return "";
            }

            firstName = dataReader["FirstName"].ToString();
            studentConnection.CloseConnection();
            return firstName;
        }
        public string GetLastName(string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT firstName, lastName FROM Student WHERE StudentID=" + studentID);

            if (dataReader.HasRows)
            {
                dataReader.Read();
            }
            else
            {
                return "";
            }

            lastName = dataReader["LastName"].ToString();
            studentConnection.CloseConnection();
            return lastName;
        }
        public string GetStudentID(string firstName, string lastName)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT StudentID FROM Student WHERE FirstName='" + firstName + "' AND LastName='" + lastName + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
            }
            else
            {
                return "";
            }

            studentID = dataReader["StudentID"].ToString();
            studentConnection.CloseConnection();
            return studentID;
        }
        public string GetDegree(string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT Degree FROM Academics WHERE StudentID=" + studentID);
            dataReader.Read();
            degree = dataReader["Degree"].ToString();
            studentConnection.CloseConnection();
            return degree;
        }
        public string GetPhoneNumber (string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT PhoneNumber FROM Student WHERE StudentID=" + studentID);
            dataReader.Read();
            phoneNumber = dataReader["PhoneNumber"].ToString();
            studentConnection.CloseConnection();
            return phoneNumber;
        }
        public string GetEmail (string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT Email FROM Student WHERE StudentID=" + studentID);
            dataReader.Read();
            email = dataReader["Email"].ToString();
            studentConnection.CloseConnection();
            return email;
        }
        public string GetDateOfBirth (string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT DateOfBirth FROM Student WHERE StudentID=" + studentID);
            dataReader.Read();
            dateOfBirth = dataReader["DateOfBirth"].ToString();
            studentConnection.CloseConnection();
            return dateOfBirth;
        }
        public string GetAddress (string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT CurrentAddress FROM Student WHERE StudentID=" + studentID);
            dataReader.Read();
            address = dataReader["CurrentAddress"].ToString();
            studentConnection.CloseConnection();
            return address;
        }
        public string GetCity (string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT City FROM Origin WHERE StudentID=" + studentID);
            dataReader.Read();
            city = dataReader["City"].ToString();
            studentConnection.CloseConnection();
            return city;
        }
        public string GetParish (string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT Parish FROM Origin WHERE StudentID=" + studentID);
            dataReader.Read();
            parish = dataReader["Parish"].ToString();
            studentConnection.CloseConnection();
            return parish;
        }
        public string GetZipCode (string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT ZIP FROM Origin WHERE StudentID=" + studentID);
            dataReader.Read();
            zipCode = dataReader["ZIP"].ToString();
            studentConnection.CloseConnection();
            return zipCode;
        }
        public string GetEnrollDate(string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT EnrollmentDate FROM Academics WHERE StudentID=" + studentID);
            dataReader.Read();
            enrollDate = dataReader["EnrollmentDate"].ToString();
            studentConnection.CloseConnection();
            return enrollDate;
        }
        public string GetGradDate(string studentID)
        {
            string gd;
            CultureInfo usTime = new CultureInfo("en-US");

            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT GraduationDate FROM Academics WHERE StudentID=" + studentID);
            dataReader.Read();
            gradDate = dataReader["GraduationDate"].ToString();
            studentConnection.CloseConnection();
            return gradDate;
        }
        public string GetDepartment(string studentID)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT DepartmentName FROM Degree INNER JOIN Academics ON Academics.Degree = Degree.Degree WHERE StudentID=" + studentID);
            dataReader.Read();
            departmentName = dataReader["DepartmentName"].ToString();
            studentConnection.CloseConnection();
            return departmentName;
        }
        public string GetDepartmentHead(string department)
        {
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT DepartmentHead FROM Department WHERE DepartmentName='" + department + "'");
            dataReader.Read();
            departmentHead = dataReader["DepartmentHead"].ToString();
            studentConnection.CloseConnection();
            return departmentHead;
        }
        public decimal GetGPA(string studentID)
        {
            string sumGrades;
            string numberOfGrades; 

            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT SUM(_Value) AS GPA FROM GradeValue INNER JOIN Grades ON GradeValue.Grade = Grades.Grade WHERE StudentID=" + studentID);
            dataReader.Read();
            sumGrades = dataReader["GPA"].ToString();
            dataReader.Close();

            SqlDataReader dataReader2 = studentConnection.DataReader("SELECT COUNT(Grade) AS GradeCount FROM Grades WHERE StudentID=" + studentID);
            dataReader2.Read();
            numberOfGrades = dataReader2["GradeCount"].ToString();
            studentConnection.CloseConnection();
            gpa = decimal.Parse(sumGrades) / decimal.Parse(numberOfGrades);
            return gpa;
        }

        public void AddNewStudent(string firstName, string lastName, string dob, string phoneNumber, string email, string address)
        {
            string query;

            DbConnection newStudentConnection = new DbConnection();
            newStudentConnection.OpenConnection();
            query = "INSERT INTO Student VALUES ('" + firstName + "', '" + lastName + "', '" + dob + "', '" + phoneNumber + "', '" + email + "', '" + address + "')";
            newStudentConnection.ExecuteQueries(query);
            newStudentConnection.CloseConnection();
        }
        public void AddNewOrigin(string city, string parish, string zipCode)
        {
            string query;

            DbConnection newStudentConnection = new DbConnection();
            newStudentConnection.OpenConnection();

            query = "INSERT INTO Origin VALUES ('" + city + "', '" + parish + "', '" + zipCode + "')" ;
            newStudentConnection.ExecuteQueries(query);
            newStudentConnection.CloseConnection();
        }
        public void AddNewAcademics(string enrollDate, string gradDate, string degree)
        {
            string query;

            DbConnection newStudentConnection = new DbConnection();
            newStudentConnection.OpenConnection();

            query = "INSERT INTO Academics VALUES ('" + enrollDate + "', '" + gradDate + "', '" + degree + "')";
            newStudentConnection.ExecuteQueries(query);
            newStudentConnection.CloseConnection();
        }
        public void UpdateStudent(string firstName, string lastName, string dob, string phoneNumber, string email, string address, string studentID)
        {
            string query;

            
                DbConnection updateStudentConnection = new DbConnection();
                updateStudentConnection.OpenConnection();

                query = "UPDATE Student SET FirstName ='" + firstName + "', LastName ='" + lastName + "', DateOfBirth ='" + dob + "', PhoneNumber ='" + phoneNumber + "', " +
                    "Email ='" + email + "', Address ='" + address + "' WHERE StudentID =" + studentID;
                updateStudentConnection.ExecuteQueries(query);
                updateStudentConnection.CloseConnection();

        }
        public void UpdateOrigin(string city, string parish, string zipCode, string studentID)
        {
            string query;

            DbConnection updateStudentConnection = new DbConnection();
            updateStudentConnection.OpenConnection();

            query = "UPDATE Origin SET City ='" + city + "', Parish ='" + parish + "', ZIP ='" + zipCode + "' WHERE StudentID =" + studentID;
            updateStudentConnection.ExecuteQueries(query);
        }
        public void UpdateAcademics(string enrollDate, string gradDate, string degree, string studentID)
        {
            string query;

            DbConnection updateStudentConnection = new DbConnection();
            updateStudentConnection.OpenConnection();

            query = "UPDATE Academics SET EnrollmentDate ='" + enrollDate + "', GraduationDate ='" + gradDate + "', Degree ='" + degree + "' WHERE StudentID =" + studentID;
            updateStudentConnection.ExecuteQueries(query);
        }
    }    
}
