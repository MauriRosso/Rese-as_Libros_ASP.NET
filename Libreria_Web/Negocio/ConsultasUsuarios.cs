using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConsultasUsuarios
    {
        public List<Usuario> ObtenerUsuarios()
        {
            LibreriaDBEntities contexto = new LibreriaDBEntities();
            var usuarios = contexto.AspNetUsers.Where(x => x.Activo == true);
            List<Usuario> resultado = new List<Usuario>();
            foreach (var item in usuarios.ToList())
            {
                resultado.Add(new Usuario()
                {
                    Id = item.Id,
                    Email = item.Email,
                    EmailConfirmed = item.EmailConfirmed,
                    PasswordHash = item.PasswordHash,
                    SecurityStamp = item.SecurityStamp,
                    PhoneNumber = item.PhoneNumber,
                    PhoneNumberConfirmed = item.PhoneNumberConfirmed,
                    TwoFactorEnabled = item.TwoFactorEnabled,
                    LockoutEndDateUtc = item.LockoutEndDateUtc,
                    LockoutEnabled = item.LockoutEnabled,
                    AccessFailedCount = item.AccessFailedCount,
                    UserName = item.UserName,
                    Activo = item.Activo,
                    Alias = item.Alias,
                    FechaRegistro = item.FechaRegistro
                });
            }

            return resultado;
        }
    }
}

//TipoCliente = item.IdTipoCliente.HasValue ? item.TiposClientes.Nombre : "", --> Usar para campos nulleables.
