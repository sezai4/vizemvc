using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcokul.Models.entity;

namespace mvcokul.Controllers
{
    public class idariController : Controller
    {
        // GET: ogretmen
        odevEntities db = new odevEntities();
        public ActionResult Index()
        {
            var degerler = db.ogretmen.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Yeniogretmen()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeniogretmen(ogretmen p1)
        {
            db.ogretmen.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int id)
        {
            var ogret = db.ogretmen.Find(id);
            db.ogretmen.Remove(ogret);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult OgretmenGetir(int id)
        {
            var ogt = db.ogretmen.Find(id);
            return View("OgretmenGetir", ogt);
        }
        public ActionResult Guncelle(ogretmen p1)
        {
            var ogt = db.ogretmen.Find(p1.ogretmenid);
            ogt.ogretmenid = p1.ogretmenid;
            ogt.ogretmenadı = p1.ogretmenadı;
            ogt.ogretmensoyadı = p1.ogretmensoyadı;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}