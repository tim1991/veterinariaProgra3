using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        int Cedula;
        string Nombre;
        string Apellidos;
        int Telefono;
        string Direccion;

        public int cedula { get => Cedula; set => Cedula = value; }
        public string nombre { get => Nombre; set => Nombre = value; }
        public string apellidos { get => Apellidos; set => Apellidos = value; }
        public int telefono { get => Telefono; set => Telefono = value; }
        public string direccion { get => Direccion; set => Direccion = value; }
    }
}
