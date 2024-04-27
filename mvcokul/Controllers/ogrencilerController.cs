using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcokul.Models.entity;

namespace mvcokul.Controllers
{
    public class ogrencilerController : Controller
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
        public ActionResult SIL(int id)
        {
            var ogrenci = db.ogrenci.Find(id);
            db.ogrenci.Remove(ogrenci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult OgrenciGetir(int id)
        {
            var og = db.ogrenci.Find(id);
            return View("OgrenciGetir", og);
        }
        public ActionResult Guncelle(ogrenci p1)
        {
            var og = db.ogrenci.Find(p1.ogrenciid);
            og.ogrenciid = p1.ogrenciid;
            og.ogrenciadi = p1.ogrenciadi;
            og.ogrencisoyadi = p1.ogrencisoyadi;
            og.bolumid = p1.bolumid;
            og.mezuniyet = p1.mezuniyet;
            og.kredi = p1.kredi;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}