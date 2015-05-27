using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FairManagementSystemVer1.BLL;
using FairManagementSystemVer1.DAL.DAO;

namespace FairManagementSystemVer1.UI
{
    public partial class ZoneSpecificVisitorUI : Form
    {
        ZoneManager zoneManager = new ZoneManager();

        public ZoneSpecificVisitorUI()
        {
            InitializeComponent();
            LoadZone();
            showAll();
            
        }

       

        public void LoadZone()
        {
            zoneComboBox.DataSource = zoneManager.GetAll();
            zoneComboBox.DisplayMember = "ZoneName";
            zoneComboBox.ValueMember = "ID";


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showAll();

        }

        private void showAll()
        {
            if (zoneComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(@"Please select a zone .", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                List<Visitor> visitors = zoneManager.GetAllVisitorInSpecificZone(Convert.ToInt32(zoneComboBox.SelectedValue.ToString()));
                int serialNumber = 1;
                zoneSpecificListView.Items.Clear();
                foreach (Visitor visitor in visitors)
                {
                    ListViewItem listViewItem = new ListViewItem(serialNumber.ToString());

                    listViewItem.SubItems.Add(visitor.Name);
                    listViewItem.SubItems.Add(visitor.Email);
                    listViewItem.SubItems.Add(visitor.ContactNo.ToString());

                    zoneSpecificListView.Items.Add(listViewItem);
                    serialNumber++;

                }
                totalTextBox.Text = zoneSpecificListView.Items.Count.ToString();
            }
        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
