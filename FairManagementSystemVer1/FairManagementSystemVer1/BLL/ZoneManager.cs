using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemVer1.DAL.DAO;
using FairManagementSystemVer1.DAL.Gateway;

namespace FairManagementSystemVer1.BLL
{
    public class ZoneManager
    {
        private ZoneGateway zoneGateway = new ZoneGateway();

        public List<Zone> GetAll()
        {
            return zoneGateway.GetAll();
        }

        public List<Visitor> GetAllVisitorInSpecificZone(int id)
        {
            return zoneGateway.GetAllVisitorInSpecificZone(id);
        }
        public List<VisitingZone> GetZoneWiseVisitors()
        {

            return zoneGateway.GetTotalVisitor();
        }

        public string GetTotalVisitors()
        {
            return zoneGateway.GetTotalVisitors();
        }
    }
}
