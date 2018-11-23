using Avb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvB.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }
        public ActionResult Login(string Username, string Password)
        {
            User user = new User();
            if (user.Login (Username, Password))
            {
                return View("../Home/Index");
            }
            else
            {
                return View("Login");
            }
        }
    }
}