using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemVer1.DAL.DAO;

namespace FairManagementSystemVer1.DAL.Gateway
{
    public class ZoneGateway
    {
        public ZoneGateway()
        {
            SqlConnectionObj =
                new SqlConnection(ConfigurationManager.ConnectionStrings["FairManegementConString"].ConnectionString);
            SqlCommandObj = new SqlCommand();
            SqlCommandObj.Connection = SqlConnectionObj;
        }
        
        private SqlConnection SqlConnectionObj;
        private SqlCommand SqlCommandObj;

        public List<Zone> GetAll()
        {
            List<Zone> zones = new List<Zone>();
            SqlConnectionObj.Open();
            string query = String.Format("SELECT * FROM tbl_Zone");
            SqlCommandObj.CommandText = query;
            SqlDataReader readerObj = SqlCommandObj.ExecuteReader();
            while (readerObj.Read())
            {
                Zone aZone = new Zone();
                aZone.ID = Convert.ToInt32(readerObj["ID"]);
                aZone.ZoneName = readerObj["ZoneName"].ToString();
                zones.Add(aZone);
            }
            SqlConnectionObj.Close();
            return zones;
        }
        public List<Visitor> GetAllVisitorInSpecificZone(int id)
        {
            List<Visitor> visitors = new List<Visitor>();
            string query = string.Format(@"select tbl_Visitor.Name , tbl_Visitor.Email , tbl_Visitor.CNumber 
                                           from tbl_Visitor join tbl_VisitingZone  on tbl_Visitor.ID = tbl_VisitingZone.VID 
                                           join tbl_Zone  on tbl_Zone.ID = tbl_VisitingZone.ZID
                                           where tbl_Zone.ID ='{0}'", id);


            SqlCommandObj.CommandText = query;

            SqlConnectionObj.Open();
            SqlDataReader readerObj = SqlCommandObj.ExecuteReader();

            while (readerObj.Read())
            {
                Visitor visitor = new Visitor();
                visitor.Name = readerObj[0].ToString();
                visitor.Email = readerObj[1].ToString();
                visitor.ContactNo = Convert.ToInt32(readerObj[2]);
                visitors.Add(visitor);
            }

            SqlConnectionObj.Close();

            return visitors;

        }
        public List<VisitingZone> GetTotalVisitor()
        {
            List<VisitingZone> visitingZones = new List<VisitingZone>();
            string query = string.Format("select * from ZoneWiseTable");
            SqlCommandObj.CommandText = query;
            SqlConnectionObj.Open();

            SqlDataReader readerObj = SqlCommandObj.ExecuteReader();

            while (readerObj.Read())
            {
                VisitingZone visitingZone =new VisitingZone();
                visitingZone.Name = readerObj[0].ToString();
                visitingZone.VID = Convert.ToInt32(readerObj[1].ToString()).ToString();
                visitingZones.Add(visitingZone);
            }
            SqlConnectionObj.Close();
            return visitingZones;
        }

        public string GetTotalVisitors()
        {
            string query = string.Format("select COUNT(ZID) from tbl_VisitingZone");
            SqlCommandObj.CommandText = query;
            SqlConnectionObj.Open();

            SqlDataReader readerObj = SqlCommandObj.ExecuteReader();
            string total = "";
            while (readerObj.Read())
            {
                total = readerObj[0].ToString();
            }
            SqlConnectionObj.Close();
            return total;
        }
        
    
     }
}
