using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NishClub.Models;


namespace NishClub.Controllers
{
    public class HomeController : Controller
    {
        OrderManagement manager;
        public HomeController()
        {
            manager = new OrderManagement();
        }
        // GET: Home
        public ActionResult Index()
        {
            var members = manager.GetAllMembers();
            return View(members);
        }
        public ActionResult Detail(int id)
        {
            DetailListModel model = new DetailListModel();
            model.Member = manager.Getmember(id);
            model.Order = manager.GetMemberOrder(id);
            model.OrderBasket = manager.GetMemberOrderBasket(id);
            return View(model);
        }
    }
}