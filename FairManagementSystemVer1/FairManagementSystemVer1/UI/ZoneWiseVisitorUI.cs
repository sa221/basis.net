using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FairManagementSystemVer1.BLL;
using FairManagementSystemVer1.DAL.DAO;

namespace FairManagementSystemVer1.UI
{
    public partial class ZoneWiseVisitorUI : Form
    {
        public ZoneWiseVisitorUI()
        {
            InitializeComponent();
            LoadZone();
        }
        ZoneManager zoneManager = new ZoneManager();

        public void LoadZone()
        {
            List<VisitingZone> visitingZones = zoneManager.GetZoneWiseVisitors();
                int serialNumber = 1;
                zoneWiseListView.Items.Clear();
                foreach (VisitingZone visitingZone in visitingZones)
                {
                    ListViewItem listViewItem = new ListViewItem(serialNumber.ToString());

                    listViewItem.SubItems.Add(visitingZone.Name);
                    listViewItem.SubItems.Add(visitingZone.VID);
                   
                   

                    zoneWiseListView.Items.Add(listViewItem);
                    serialNumber++;

                }
            totalVisitortextBox.Text = zoneManager.GetTotalVisitors();

        }
        }
    }

    
