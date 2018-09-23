using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenFinalIX.Controllers
{

    public class HomeController : Controller
    {
        [RequireHttps]
        public ActionResult Index()
        {
            return View();
        }
        
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Registro()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult Reporte()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult ReporteGama()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}