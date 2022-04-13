using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BlogProjesi_Entity.Models.Siniflar;

namespace BlogProjesi_Entity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        VeriTabaniBaglantisi baglanti = new VeriTabaniBaglantisi();
        public ActionResult Index()
        {
            var degeler = baglanti.Yeteneklers.ToList();
            return View(degeler);
        }

        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(Yetenekler parametre)
        {
            baglanti.Yeteneklers.Add(parametre);
            baglanti.SaveChanges();
            return View();
        }

        public ActionResult YetenekSil(int id)
        {
            var deger = baglanti.Yeteneklers.Find(id);
            baglanti.Yeteneklers.Remove(deger);
            baglanti.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var deger = baglanti.Yeteneklers.Find(id);
            return View("YetenekGetir",deger);
        }

        [HttpPost]
        public ActionResult YetenekGetir (Yetenekler parametre)
        {
            var deger = baglanti.Yeteneklers.Find(parametre.YetenekId);
            deger.YetenekAdi = parametre.YetenekAdi;
            deger.YetenekYuzde = parametre.YetenekYuzde;
            baglanti.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}