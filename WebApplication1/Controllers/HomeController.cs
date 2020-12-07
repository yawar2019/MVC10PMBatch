using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HandleError(View = "Error")]

        public ActionResult TestMethod(string id) {

            try
            {
                int c = Convert.ToInt32(id);
                ViewBag.info = c;
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HandleError(View = "Error1")]

        public ActionResult TestMethod12(string id)
        {

            try
            {
                int c = Convert.ToInt32(id);
                ViewBag.info = c;
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [OutputCache(Duration = 10,Location =System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult StoredatinMe() {
            return View();
        }
    }
}