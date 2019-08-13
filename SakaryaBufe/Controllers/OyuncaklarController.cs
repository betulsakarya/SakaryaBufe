﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SakaryaBufe.Controllers
{
    public class OyuncaklarController : Controller
    {
        SakaryaBufe.SakaryaBufeEntities3 db = new SakaryaBufeEntities3();
        // GET: Oyuncaklar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OyuncakCesitleri()
        {
            var oyuncaklarr = db.Oyuncaklars.Where(Y => Y.id > 0);  //Kategori id den boş deger dönerse kabul edilmemesi için
            return View(oyuncaklarr);
        }

        public ActionResult SatinAl(int id)   //Baslik string geldigi için string alınır
        {
            return View(db.Oyuncaklars.FirstOrDefault(x => x.id == id));  // Gönderilen id degerinde herhangi bir ürün varsa bunu geri gönderir.
        }
        [HttpPost]

        public ActionResult SatinAl(string Urun, string Mail, string İsim, string Telefon, string Mesaj)   //Baslik string geldigi için string alınır
        {
            if (Urun == null)
            {
                MesajBox ms = new MesajBox();
                ms.AdSoyad = İsim;
                ms.Mail = Mail;
                ms.Telefon = Telefon;
                ms.Mesaj_Siparis = "Mesaj !";
                ms.Mesaj = Mesaj;
                db.MesajBoxes.Add(ms);
                db.SaveChanges();

                return Redirect("/");    // Siparis gönderildikten sonra index sayfasına dönmek için
            }
            else
            {
                MesajBox ms = new MesajBox();
                ms.AdSoyad = İsim;
                ms.Mail = Mail;
                ms.Telefon = Telefon;
                ms.Mesaj_Siparis = "Sipariş !";
                ms.Mesaj = Mesaj;
                db.MesajBoxes.Add(ms);
                db.SaveChanges();

                return Redirect("/");
            }
        }
    }
}