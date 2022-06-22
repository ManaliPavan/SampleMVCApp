using SampleMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCApp.Controllers
{
    public class BookController : Controller
    {
        // GET: Book

        public ActionResult AddBook()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            return View();
        }
    }
}