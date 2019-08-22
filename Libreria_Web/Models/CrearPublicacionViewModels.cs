using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocio;
using System.ComponentModel.DataAnnotations;


namespace Libreria_Web.Models
{
    public class CrearPublicacionViewModels
    {
        public CrearPublicacionViewModels(List<Categoria> categorias)
        {
            this.Categorias = categorias;
        }

        [Required]
        public string Nombre { get; set; }
        public List<Categoria> Categorias { get; set; }
        public string Descripcion { get; set; }
        
    }
}