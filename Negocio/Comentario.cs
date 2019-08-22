using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Threading.Tasks;

namespace Negocio
{
    public class Comentario
    {
        public string Id { get; set; }
        public string IdUsuario { get; set; }
        public string Descripcion { get; set; }
        public int IdPublicacion { get; set; }
        public DateTime? Fecha_Comentario { get; set; }
        public bool Activo { get; set; }
        public AspNetUsers Usuario { get; set; }
        public Publicaciones Publicacion { get; set; }
    }
}
