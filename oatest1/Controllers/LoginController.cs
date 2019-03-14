using oatest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace oatest1.Controllers
{
    public class LoginController : Controller
    {
        Model1 entity = new Model1();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(String username, String password)
        {
            //System.Console.WriteLine(username);
            //var users = from s in entity.users
            //            where s.uid == username && s.password == password
            //            select s;
            //String sql = "select * from users where uid == '"+username+"' && password == '"+password+"'";
            ////entity.Database.SqlQuery(sql,entity);
            //if (username != null)
            //{
            //    //System.Console.WriteLine(username);
            //    return View("~/Views/Home/Index.cshtml");
            //}
            //else
            //{
            //    return Content("error!!!!");
            //}
            //return View();
            var userinfo2 = LoginModel.Login(username, password);
            if (userinfo2 != null)
            {
                return View("~/Views/Home/Index.cshtml");
            }
            else
            {
                return View("~/Views/Home/About.cshtml");
            }
        }
    }
}