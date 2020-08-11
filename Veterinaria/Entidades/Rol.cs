using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rol
    {

        int IdRol;
        string Detalle;

        public int idRol { get => IdRol; set => IdRol = value; }
        public string detalle { get => Detalle; set => Detalle = value; }
    }
}
