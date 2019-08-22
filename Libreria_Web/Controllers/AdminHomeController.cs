using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Libreria_Web.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: ManageAdmin
        public ActionResult IndexAdmin()
        {
            return View();
        }
    }
}