using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Threading.Tasks;

namespace Negocio
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public DateTime? Fecha_Publicacion { get; set; }
        public bool Activa { get; set; }
        public Categorias Categoria { get; set; }
        public List<Comentarios> Comentarios = new List<Comentarios>();
    }
}
