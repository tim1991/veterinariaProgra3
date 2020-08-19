using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegMascota
    {
        private DSMascotas accionesMascotas = new DSMascotas();

        public void AgregarMascota(Mascota mascota)
        {
            accionesMascotas.NuevaMascota(mascota);
        }
        public List<Mascota> ListarMascota()
        {
            List<Mascota> mascota = accionesMascotas.listarMascotas();

            return mascota;
        }
    }
}
