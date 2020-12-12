using MVC10PMBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC10PMBatch.ServiceReference1;
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


        public ActionResult TestMethod() {
            //ViewData["Name"] = "Dravid";
            //ViewBag.player = "sai";
            TempData["Player"] = "sai";

            return RedirectToAction("TestMethod1");
        }

        public ActionResult TestMethod1()
        {
            // string s=ViewData["Name"].ToString();
            //ViewBag.player = TempData["Player"];
            //TempData.Keep();
            ViewBag.player = TempData.Peek("Player");
            return View();
        }

        public ActionResult ConsumeWebService()
        {
            //WebService1SoapClient obj = new  WebService1SoapClient();
            ServiceReference2.Service1Client obj = new ServiceReference2.Service1Client();
            string s=obj.Add(12, 13).ToString();
            return Content(s);
        }
    }
}