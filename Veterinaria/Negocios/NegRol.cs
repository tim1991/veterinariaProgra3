using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegRol
    {

        private DSRol accionesRol = new DSRol();

        public List<Rol> ListarRoles()
        {
            List<Rol> vloRoles = accionesRol.listarRoles();

            return vloRoles;
        }

        
    }
}
