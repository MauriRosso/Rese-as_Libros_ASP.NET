using System;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class ConsultasUsuarios
    {
        public List<Usuarios> ObtenerUsuarios()
        {
            LibreriaDBEntities contexto = new LibreriaDBEntities();
            var usuarios = contexto.Usuarios.Where(x => x.Activo == "true"); //Cambiar BD y poner bool
            List<Usuarios> resultado = new List<Usuarios>();
            foreach (var item in usuarios.ToList())
            {
                resultado.Add(new Usuarios()
                {
                    IdUsuario = item.IdUsuario,
                    //TipoCliente = item.IdTipoCliente.HasValue ? item.TiposClientes.Nombre : "",
                    Nombre = item.Nombre,
                    Email = item.Email,
                    Contrasena = item.Contrasena,
                    Fecha_Registro = item.Fecha_Registro,
                    Activo = item.Activo,
                    Rol = item.Rol,
                    Publicaciones = item.Publicaciones 
                });
            }

            return resultado;
        }
    }
}
