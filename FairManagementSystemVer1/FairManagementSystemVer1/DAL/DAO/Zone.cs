using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementSystemVer1.DAL.DAO
{
    public class Zone
    {
        public string ZoneName { set; get; }
        public int ID { set; get; }
        public Visitor Visitor { set; get; }
        public Zone zoneWiseTotalVisitor { get; set; }
    }
}
