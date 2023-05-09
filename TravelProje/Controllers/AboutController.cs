using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProje.Models.Class;

namespace TravelProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        TravelContext db = new TravelContext();
        public ActionResult Index()
        {
            var degerler = db.Abouts.ToList();
            return View(degerler);
        }
    }
}