using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthorizationExample.Models;
using System.Web.Security;

namespace AuthorizationExample.Controllers
{
    public class LoginController : Controller
    {
        redchilliEntities db = new redchilliEntities();


        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
    
        public ActionResult Login(User u,string returnUrl)
        {
            var userdetail = db.Users.Where(s => s.UserName == u.UserName).FirstOrDefault();
            if ((userdetail.UserName==u.UserName) && (userdetail.Password == u.Password))
            {
                FormsAuthentication.SetAuthCookie(u.UserName, false);

                string Url = (string.IsNullOrEmpty(returnUrl) ? "Index" : returnUrl);
                return RedirectToAction(Url);
            }
            else
            {
                return View();

            }
        }
        // GET: Login
        [Authorize(Roles="Admin")]
        public ActionResult ContactUS()
        {
            return View();
        }
        
        [Authorize(Roles ="Employee") ]
        public ActionResult AboutUs()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Employee")]
        public ActionResult Index()
        {
            return View();
        }
    }
}