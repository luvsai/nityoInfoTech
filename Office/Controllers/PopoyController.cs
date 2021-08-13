using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Office.Models;
namespace Office.Controllers
{
    public class PopoyController : Controller
    {
        // GET: Popoy/Random
        public ActionResult Random()
        {
            var character = new Popoy() { Name = "Shrek!" };
            // return View(character);
            return Content("Hello chandrika");
        }

        // GET: Popoy/
        public ActionResult Index()
        {
            var character = new Popoy() { Name = "Shrek!" };
            // return View(character);
            return Json("hello");
        }
    }
}