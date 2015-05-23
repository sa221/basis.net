using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string firstName;
        private string lastName;

        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string fatherName = fatherTextBox.Text;
            string motherName = motherTextBox.Text;
            string address = addressTextBox.Text;

            MessageBox.Show("All Information Save");
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fatherTextBox.Clear();
            motherTextBox.Clear();
            addressTextBox.Clear();
        }

        private void allInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Name : "+firstName.ToString(+"\nLast Name"+lastName)));
        }
    }
}
