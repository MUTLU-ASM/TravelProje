using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProje.Models.Class;

namespace TravelProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        TravelContext db = new TravelContext();

        public ActionResult Index()
        {
            var degerler = db.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog b)
        {
            db.Blogs.Add(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SilBlog(int id)
        {
            var b = db.Blogs.Find(id);
            db.Blogs.Remove(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetirBlog(int id)
        {
            var bl = db.Blogs.Find(id);
            return View("GetirBlog", bl);
        }
        public ActionResult GuncelleBlog(Blog b)
        {
            var degerler = db.Blogs.Find(b.Id);
            degerler.Aciklama = b.Aciklama;
            degerler.Baslik = b.Baslik;
            degerler.BlogImage = b.BlogImage;
            degerler.Tarih = b.Tarih;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = db.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var deger = db.Yorumlars.Find(id);
            db.Yorumlars.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var yr = db.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var deger = db.Yorumlars.Find(y.Id);
            deger.Ad = y.Ad;
            deger.Mail = y.Mail;
            deger.Yorum = y.Yorum;
            db.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}