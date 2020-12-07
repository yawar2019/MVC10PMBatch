using FormAuthenticationExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FormAuthenticationExample.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(UserModel user)
        {
            if(user.UserName=="Admin" && user.Password == "Admin")
            {
                FormsAuthentication.SetAuthCookie("Admin", false);
                return Redirect("~/Login/AboutUs");
            }
            else
            {
                return View();
            }
           
        }
        [HttpGet]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return View("Index");
        }
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}