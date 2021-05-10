using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementRD
{
    /// <summary>
    /// Description: The student class contains methods for reading, inserting, and updating data in the Student table.
    /// Author: David Lockwood
    /// Date: 5/9/2021
    /// Last Update: Created method for updating records in the student table
    /// </summary>
    public class Student
    {
        string firstName;
        string lastName;
        string phoneNumber;
        string email;
        string dateOfBirth;
        string address;
        object studentList;

        DbConnection studentConnection = new DbConnection();

        /*This method is to read the content of the FirstName column and return the value. It is needed to display the student's first name on the desired form
             in the desired text box or label.
            Input: studentID, string, needed for the WHERE clause in the SQL query to return the correct student's name
            Output: firstName, string, returns the contents of the FirstName column as a string to display in a text box or label*/
        public string GetFirstName(string studentID)
        {
            firstName = "";

            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT FirstName, LastName FROM Student WHERE StudentID='" + studentID + "'");
            
            if (dataReader.HasRows)
            {
                dataReader.Read();
                firstName = dataReader["FirstName"].ToString();
            }

            studentConnection.CloseConnection();
            dataReader.Close();
            return firstName;
        }

        /*This method is to read the content of the LastName column and return the value. It is needed to display the student's last name on the desired form
            in the desired text box or label.
            Input: studentID, string, needed for the WHERE clause in the SQL query to return the correct student's name
            Output: lastName, string, returns the contents of the LastName column as a string to display in a text box or label*/
        public string GetLastName(string studentID)
        {
            lastName = "";

            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT FirstName, LastName FROM Student WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                lastName = dataReader["LastName"].ToString();
            }

            studentConnection.CloseConnection();
            dataReader.Close();
            return lastName;
        }

        /*This method is to query the database to check if the student ID exists in the database. It is needed for ensuring a query will go through or checking if a student ID exists before
             inserting or updating a record.
            Input: studentID, string, needed for the WHERE clause in the SQL query
            Output: studentIDExists, bool, true if the query returns a result false if it does not*/
        public bool CheckStudentID(string studentID)
        {
            bool studentIDExists = false;
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT StudentID FROM Student WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                studentIDExists = true;
            }
            return studentIDExists;
        }

        /*This method queries the Student table for data on all students contained in the table. It is needed to display a list of all students' name, ID, and date of birth in grid view.
            Output: lastName, object, returns an object to be used as a data source for the chosen grid view*/
        public object GetStudentList()
        {
            string query = "SELECT LastName, FirstName, StudentID, DateOfBirth FROM Student ORDER BY LastName";
            studentConnection.OpenConnection();
            studentList = studentConnection.ShowDataInGridView(query);
            studentConnection.CloseConnection();
            return studentList;
        }

        /*This method is to read the content of the PhoneNumber column and return the value. It is needed to display the student's phone number on the desired form
            in the desired date time picker.
            Input: studentID, string, needed for the WHERE clause in the SQL query to return the correct student's phone number
            Output: phoneNumber, string, returns the contents of the PhoneNumber column as a string to display in a text box or label*/
        public string GetPhoneNumber (string studentID)
        {
            phoneNumber = "";

            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT PhoneNumber FROM Student WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                phoneNumber = dataReader["PhoneNumber"].ToString();
            }
            studentConnection.CloseConnection();
            dataReader.Close();
            return phoneNumber;
        }

        /*This method is to read the content of the Email column and return the value. It is needed to display the student's email address on the desired form
            in the desired text box or label.
            Input: studentID, string, needed for the WHERE clause in the SQL query to return the correct student's email address
            Output: email, string, returns the contents of the Email column as a string to display in a text box or label*/
        public string GetEmail (string studentID)
        {
            email = "";

            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT Email FROM Student WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                email = dataReader["Email"].ToString();
            }
            studentConnection.CloseConnection();
            dataReader.Close();
            return email;
        }

        /*This method is to read the content of the DateOfBirth column and return the value. It is needed to display the student's date of birth on the desired form
             * in the desired date time picker.
             * Input: studentID, string, needed for the WHERE clause in the SQL query to return the correct student's date of birth
             * Output: dateOfBirth, string, returns the contents of the DateOfBirth as a string to display in the chosen date time picker*/
        public string GetDateOfBirth (string studentID)
        {
            dateOfBirth = "";
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT DateOfBirth FROM Student WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                dateOfBirth = dataReader["DateOfBirth"].ToString();
            }
            studentConnection.CloseConnection();
            dataReader.Close();
            return dateOfBirth;
        }

        /*This method is to read the content of the CurrentAddress column and return the value. It is needed to display the student's address on the desired form
            in the desired text box or label.
            Input: studentID, string, needed for the WHERE clause in the SQL query to return the correct student's email address
            Output: address, string, returns the contents of the CurrentAddress column as a string to display in a text box or label*/
        public string GetAddress (string studentID)
        {
            address = ""; 
            studentConnection.OpenConnection();
            SqlDataReader dataReader = studentConnection.DataReader("SELECT CurrentAddress FROM Student WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                address = dataReader["CurrentAddress"].ToString();
            }
            studentConnection.CloseConnection();
            dataReader.Close();
            return address;
        }

        /*This method is to insert a new record into the Student table. It is needed to add a new student to the database.
             * Input: studentID, string, needed to insert a value in the StudentID column in the Student table
             * firstName, string, needed to insert a value in the FirstName column in the Student table
             * lastName, string, needed to insert a value in the LastName column in the Student table
             * dob, string, needed to insert a value in the DateOfBirth column in the Student table
             * phoneNumber, string, needed to insert a value in the PhoneNumber column in the Student table
             * email, string, needed to insert a value in the Email column in the Student table
             * address, string, needed to insert a value in the CurrentAddress column in the Student table*/
        public void AddNewStudent(string studentID, string firstName, string lastName, string dob, string phoneNumber, string email, string address)
        {
            string query;

            studentConnection.OpenConnection();
            query = "INSERT INTO Student VALUES ('" + firstName + "', '" + lastName + "', '" + dob + "', '" + phoneNumber + "', '" + email + "', '" + address + "', '" + studentID + "')";
            studentConnection.ExecuteQueries(query);
            studentConnection.CloseConnection();
        }

        /*This method is to update an existing record in the Student table. It is needed to update an existing student's information in the database.
         * Input: studentID, string, needed to check if the record exists and ensure the correct student's information is updated
         * firstName, string, needed to update the value of the FirstName column in the Student table
         * lastName, string, needed to update the value of the LastName column in the Student table
         * dob, string, needed to update the value of the DateOfBirth column in the Student table
         * phoneNumber, string, needed to update the value of the PhoneNumber column in the Student table
         * email, string, needed update the value of the Email column in the Student table
         * address, string, needed update the value of the CurrentAddress column in the Student table*/
        public void UpdateStudent(string firstName, string lastName, string dob, string phoneNumber, string email, string address, string studentID)
        {
            string query;

            studentConnection.OpenConnection();

            SqlDataReader dataReader = studentConnection.DataReader("SELECT * FROM Academics WHERE StudentID = '" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Close();
                query = "UPDATE Student SET FirstName ='" + firstName + "', LastName ='" + lastName + "', DateOfBirth ='" + dob + "', PhoneNumber ='" + phoneNumber + "', " +
                    "Email ='" + email + "', CurrentAddress ='" + address + "' WHERE StudentID ='" + studentID + "'";
                studentConnection.ExecuteQueries(query);
            }
            else
            {
                MessageBox.Show("Unable to update student information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataReader.Close();
            }
            studentConnection.CloseConnection();
        }
    }    
}
