using System;
using Negocio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Libreria_Web.Controllers
{
    public class UsuariosController : Controller
    {
        private ConsultasUsuarios ConsultasUsu = new ConsultasUsuarios();
        // GET: Usuarios
        public ActionResult ObtenerUsuarios()
        {
            var model = ConsultasUsu.ObtenerUsuarios();

            return View(model);
        }

    }
}