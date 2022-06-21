using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMVCApp.Models;


namespace SampleMVCApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        
        public ActionResult GetAllProducts()
        {
            List<Product> productlist = new List<Product>()
            {
               new Product{ Id = 1,Name = "laptop",Company = "Lenovo",Price =38000 },
                new Product{Id = 2,Name = "laptop",Company = "HP",Price = 39000},
                new Product{Id = 3, Name = "mobile",Company = "Mi" ,Price = 15000},
                new Product{Id = 4, Name = "mobile",Company = "Apple" , Price = 88000},
                 new Product{Id = 5, Name = "laptop" ,Company = "Apple" , Price = 138000}
            };
            ViewBag.ProductList = productlist;
            return View();
        }
        public ActionResult Save()
        {
            return View();
        }
    }
}