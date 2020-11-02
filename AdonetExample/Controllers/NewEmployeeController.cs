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
            int i = db.SaveEmployee(emp);
            if (i > 0) {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var Employee = db.GetEmployeeById(id);
            return View(Employee);  
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
           
            int i = db.UpdateEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var Employee = db.GetEmployeeById(id);
            return View(Employee);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
          
            int i = db.DeleteEmployeeById(id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }
    }
}