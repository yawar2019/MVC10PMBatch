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

        public ActionResult getAllEmployee()
        {

            List<EmployeeModel> emplist = new List<EmployeeModel>();


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

            emplist.Add(obj1);
            emplist.Add(obj2);
            emplist.Add(obj3);
            emplist.Add(obj4);


            


            //object model = obj;
            return View(emplist);
        }

        public ActionResult getAllEmployeeDeptCustomize()
        {

            List<EmployeeModel> emplist = new List<EmployeeModel>();


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

            emplist.Add(obj1);
            emplist.Add(obj2);
            emplist.Add(obj3);
            emplist.Add(obj4);


            DepartmentModel mobj = new Models.DepartmentModel();
            mobj.DeptId = 1;
            mobj.DeptName = "IT";

            DepartmentModel mobj1 = new Models.DepartmentModel();
            mobj1.DeptId = 2;
            mobj1.DeptName = "Marketting";

            List<DepartmentModel> deptObj = new List<DepartmentModel>();
            deptObj.Add(mobj);
            deptObj.Add(mobj1);

            EmpDept listObj = new EmpDept();
            listObj.Emp = emplist;
            listObj.dept = deptObj;


            //object model = obj;
            return View(listObj);
        }


        public RedirectResult GetDifferentOutput()
        {
            return Redirect("http://www.facebook.com");
        }
        public RedirectResult GetDifferentRedirect()
        {
            return Redirect("~/Default/getAllEmployee");
        }

        public RedirectToRouteResult GetDifferentRoute()
        {

            //  return RedirectToRoute("Bakery");
            return RedirectToAction("GetDifferentOutput");
        }

        public RedirectToRouteResult GetDiffControllerMthd()
        {

            //  return RedirectToRoute("Bakery");
            return RedirectToAction("About","New",new {id=1});
        }

        public RedirectToRouteResult GetDiffControllerMthd2()
        {
            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 2;
            obj2.EmpName = "Wilson";
            obj2.EmpSalary = 15000;

            //  return RedirectToRoute("Bakery");
            return RedirectToAction("About2", "New", obj2);
        }

        public FileResult getMeFile() {
            return File("~/Web.config","application/xml","web.config");
        }

        public JsonResult getjsonData()
        {

            List<EmployeeModel> emplist = new List<EmployeeModel>();


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

            emplist.Add(obj1);
            emplist.Add(obj2);
            emplist.Add(obj3);
            emplist.Add(obj4);

            return Json(emplist, JsonRequestBehavior.AllowGet);

        }

        public ContentResult getmediffData(int ? id) {

            if (id == 1)
            {
                return Content("Hello World");
            }
            else if (id == 2)
            {
                return Content("<p style=color:red>Hello World</p>");
            }
            else
            {
                return Content("<script>alert('how r u');</script>");
            }
        }

        public ActionResult getPartialView() {
            return View();
        }
    }
}