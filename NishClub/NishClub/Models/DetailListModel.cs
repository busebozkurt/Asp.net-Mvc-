using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NishClub.Models
{
    public class DetailListModel
    {
        public tbl_Members Member { get; set; }
        public List<tbl_Orders> Order { get; set; }
        public List<tbl_OrderBaskets> OrderBasket { get; set; }
    }
}