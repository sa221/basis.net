using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementSystemVer1.DAL.DAO
{
    public class Visitor
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public int ContactNo { set; get; }
        public Zone Zone { set; get; }
    }
}
