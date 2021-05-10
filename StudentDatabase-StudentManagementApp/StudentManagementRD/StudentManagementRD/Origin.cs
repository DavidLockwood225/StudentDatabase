using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagementRD
{
    /// <summary>
    /// Description: The student class contains methods for reading, inserting, and updating data in the Origin table.
    /// Author: David Lockwood
    /// Date: 5/9/2021
    /// Last Update: Created method for updating records in the Origin table
    /// </summary>
    class Origin
    {
        string city;
        string parish;
        string zipCode;

        DbConnection origin = new DbConnection();

        /*This method is to read the content of the City column and return the value. It is needed to display the student's city on the desired form
             in the desired text box or label.
            Input: studentID, string, needed for the WHERE clause in the SQL query to return the correct student's city
            Output: city, string, returns the contents of the City column as a string to display in a text box or label*/
        public string GetCity(string studentID)
        {
            city = "";
            origin.OpenConnection();
            SqlDataReader dataReader = origin.DataReader("SELECT City FROM Origin WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                city = dataReader["City"].ToString();
            }
            origin.CloseConnection();
            dataReader.Close();
            return city;
        }

        /*This method is to read the content of the Parish column and return the value. It is needed to display the student's parish on the desired form
             in the desired text box or label.
            Input: studentID, string, needed for the WHERE clause in the SQL query to return the correct student's parish
            Output: parish, string, returns the contents of the Parish column as a string to display in a text box or label*/
        public string GetParish(string studentID)
        {
            parish = "";
            origin.OpenConnection();
            SqlDataReader dataReader = origin.DataReader("SELECT Parish FROM Origin WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                parish = dataReader["Parish"].ToString();
            }
            origin.CloseConnection();
            dataReader.Close();
            return parish;
        }

        /*This method is to read the content of the ZIP column and return the value. It is needed to display the student's zip code on the desired form
             in the desired text box or label.
            Input: studentID, string, needed for the WHERE clause in the SQL query to return the correct student's zip code
            Output: zipCode, string, returns the contents of the ZIP column as a string to display in a text box or label*/
        public string GetZipCode(string studentID)
        {
            zipCode = "";

            origin.OpenConnection();
            SqlDataReader dataReader = origin.DataReader("SELECT ZIP FROM Origin WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                zipCode = dataReader["ZIP"].ToString();
            }
            origin.CloseConnection();
            dataReader.Close();
            return zipCode;
        }

        /*This method is to insert a new record into the Origin table. It is needed to add a new student to the database.
             * Input: studentID, string, needed to insert a value in the StudentID column in the Origin table
             * city, string, needed to insert a value in the City column in the Origin table
             * parish, string, needed to insert a value in the Parish column in the Origin table
             * zipCode, string, needed to insert a value in the ZIP column in the Origin table*/
        public void AddNewOrigin(string city, string parish, string zipCode, string studentID)
        {
            string query;

            origin.OpenConnection();

            query = "INSERT INTO Origin VALUES ('" + studentID + "', '" + city + "', '" + parish + "', '" + zipCode + "')";
            origin.ExecuteQueries(query);
            origin.CloseConnection();
        }

        /*This method is to insert a new record into the Origin table. It is needed to add a new student to the database.
             * Input: studentID, string, needed to check if the record exists and ensure the correct student's information is updated
             * city, string, needed to update the value of the City column in the Origin table
             * parish, string, needed to update the value to the Parish column in the Origin table
             * zipCode, string, needed to update the value to the ZIP column in the Origin table*/
        public void UpdateOrigin(string city, string parish, string zipCode, string studentID)
        {
            string query;

            origin.OpenConnection();

            SqlDataReader dataReader = origin.DataReader("SELECT * FROM Academics WHERE StudentID = '" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Close();
                query = "UPDATE Origin SET City ='" + city + "', Parish ='" + parish + "', ZIP ='" + zipCode + "' WHERE StudentID ='" + studentID + "'";
                origin.ExecuteQueries(query);
            }
            else
            {
                MessageBox.Show("Unable to update student information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataReader.Close();
            }
            origin.CloseConnection();
        }
    }
}
