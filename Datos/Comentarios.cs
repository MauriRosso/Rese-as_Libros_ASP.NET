//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comentarios
    {
        public int Id { get; set; }
        public string IdUsuario { get; set; }
        public string Descripcion { get; set; }
        public int IdPublicacion { get; set; }
        public Nullable<System.DateTime> Fecha_Comentario { get; set; }
        public bool Activo { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Publicaciones Publicaciones { get; set; }
    }
}
