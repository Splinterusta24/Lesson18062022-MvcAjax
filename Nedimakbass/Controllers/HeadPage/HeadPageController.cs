using Nedimakbass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nedimakbass.Controllers.HeadPage
{
    public class HeadPageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KayitOl(string txtNameSurname,string txtPhone,string txtPosta,string txtUserName,string txtPassK,string txtPassKT,string txtProvience,string txtDistinct,string txtAdress)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.AdSoyad = txtNameSurname;
            kullanici.Sifre = txtPassK;
            kullanici.Telefon = txtPhone;
            kullanici.Email = txtPosta;
            kullanici.Il = txtProvience;
            kullanici.Ilce = txtDistinct;
            kullanici.Adres = txtAdress;
            kullanici.KullaniciAdi = txtUserName;

            kullanici.KayitOl();

            //return View();
            //return Redirect("/HeadPage/Index");
            return RedirectToAction("Index");
          
        }
        //[HttpPost]
        //public string KaydetAjax(string)
    }
}