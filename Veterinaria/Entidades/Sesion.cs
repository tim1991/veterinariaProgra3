using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sesion
    {

        string Nombre;
        int IdRol;
        string NombreRol;

        public string nombre { get => Nombre; set => Nombre = value; }
        public int idRol { get => IdRol; set => IdRol = value; }
        public string nombreRol { get => NombreRol; set => NombreRol = value; }
    }
}
