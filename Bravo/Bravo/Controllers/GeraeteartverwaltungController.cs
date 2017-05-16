using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bravo.Controllers
{
    public class GeraeteartverwaltungController : Controller
    {
        // GET: Geraeteart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GeraeteartHinzufuegen()
        {
            return View();
        }

        public ActionResult GeraeteartDetails()
        {
            return View();
        }
    }
}