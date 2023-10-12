using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Bio()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult References()
        {

            ViewBag.Name = "sazzad Hossain";
            ViewBag.Email = "sazzad@example.com";
            ViewBag.Designation = "Senior Developer";
                var referenceInfo = new
                {
                    Reference1 = new { Name = "MD Sazzad", Email = "sazzad@example.com", Designation = "Senior Developer" },
                    Reference2 = new { Name = "MD Ismail", Email = "ismail@example.com", Designation = "Junior Developer" }
                };

                ViewBag.ReferenceInfo = referenceInfo;
            
                return View();
            

          
        }
    }
}