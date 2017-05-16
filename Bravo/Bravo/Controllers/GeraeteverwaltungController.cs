using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bravo.Controllers
{
    public class GeraeteverwaltungController : Controller
    {
        // GET: Geraeteverwaltung
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GeraetHinzufuegen()
        {
            return View();
        }

        public ActionResult GeraetDetails()
        {
            return View();
        }
    }
}