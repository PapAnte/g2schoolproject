using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bravo.Controllers
{
    public class RaumverwaltungController : Controller
    {
        // GET: Raumverwltung
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RaumHinzufuegen()
        {
            return View();
        }

        public ActionResult RaumDetails()
        {
            return View();
        }
    }
}