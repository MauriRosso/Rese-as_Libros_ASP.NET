using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocio;
using System.Web.Mvc;

namespace Libreria_Web.Controllers
{
    public class PublicacionController : Controller
    {
        private ConsultasPublicaciones consultasPublicaciones  = new ConsultasPublicaciones();
        private ConsultasUsuarios consultasUsuarios = new ConsultasUsuarios();
        private ConsultasComentarios ConsultasComentarios = new ConsultasComentarios();
        // GET: Publicacion
        public ActionResult Index(int id)
        {
            var model = consultasPublicaciones.ObtenerPublicacionPorId(id);
            
            return View(model);
        }

    }
}