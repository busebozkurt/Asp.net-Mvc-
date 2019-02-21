using OgrenciKayit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciKayit.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OgrenciKaydet(string Ad, string Soyad, string Ders, int Not)
        {
            if (HttpRuntime.Cache["Ogrenciler"] == null)
            {
                List<Ogrenci> OgrenciListesi = new List<Ogrenci>();
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Ad = Ad;
                ogrenci.Soyad = Soyad;
                ogrenci.Ders = Ders;
                ogrenci.Not = Not;

                OgrenciListesi.Add(ogrenci);
                HttpRuntime.Cache["Ogrenciler"] = OgrenciListesi;
            }
            else
            {
                List<Ogrenci> OgrenciListesi = (List<Ogrenci>)HttpRuntime.Cache["Ogrenciler"];
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Ad = Ad;
                ogrenci.Soyad = Soyad;
                ogrenci.Ders = Ders;
                ogrenci.Not = Not;

                OgrenciListesi.Add(ogrenci);
                HttpRuntime.Cache["Ogrenciler"] = OgrenciListesi;
            }
            return RedirectToAction("OgrenciListesi");
        }

        public ActionResult OgrenciListesi()
        {
            var model = (List<Ogrenci>)HttpRuntime.Cache["Ogrenciler"];
            return View(model);
        }
    }
}