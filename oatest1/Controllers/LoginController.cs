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
        public ActionResult Register()
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
                //return View("~/Views/HomePage/form.cshtml");
                return RedirectToRoute(new { controller = "HomePage", action = "Form" });
            }
            else
            {
                
                Response.Write("<script>alert('用户名或密码错误！')</script>");
                return View("~/Views/Login/Login.cshtml");
            }
        }
        [HttpPost]
        public void Register(String rname,String remail,String rpassword)
        {
            var registerinfo = LoginModel.Register(rname,remail,rpassword);
            if (registerinfo!=0)
            {
                //Response.Write("<script>alert('注册成功！')</script>");
                //return Redirect("Login");
                String URL = "../Login/Login";
                Response.Write("<script>alert('注册成功！');window.location.href='" + URL + "';</script>");
            }
            else
            {
                //Response.Write("<script>alert('发生了预期之外的错误，请重试！')</script>");
                //return View("~/Views/Login/Login.cshtml");
                String URL = "../Login/Register";
                Response.Write("<script>alert('发生了预期之外的错误，请重试！');window.location.href='" + URL + "';</script>");
            }
        }
    }
}