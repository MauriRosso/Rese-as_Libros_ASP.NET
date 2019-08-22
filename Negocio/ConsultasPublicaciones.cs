using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConsultasPublicaciones
    {
        public List<Publicacion> ObtenerPublicaciones()
        {
            LibreriaDBEntities contexto = new LibreriaDBEntities();
            var publicaciones = contexto.Publicaciones;
            List<Publicacion> resultado = new List<Publicacion>();

            foreach (var item in publicaciones.ToList())
            {
                resultado.Add(new Publicacion()
                {
                    Id = item.Id,
                    Nombre = item.Nombre,
                    Descripcion = item.Descripcion,
                    IdCategoria = item.IdCategoria,
                    Fecha_Publicacion = item.Fecha_Publicacion,
                    Activa = item.Activa,
                    Comentarios = item.Comentarios.Where(x => x.IdPublicacion == item.Id).ToList(),
                    Categoria = item.Categorias
                });
            }
            return resultado;
        }

        public Publicacion ObtenerPublicacionPorId(int id)
        {
            LibreriaDBEntities contexto = new LibreriaDBEntities();
            var publicacion = contexto.Publicaciones.Where(x => x.Id == id).FirstOrDefault();
            Publicacion resultado = (publicacion == null) ? null : new Publicacion()
            {
                Id = publicacion.Id,
                Nombre = publicacion.Nombre,
                Descripcion = publicacion.Descripcion,
                Fecha_Publicacion = publicacion.Fecha_Publicacion,
                IdCategoria = publicacion.IdCategoria,
                Activa = publicacion.Activa,
                Comentarios = publicacion.Comentarios.Where(x => x.IdPublicacion == publicacion.Id).ToList(),
                Categoria = publicacion.Categorias
            };

            return resultado;
        }

        public void CrearPublicacion(Publicacion model)
        {
            LibreriaDBEntities contexto = new LibreriaDBEntities();
            Publicaciones nuevaPublicacion = new Publicaciones();

            nuevaPublicacion.Nombre = model.Nombre;
            nuevaPublicacion.Descripcion = model.Descripcion;
            nuevaPublicacion.Categorias = model.Categoria;
            nuevaPublicacion.IdCategoria = model.Categoria.Id; //Borrar campo!!!
            nuevaPublicacion.Fecha_Publicacion = DateTime.Now;
            nuevaPublicacion.Activa = true;

            contexto.Publicaciones.Add(nuevaPublicacion);
            contexto.SaveChanges();
        }

        public int ModificarPublicacion(Publicacion model, bool eliminar)
        {
            LibreriaDBEntities contexto = new LibreriaDBEntities();

            Publicaciones publicacionActual = contexto.Publicaciones.Where(x => x.Id == model.Id).SingleOrDefault();

            if (publicacionActual != null)
            {
                if (eliminar)
                    publicacionActual.Activa = false;
                else
                {
                    publicacionActual.Nombre = model.Nombre;
                    publicacionActual.Descripcion = model.Descripcion;
                    publicacionActual.Categorias = model.Categoria;
                    publicacionActual.Activa = model.Activa;
                }

                contexto.SaveChanges();
            }

            return model.Id;
        }

    }
}
