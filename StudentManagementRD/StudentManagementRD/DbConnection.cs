using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.IO;

namespace StudentManagementRD
{
    public class DbConnection
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;"
                                  + "AttachDbFilename=" + Path.GetFullPath("StudentDatabase.mdf")
                                  + ";Integrated Security=True;"
                                  + "Connect Timeout=30;"
                                  + "User Instance=True;";
        SqlConnection connection;

        public void OpenConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }
        public void ExecuteQueries(string Query)
        {
            SqlCommand command = new SqlCommand(Query, connection);
            command.ExecuteNonQuery();
        }
        public SqlDataReader DataReader(string Query)
        {
            SqlCommand command = new SqlCommand(Query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }
        public object ShowDataInGridView(string Query)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, connectionString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            object data = dataSet.Tables[0];
            return data;
        }
    }
}
