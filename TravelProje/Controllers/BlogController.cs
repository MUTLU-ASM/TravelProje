using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProje.Models.Class;

namespace TravelProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        TravelContext db = new TravelContext();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var degerler = db.Blogs.ToList();
            by.Deger1 = db.Blogs.ToList();
            by.Deger3 = db.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(by);
        }
        
        public ActionResult BlogDetay(int id)
        {
            //var blogBul = db.Blogs.Where(x => x.Id == id).ToList();
            by.Deger1=db.Blogs.Where(x => x.Id == id).ToList();
            by.Deger2=db.Yorumlars.Where(x => x.BlogID == id).ToList();
            return View(by);
        }
    }
}