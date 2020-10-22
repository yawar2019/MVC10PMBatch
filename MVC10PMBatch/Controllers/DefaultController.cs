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

        public ActionResult GetEmployees()
        {
            List<EmployeeModel> emp = new List<EmployeeModel>();
            

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1;
            obj1.EmpName = "Sai";
            obj1.EmpSalary = 15000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 2;
            obj2.EmpName = "Wilson";
            obj2.EmpSalary = 15000;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1;
            obj3.EmpName = "Gosh";
            obj3.EmpSalary = 15000;

            EmployeeModel obj4 = new EmployeeModel();
            obj4.EmpId = 1;
            obj4.EmpName = "Vali";
            obj4.EmpSalary = 15000;

            emp.Add(obj1);
            emp.Add(obj2);
            emp.Add(obj3);
            emp.Add(obj4);


            ViewBag.info = emp;
            

            return View();

        }


        public ActionResult EmployeeAnotherWay()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Sai";
            obj.EmpSalary = 15000;


            //object model = obj;
            return View(obj);
        }
    }
}