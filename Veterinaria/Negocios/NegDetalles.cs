using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocios
{
    public class NegDetalles
    {
        private DSProducto accionesProducto = new DSProducto();

        public DataTable dtTblDetalle()
        {
            DSDetalle insDetalles = new DSDetalle();

            return insDetalles.getTblDetalle();
        }
    }
}
