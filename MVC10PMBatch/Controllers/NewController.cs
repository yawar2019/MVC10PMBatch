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
        public ActionResult About() {

            return View("MyTest");
        }
    }
}