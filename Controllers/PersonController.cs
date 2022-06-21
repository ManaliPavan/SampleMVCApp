using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCApp.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        [HttpGet] //two types of req in application-get and post similiar as i/p and o/p bydefault it is getrequest 
        public ActionResult PersonalDetails()
        {
            List<string> Options = new List<string>();
            Options.Add("Choose an Option");
            Options.Add("Yes");
            Options.Add("No");
            ViewData["Options"] = new SelectList(Options);  //selectlist for single value -and multiselectlist is to select multiple values
            return View();
        }

        [HttpPost]  //attribute
        public ActionResult PersonalDetails(FormCollection fc,ICollection<string> hobbies) //Formcollection fc reads  all info given by user in html page, Icollection is used to map multiple values given in hobbies
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.hobbies = hobbies;
            ViewBag.Options = fc["Options"];
            return View("Details");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}