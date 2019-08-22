using System;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConsultasCategorias
    {
        public List<Categoria> ObtenerCategorias()
        {
            LibreriaDBEntities contexto = new LibreriaDBEntities();
            var categorias = contexto.Categorias;
            List<Categoria> resultado = new List<Categoria>();
            foreach (var item in categorias.ToList())
            {
                resultado.Add(new Categoria()
                {
                    Id = item.Id,
                    Nombre = item.Nombre.Trim(),
                    Visitas = item.Visitas,
                    Activa = item.Activa
                });
            }
            return resultado;
        }

        public Categoria ObtenerCategoriaPorId(int id)
        {
            LibreriaDBEntities contexto = new LibreriaDBEntities();
            var categoria = contexto.Categorias.Where(x => x.Id == id).SingleOrDefault();
            Categoria resultado = (categoria == null) ? null : new Categoria()
            {
                Id = categoria.Id,
                Nombre = categoria.Nombre,
                Visitas = categoria.Visitas,
                Activa = categoria.Activa
            };

            return resultado;
        }

        public void CrearCategoria(Categoria model)
        {
            LibreriaDBEntities contexto = new LibreriaDBEntities();
            Categorias nuevaCategoria = new Categorias();

            nuevaCategoria.Nombre = model.Nombre;
            nuevaCategoria.Visitas = 0;
            nuevaCategoria.Activa = true;

            contexto.Categorias.Add(nuevaCategoria);
            contexto.SaveChanges();
        }

        public int ModificarCategoria(Categoria model, bool eliminar)
        {
            LibreriaDBEntities contexto = new LibreriaDBEntities();

            Categorias categoriaActual = contexto.Categorias.Where(x => x.Id == model.Id).SingleOrDefault();

            if (categoriaActual != null)
            {
                if (eliminar)
                    categoriaActual.Activa = false;
                else
                {
                    categoriaActual.Nombre = model.Nombre;
                }

                contexto.SaveChanges();
            }

            return model.Id;
        }
    }
}
