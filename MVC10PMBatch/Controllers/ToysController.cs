using System;
using System.Collections.Generic;
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
    }
}