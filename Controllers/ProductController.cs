using System;
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
            var urunler = c.Products.Where(x => x.IsStock == true).ToList();
            return View(urunler);
        }
        [HttpGet]
        public ActionResult YeniUrun() 
        {
            List<SelectListItem> deger1 = (from x in c.Categories.ToList() select new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryID.ToString()
            }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Product p)
        { 
            c.Products.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunSil(int id) 
        {
            var deger = c.Products.Find(id);
            deger.IsStock = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}