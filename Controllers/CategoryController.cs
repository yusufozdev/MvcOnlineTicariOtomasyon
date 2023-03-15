﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes;


namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Categories.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult KategoriEkle() 
        { 
            return View();
        }

        [HttpPost]
        public ActionResult KategoriEkle(Category k)
        {
            c.Categories.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriSil(int id)
        {
            var ktg = c.Categories.Find(id);
            c.Categories.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.Categories.Find(id);
            return View("KategoriGetir",kategori);
        }

        public ActionResult KategoriGüncelle(Category k)
        {
            var ktgr = c.Categories.Find(k.CategoryID);
            ktgr.CategoryName = k.CategoryName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}