using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bravo.Controllers
{
    public class BenutzerverwaltungController : Controller
    {
        // GET: Benutzerverwaltung
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BenutzerDetails()
        {
            return View();
        }

        public ActionResult BenutzerHinzufuegen()
        {
            return View();
        }
    }
}