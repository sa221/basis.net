using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsIntroApp
{
    public partial class ShowCodeUI : Form
    {
        public ShowCodeUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("102","CSE222");
            myDictionary.Add("103", "CSE223");
            myDictionary.Add("104", "CSE224");

            int code = Convert.ToInt32(codeTextBox.Text);

            if (myDictionary.ContainsKey(code.ToString()))
            {
                MessageBox.Show(myDictionary[code.ToString()]);
            }
            else
            {
                MessageBox.Show("Not Found");
            }

           
        }
    }
}
