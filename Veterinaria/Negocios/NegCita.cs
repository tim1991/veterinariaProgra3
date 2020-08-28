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

        public void AgregarCita(Cita cita)
        {
            accionesCitas.NuevaCita(cita);
        }

        public List<Cita> ListarCita()
        {
            List<Cita> cita = accionesCitas.listarCitas();

            return cita;
        }
    }
}
