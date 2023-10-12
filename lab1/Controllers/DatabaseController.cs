using lab1.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class DatabaseController : Controller
    {
        // GET: Database
        public ActionResult Index()
        {
            {
                var db = new advanceNetEntities();
                var data = db.Students.ToList();
                return View(data);
            }
        }
    }
}