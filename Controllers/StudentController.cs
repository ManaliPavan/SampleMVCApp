using SampleMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        public ActionResult AddStudent()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            return View();
        }
    }
}