using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;

namespace Negocios
{
    public class NegProducto
    {
        private DSProducto accionesProducto = new DSProducto();

        public bool Agregar(Producto producto)
        {
            bool insertar = accionesProducto.InsertarProducto(producto);

            return insertar;
        }

        public bool Actualizar(Producto producto)
        {
            bool actualizar = accionesProducto.ActualizarProducto(producto);

            return actualizar;
        }

        public DataTable dtTblProducto()
        {
            DSProducto insDatos = new DSProducto();
            return insDatos.GetTblProducto();
        }
    }
}
