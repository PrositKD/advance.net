using lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
     
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(SignUpModel signUp)
            
        {
            /*  ViewBag.name = fc["name"];
              ViewBag.id = fc["id"];
              ViewBag.gender = fc["gender"];
              ViewBag.profession = fc["profession"];
              ViewBag.hobbies = fc["hobbies"];
              return View();*/
            if (ModelState.IsValid)
            {  //all validation in submitted model
                return RedirectToAction("Index");
            }
            return View(signUp);
        }

    }
}