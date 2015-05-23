using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementApp
{
    public partial class StudentEntry : Form
    {
        public StudentEntry()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string regNo = regNoTextBox.Text;
            string address = addressTextBox.Text;

            //if (IsRegNoExists(regNo))
            //{
            //    MessageBox.Show("Reg no allready exists");
            //    return;
            //}


            string connectingString = @"SERVER =\SQLEXPRESS; Database = UniversityManagementBD; IntegratedSecurity = true";
            SqlConnection connection = new SqlConnection(connectingString);

          
            string query = "INSERT INTO Students VALUES('"+name+"','"+regNo+"','"+address+"')";
            //execute query
            SqlCommand command = new SqlCommand(query,connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            if (rowAffected>0)
            {
                MessageBox.Show("Successfully Data Inserted");
            }
            else
            {
                MessageBox.Show("Error");
            }



        }
    }
}
