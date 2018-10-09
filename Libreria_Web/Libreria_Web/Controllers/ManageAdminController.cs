using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Libreria_Web.Controllers
{
    public class ManageAdminController : Controller
    {
        // GET: ManageAdmin
        public ActionResult IndexAdmin()
        {
            return View();
        }
      
        public ActionResult GraficosAdmin()
        {
            return View();
        }

        public ActionResult TablasAdmin()
        {
            return View();
        }
    }
}