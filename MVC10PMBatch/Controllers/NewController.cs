using MVC10PMBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC10PMBatch.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public string Index(string Eid)
        {
            return "My Employee Id is " + Eid;
        }
        public ActionResult About(int? id) {

            return View();
        }
        public ActionResult About2(EmployeeModel emp)
        {
            return View();
        }



    }
}