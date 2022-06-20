using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ProductList()
        {
            string[] products = { "Clothes", "Furniture", "Makeup", "Toys" };
            ViewBag.Products = products;
            return View();
        }
        public ActionResult Save()
        {
            return View();
        }
    }
}