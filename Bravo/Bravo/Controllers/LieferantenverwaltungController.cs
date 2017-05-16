using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bravo.Controllers
{
    public class LieferantenverwaltungController : Controller
    {
        // GET: Lieferantenverwaltung
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LieferantDetails()
        {
            return View();
        }

        public ActionResult LieferantHinzufuegen()
        {
            return View();
        }
    }
}