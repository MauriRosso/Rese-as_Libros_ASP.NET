using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocio;
using Datos;
using Libreria_Web.Models;
using System.Web.Mvc;

namespace Libreria_Web.Controllers
{
    public class AdminPublicacionesController : Controller
    {
        private ConsultasPublicaciones consultaPublicaciones = new ConsultasPublicaciones();
        private ConsultasCategorias consultaCategorias = new ConsultasCategorias();
        // GET: AdminPublicaciones
        public ActionResult Index()
        {
            var model = consultaPublicaciones.ObtenerPublicaciones();
            return View(model);
        }

        // GET: AdminPublicaciones/Create
        public ActionResult Create()
        {
            List<Categoria> categorias = new List<Categoria>();
            categorias = consultaCategorias.ObtenerCategorias();
            //Publicacion viewModel = new Publicacion (categorias);

            ViewBag.Categorias = categorias;

            return View();
        }
        // POST: AdminPublicaciones/Create
        [HttpPost]
        public ActionResult Create(Publicacion model)
        {
            //Categoria Categoria = consultaCategorias.ObtenerCategoriaPorId(model.Categoria.Id);
            //model.Categoria.Nombre = Categoria.Nombre.Trim();
            //model.Categoria.Activa = Categoria.Activa;
            //model.Categoria.Visitas = Categoria.Visitas;

            try
            {
                consultaPublicaciones.CrearPublicacion(model);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        //GET: AdminCategorias/Edit
        public ActionResult Edit(int id)
        {
            var model = consultaPublicaciones.ObtenerPublicacionPorId(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // POST: AdminCategorias/Edit
        [HttpPost]
        public ActionResult Edit(int id, Publicacion model)
        {
            try
            {
                model.Id = id;
                var idGenerado = consultaPublicaciones.ModificarPublicacion(model, false);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminCategorias/Delete
        public ActionResult Delete(int id)
        {
            var model = consultaPublicaciones.ObtenerPublicacionPorId(id);

            if (model == null)
                return RedirectToAction("Index");

            return View(model);
        }

        // POST: AdminCategorias/Delete
        [HttpPost]
        public ActionResult Delete(int id, Publicacion model)
        {
            try
            {
                model.Id = id;
                var idGenerado = consultaPublicaciones.ModificarPublicacion(model, true);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}