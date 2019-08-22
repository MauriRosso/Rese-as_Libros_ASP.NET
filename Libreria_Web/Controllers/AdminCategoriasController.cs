using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocio;
using System.Web.Mvc;

namespace Libreria_Web.Controllers
{
    public class AdminCategoriasController : Controller
    {
        private ConsultasCategorias consultaCategorias = new ConsultasCategorias();
        // GET: AdminCategorias
        public ActionResult Index()
        {
            var model = consultaCategorias.ObtenerCategorias();
            return View(model);
        }

        // GET: AdminCategorias/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: AdminCategorias/Create
        [HttpPost]
        public ActionResult Create(Categoria model)
        {
            try
            {
                consultaCategorias.CrearCategoria(model);

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
            var model = consultaCategorias.ObtenerCategoriaPorId(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // POST: AdminCategorias/Edit
        [HttpPost]
        public ActionResult Edit(int id, Categoria model)
        {
            try
            {
                model.Id = id;
                var idGenerado = consultaCategorias.ModificarCategoria(model, false);

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
            var model = consultaCategorias.ObtenerCategoriaPorId(id);

            if (model == null)
                return RedirectToAction("Index");

            return View(model);
        }

        // POST: AdminCategorias/Delete
        [HttpPost]
        public ActionResult Delete(int id, Categoria model)
        {
            try
            {
                model.Id = id;
                var idGenerado = consultaCategorias.ModificarCategoria(model, true);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}