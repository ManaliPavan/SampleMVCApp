using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMVCApp.Models;

namespace SampleMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        public ActionResult ShowAllEmployee()
        {
            List<Employee> emp = new List<Employee>()
            {
               new Employee{ Id = 1,EmpName = "Manali",Designation = "Software Developer",Salary =38000 },
               new Employee{ Id = 2,EmpName = "Sonali",Designation = "Software Tester",Salary =28000 },
               new Employee{ Id = 3,EmpName = "Janvi",Designation = "Data Analyst",Salary =48000 },
               new Employee{ Id = 4,EmpName = "Sanvi",Designation = "Software Developer",Salary =38000 },
               new Employee{ Id = 5,EmpName = "Anvi",Designation = "Data Analyst",Salary =48000 },
            };
            ViewBag.EmpList = emp;
            return View();
        }

        [HttpGet]

        public ActionResult NewEmployee()
        {
            List<string> Options = new List<string>();
            Options.Add("Choose an Option");
            Options.Add("Yes");
            Options.Add("No");
            ViewData["Options"] = new SelectList(Options);
            return View();
        }

        [HttpPost]  //attribute
        public ActionResult NewEmployee(FormCollection fc, ICollection<string> technicalskills)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.designation = fc["designation"];
            ViewBag.address = fc["address"];
            ViewBag.technicalskills = technicalskills;
            ViewBag.Options = fc["Options"];
            return View("EmpDetails");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}