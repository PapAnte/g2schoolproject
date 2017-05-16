using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bravo.Controllers
{
    public class SoftwareverwaltungController : Controller
    {
        // GET: Software
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SoftwareHinzufuegen()
        {
            return View();
        }

        public ActionResult SoftwareDetails()
        {
            return View();
        }
    }
}