using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementApp1
{
    class Students
    {
        public int ID;
        public string name;
        public string regNo;
        public string address;

        public bool IsregNoExists(string regNo)
        {
            string connectionString =
                @"SERVER=VIRUS\SQLEXPRESS; Database=UniversityManagementDB; Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students WHERE RegNo = '" + regNo + "'";
            bool isRegNoExists = false;

            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isRegNoExists = true;
                break;
            }
            reader.Close();
            connection.Close();

            return isRegNoExists;
        }
    }
}
