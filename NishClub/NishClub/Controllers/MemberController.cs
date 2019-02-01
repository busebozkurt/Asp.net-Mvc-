using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NishClub.Controllers
{
    public class MemberController : Controller
    {
        OrderManagement manager;
        public MemberController()
        {
            manager = new OrderManagement();
        }
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            manager.DeleteMember(id);
            // return View();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Activate(int id)
        {
            manager.ActivateMember(id);
            //return View();
            return RedirectToAction("Index", "Home");
        }
    }
}