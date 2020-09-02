using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegCita
    {
        private DSCitas accionesCitas = new DSCitas();

        public int consecutivoCita()
        {
            int conse = accionesCitas.ConsecutivoCita();
            conse = conse + 1;

            return conse;
        }

        public bool AgregarCita(Cita cita)
        {
           return  accionesCitas.NuevaCita(cita);
        }

        public List<Cita> ListarCita()
        {
            List<Cita> cita = accionesCitas.listarCitas();

            return cita;
        }

        public Cita buscarCita(int idCita)
        {
            return accionesCitas.BuscarCita(idCita);
        }
    }
}
