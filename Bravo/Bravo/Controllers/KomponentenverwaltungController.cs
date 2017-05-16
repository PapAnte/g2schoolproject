using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bravo.Controllers
{
    public class KomponentenverwaltungController : Controller
    {
        // GET: Komponentenverwaltung
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KomponenteHinzufuegen()
        {
            return View();
        }

        public ActionResult KomponenteDetails()
        {
            return View();
        }
    }
}