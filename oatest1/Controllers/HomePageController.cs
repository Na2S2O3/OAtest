using oatest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oatest1.Controllers
{
    public class HomePageController : Controller
    {
        Model1 db = new Model1();
        // GET: HomePage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Form()
        {
            
            List<users> list = (from c in db.users select c).ToList();
            ViewData["userlist"] = list;
            return View("~/Views/HomePage/form.cshtml");
        }
    }
}