using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        int IdUsuario;
        string Email;
        string Contrasena;
        int Rol;

        public int idUsuario { get => IdUsuario; set => IdUsuario = value; }
        public string email { get => Email; set => Email = value; }
        public string contrasena { get => Contrasena; set => Contrasena = value; }
        public int rol { get => Rol; set => Rol = value; }
    }
}
