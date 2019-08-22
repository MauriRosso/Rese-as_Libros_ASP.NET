using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocio;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;

namespace Libreria_Web.Controllers
{
    public class AdminComentariosController : Controller
    {
        ConsultasComentarios consultasComentarios = new ConsultasComentarios();
        // GET: AdminComentarios
        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult CrearComentario(string comentario, int IdPost)
        //{
        //    ConsultasComentarios consultascomentarios = new ConsultasComentarios();
        //    var IdAutor = User.Identity.GetUserId();

        //    Comentario model = new Comentario();
        //    model.Id = IdAutor;
        //    model.Descripcion = comentario;
        //    model.Publicacion.Id = IdPost;
        //    model.IdPublicacion = IdPost;
        //    var idgenerado = consultascomentarios.CrearComentario(model);
        //    return Json(false, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult EliminarComentario(int Id)
        //{
        //    ConsultasComentarios consultascomentarios = new ConsultasComentarios();
        //    Comentario model = new Comentario();
        //    model.Id = Id;
        //    var idpost = consultascomentarios.ModificarComentario(model, true);

        //    return RedirectToAction("Details", "Posts", new { id = idpost });
        //}
    }
}