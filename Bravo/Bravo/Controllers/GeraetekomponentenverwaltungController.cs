using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bravo.Controllers
{
    public class GeraetekomponentenverwaltungController : Controller
    {
        // GET: Komponentenverwaltung
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GeraetekomponenteHinzufuegen()
        {
            return View();
        }

        public ActionResult GeraetekomponenteDetails()
        {
            return View();
        }
    }
}