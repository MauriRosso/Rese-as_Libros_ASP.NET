using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConsultasComentarios
    {
        public List<Comentario> ObtenerComentarios()
        {
            LibreriaDBEntities contexto = new LibreriaDBEntities();
            var comentarios = contexto.Comentarios;
            List<Comentario> resultado = new List<Comentario>();
            foreach (var item in comentarios.ToList())
            {
                resultado.Add(new Comentario()
                {
                    IdUsuario = item.IdUsuario,
                    Descripcion = item.Descripcion,
                    IdPublicacion = item.IdPublicacion,
                    Fecha_Comentario = item.Fecha_Comentario,
                    Activo = item.Activo,
                    Usuario = item.AspNetUsers,
                    Publicacion = item.Publicaciones
                });
            }
            return resultado;
        }
    }
}
