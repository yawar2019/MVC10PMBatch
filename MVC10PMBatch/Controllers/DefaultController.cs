using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC10PMBatch.Models;
namespace MVC10PMBatch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default Controller got Changed
        public ActionResult Index()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Sai";
            obj.EmpSalary = 15000;

            ViewBag.info = obj;

            return View();
        }
    }
}