using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cita
    {
        int IDCita;
        string Servicio;
        DateTime FechaCita;
        int IdUsuario;
        string NombrePersona;

        public int idcita { get => IDCita; set => IDCita = value; }
        public string servicio { get => Servicio; set => Servicio = value; }
        public DateTime fechacita { get => FechaCita; set => FechaCita = value; }
        public int idUsuario { get => IdUsuario; set => IdUsuario = value; }
        public string nombrePersona { get => NombrePersona; set => NombrePersona = value; }

    }
}
