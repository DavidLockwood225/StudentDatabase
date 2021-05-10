using System.Data.SqlClient;

namespace StudentManagementRD
{
    class Department
    {
        string departmentName;
        string departmentHead;

        DbConnection departmentConnection = new DbConnection();
        public string GetDepartment(string studentID)
        {
            departmentName = "";

            departmentConnection.OpenConnection();
            SqlDataReader dataReader = departmentConnection.DataReader("SELECT DepartmentName FROM Degree INNER JOIN Academics ON Academics.Degree = Degree.Degree WHERE StudentID='" + studentID + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                departmentName = dataReader["DepartmentName"].ToString();
            }
            departmentConnection.CloseConnection();
            dataReader.Close();
            return departmentName;
        }
        public string GetDepartmentHead(string department)
        {
            departmentHead = "";

            departmentConnection.OpenConnection();
            SqlDataReader dataReader = departmentConnection.DataReader("SELECT DepartmentHead FROM Department WHERE DepartmentName='" + department + "'");

            if (dataReader.HasRows)
            {
                dataReader.Read();
                departmentHead = dataReader["DepartmentHead"].ToString();
            }
            departmentConnection.CloseConnection();
            dataReader.Close();
            return departmentHead;
        }

    }
}
