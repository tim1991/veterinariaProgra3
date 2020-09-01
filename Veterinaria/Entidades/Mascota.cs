using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        int IdMascota;
        string NombreMascota;
        string Especie;
        string Raza;
        DateTime Nacimiento;
        string Genero;
        int IdUsuario;

        public int idmascota { get => IdMascota; set => IdMascota = value; }
        public string nombremascota { get => NombreMascota; set => NombreMascota = value; }
        public string especie { get => Especie; set => Especie = value; }
        public string raza { get => Raza; set => Raza = value; }
        public DateTime nacimiento { get => Nacimiento; set => Nacimiento = value; }
        public string genero { get => Genero; set => Genero = value; }
        public int idUsuario { get => IdUsuario; set => IdUsuario = value; }
    }
}
