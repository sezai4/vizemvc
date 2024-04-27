using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcokul.Models.entity;

namespace mvcokul.Controllers
{
    public class raporController : Controller
    {
        // GET: ogrenciler
        odevEntities db = new odevEntities();
        public ActionResult Index()
        {
            var degerler = db.ogrenci.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Yeniogrenci()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeniogrenci(ogrenci p1)
        {
            db.ogrenci.Add(p1);
            db.SaveChanges();
            return View();
        }

    }
}