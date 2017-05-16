using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bravo.Controllers
{
    public class GeraetkomponentenverwaltungController : Controller
    {
        // GET: Komponentenverwaltung
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GeraetkomponenteHinzufuegen()
        {
            return View();
        }

        public ActionResult GeraetkomponenteDetails()
        {
            return View();
        }
    }
}