using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BlogProjesi_Entity.Models.Siniflar;

namespace BlogProjesi_Entity.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        VeriTabaniBaglantisi baglanti = new VeriTabaniBaglantisi();
        public ActionResult Index()
        {
            var degerler = baglanti.Yeteneklers.ToList();
            return View(degerler);
        }
    }
}