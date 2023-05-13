using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProje.Models.Class;

namespace TravelProje.Controllers
{
    public class HomeController : Controller
    {
        TravelContext db = new TravelContext();
        public ActionResult Index()
        {
            var degerler = db.Blogs.Take(5).ToList();
            return View(degerler);      
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Concat()
        {
            return View();
        }  
        public PartialViewResult Partial1()
        {
            var degerler = db.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(degerler);
        }    
        public PartialViewResult Partial2()
        {
            var degerler = db.Blogs.Where(x => x.Id==1).ToList();
            return PartialView(degerler);
        }    
        public PartialViewResult Partial3()
        {
            var degerler = db.Blogs.Take(5).ToList();
            return PartialView(degerler);
        }     
        public PartialViewResult Partial4()
        {
            var degerler = db.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }        
        public PartialViewResult Partial5()
        {
            var degerler = db.Blogs.Take(3).OrderByDescending(x => x.Id).ToList();
            return PartialView(degerler);
        }
    }
}