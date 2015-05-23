using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PersonUI : Form
    {
        public PersonUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Person person1 = new Person();
            person1.firstName = firstNameTextBox.Text;
            person1.middleName = middleNameTextBox.Text;
            person1.lastName = lastNameTextBox.Text;

            string fullName = person1.GetFullName();
            fullNameTextBox.Text = fullName;

            string reverseFullName = person1.GetReverseFullName();
            reversefullNameTextBox.Text = reverseFullName;
        }
    }
}
