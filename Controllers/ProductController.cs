﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        Context c = new Context();
        public ActionResult Index()
        {
            var urunler = c.Products.ToList();
            return View(urunler);
        }
        [HttpGet]
        public ActionResult YeniUrun() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Product p)
        { 
            c.Products.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}