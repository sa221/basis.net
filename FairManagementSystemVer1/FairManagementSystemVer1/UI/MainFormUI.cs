using System.Windows.Forms;
using FairManagementSystemVer1.UI;

namespace FairManagementSystemVer1
{
    public partial class MainFormUI : Form
    {
        public MainFormUI()
        {
            InitializeComponent();
        }

        private void zoneSpecificVisitorDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ZoneSpecificVisitorUI zoneSpecificVisitorUi = new ZoneSpecificVisitorUI();
            zoneSpecificVisitorUi.Show();
        }

        private void zoneWiseVisitorDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ZoneWiseVisitorUI zoneWiseVisitorUi= new ZoneWiseVisitorUI();
            zoneWiseVisitorUi.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
