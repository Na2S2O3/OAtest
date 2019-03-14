using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oatest1.Models
{
    public class LoginModel
    {
        /// <summary>
        /// 1、定义的一个返回类型为 user 型的方法
        /// 2、将来在Controller中接收 是否为null 来判断是否允许登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static users Login(string username, string password)
        {
            //初始化EF上下文容器
            Model1 db = new Model1();
            String Password= System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
            return db.users.FirstOrDefault(m => m.uid == username && m.password == Password);
        }
        public static int Register(string rname,string remail,string rpassword)
        {
            Model1 db = new Model1();
            users user = new users();
            user.uid = remail;
            user.uname = rname;
            user.password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(rpassword, "MD5");
            db.users.Add(user);
            try
            {
                 return db.SaveChanges();
            }
            catch
            {
                return 0;
            }
            
        }
    }
}