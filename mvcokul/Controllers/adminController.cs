using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcokul.Models.entity;

namespace mvcokul.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
        odevEntities db = new odevEntities();
        public ActionResult Index()
        {
            var degerler = db.admin.ToList();
            return View(degerler);
        }
    }
}