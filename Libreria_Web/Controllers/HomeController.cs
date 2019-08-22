using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocio;
using System.Web.Mvc;

namespace Libreria_Web.Controllers
{
    public class HomeController : Controller
    {
        private ConsultasPublicaciones consultasPublicaciones = new ConsultasPublicaciones();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexAfter()
        {
            var model = consultasPublicaciones.ObtenerPublicaciones();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}