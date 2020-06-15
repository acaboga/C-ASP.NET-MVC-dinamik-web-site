using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoronaSon.Models;

namespace CoronaSon.Controllers
{
    public class HomeController : Controller
    {
        AspPandemi db = new AspPandemi();
        public ActionResult Index()
        {
            return View();
        }
        [Route("test")]
        public ActionResult test()
        {
            return View(db.Test.ToList());
        }
        [Route("pozitif")]
        public ActionResult Poz()
        {
            return View(db.Poz.ToList());
        }
        [Route("negatif")]
        public ActionResult neg()
        {
            return View(db.Neg.ToList());
        }
        public ActionResult Tcreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Tcreate([Bind(Include ="Id,Ad,Soyad,Durum,Pozitif,Negatif")]Test test)
        {
            try
            {
                db.Test.Add(test);
                db.SaveChanges();

                return RedirectToAction("test");
            }
            catch 
            {

                return View();
            }
        }
        public ActionResult Tedit(int? Id)
        {
            Test test = db.Test.Find(Id);
            if (test==null)
            {
                return HttpNotFound();
            }
            return View(test);

        }
        [HttpPost]
       public ActionResult Tedit([Bind(Include ="Id,Ad,Soyad,Durum,Pozitif,Negatif")]Test test)
        {
            if (ModelState.IsValid)
            {
                db.Entry(test).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("test");
            }
            return View();
        }
        public ActionResult Tdelete(int? Id)
        {
            Test test = db.Test.Find(Id);
            if (test==null)
            {
                return HttpNotFound();
            }
            return View(test);
        }
        [HttpPost,ActionName("Tdelete")]
        public ActionResult TdeleteConfirm(int Id)
        {
            if (ModelState.IsValid)
            {
                Test test = db.Test.Find(Id);
                db.Test.Remove(test);
                db.SaveChanges();
                return RedirectToAction("test");
            }
            return View();
        }


    }
}