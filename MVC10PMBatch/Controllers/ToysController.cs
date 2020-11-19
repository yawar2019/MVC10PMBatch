using MVC10PMBatch.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC10PMBatch.Controllers
{
    public class ToysController : Controller
    {
        // GET: Toys
        public string Guns()
        {
            return "Machine Guns";
        }

        public string Dolls()
        {
            return "Long hair Dolls";
        }

        public ActionResult GetBooks() {

            return View();
        }

        public ActionResult HtmlHelperExample()
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpName = "varma";

            dbMyOnlineShoppingEntities db = new Models.dbMyOnlineShoppingEntities();
            ViewBag.Product = new SelectList(db.Tbl_Product, "ProductId", "ProductName",19);

            return View(emp);

        }

        public ActionResult Index()
        {
            
            return View("HtmlHelperExample");
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase fileupload)
        {
            string filename = Path.GetFileName(fileupload.FileName);
            string path = Server.MapPath("~/upload");
            fileupload.SaveAs(Path.Combine(path, filename));
            ViewBag.msg = "uploaded successfully";

            return View();
        }

        [HttpGet]
        public ActionResult GetValidationExample() {

            return View();
        }
        [HttpPost]
        public ActionResult GetValidationExample(RegisterModel reg)
        {
            if (!ModelState.IsValid)
            {
                return View(reg);

            }
            else
            {
                return View();
            }
        }
    }
}