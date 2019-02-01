using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NishClub
{
    public class OrderManagement
    {
        NishClubDBEntities db;
        public OrderManagement()
        {
            db = new NishClubDBEntities();
        }
        public List<tbl_Members> GetAllMembers()
        {
            return (from i in db.tbl_Members where i.ISACTIVE != null select i).ToList();
        }
        public tbl_Members Getmember(int id)
        {
            return (from i in db.tbl_Members where i.MemberID == id select i).SingleOrDefault();
        }
        public void DeleteMember(int id)
        {
            var result = (from i in db.tbl_Members where i.MemberID == id select i).SingleOrDefault();
            //db.tbl_Members.Remove(result)
            result.ISACTIVE = false;
            db.SaveChanges();
        }
        public void ActivateMember(int id)
        {
            var result = (from i in db.tbl_Members where i.MemberID == id select i).SingleOrDefault();
            result.ISACTIVE = true;
            db.SaveChanges();
        }
        public List<tbl_Orders>GetMemberOrder(int id)
        {
            return (from i in db.tbl_Orders where i.MemberID == id select i).ToList();
        }
        public List<tbl_OrderBaskets>GetMemberOrderBasket(int id)
        {
            return (from i in db.tbl_OrderBaskets where i.MemberID == id select i).ToList();
        }
    }
}