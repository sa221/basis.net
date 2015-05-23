using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString =
                ConfigurationManager.ConnectionStrings["UniversityManagementConStringDB"].ConnectionString;

        private void saveButton_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.name = nameTextBox.Text;
            students.regNo = regNoTextBox.Text;
            students.address = addressTextBox.Text;

            if (students.IsregNoExists(students.regNo))
            {
                MessageBox.Show("RegNo already exists!");
                return;
                
            }

            
                
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Students VALUES ('" + students.name + "','" + students.regNo + "','" +
                           students.address + "')";

            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            if (rowAffected>0)
            {
                MessageBox.Show("Data Inserted Successfully");
                ShowAllStudents();
            }
            else
            {
                MessageBox.Show("Failed");
            }
            
             
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            ShowAllStudents();

        }

        partial void LoadStudentListView(List<Students> studentss)
        {
            studentsList.Items.Clear();
            foreach (var student in studentss)
            {
               ListViewItem item=new ListViewItem(student.ID.ToString());
                item.SubItems.Add(student.name);
                item.SubItems.Add(student.regNo);
                item.SubItems.Add(student.address);

                studentsList.Items.Add(item);
            }
        }

        public void ShowAllStudents()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Students";


            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Students> studentList = new List<Students>();
            while (reader.Read())
            {
                Students student = new Students();

                student.ID = int.Parse(reader["ID"].ToString());
                student.name = reader["Name"].ToString();
                student.regNo = reader["RegNo"].ToString();
                student.address = reader["Address"].ToString();

                studentList.Add(student);
            }
            reader.Close();
            connection.Close();

            LoadStudentListView(studentList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllStudents();
        }

        
    }
}
