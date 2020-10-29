using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdonetExample.Models;

namespace AdonetExample.Controllers
{
    public class NewEmployeeController : Controller
    {
        // GET: NewEmployee
        EmployeeDetail db = new EmployeeDetail();
        public ActionResult Index()
        {
            var Employees = db.GetEmployees();
            return View(Employees);
        }
        [HttpGet]
        public ActionResult Create() {

            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {

            return View();
        }
    }
}