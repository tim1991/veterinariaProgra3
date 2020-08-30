using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegFactura
    {
        private DSFactura accionesFactura = new DSFactura();
        private DSProducto accionesProducto = new DSProducto();
        private List<DetalleVenta> listarDetalles = new List<DetalleVenta>();

        public int idFactura()
        {
            int idFactura = accionesFactura.idFactura();

            if(idFactura == 0)
            {
                idFactura = 1;
            }
            else
            {
                idFactura ++;
            }

            return idFactura;
        }

        public void agregarDetalle(DetalleVenta detalles)
        {
            listarDetalles.Add(detalles);
        }

        public List<DetalleVenta> listar()
        {
            return listarDetalles;
        }

        public decimal[] totalizar()
        {
            decimal[] totalFinal = new decimal[3];

            decimal subtotal = 0;
            decimal impuestos = 0;
            decimal total = 0;

            try
            {
                foreach (DetalleVenta item in listarDetalles)
                {
                    subtotal = subtotal + item.Subtotal;
                    impuestos = impuestos + item.Impuestos;
                    total = total + item.Total;
                }
            }
            catch (Exception)
            {

            }

            totalFinal[0] = subtotal;
            totalFinal[1] = impuestos;
            totalFinal[2] = total;

            return totalFinal;
        }

        public bool procesarFactura(Factura factura)
        {
            bool insertarDetalle = false;

            int num = accionesFactura.agregarFactura(factura);

            if (num != 0)
            {
                foreach (DetalleVenta item in listarDetalles)
                {
                    Detalles detalleFactura = new Detalles();

                    detalleFactura.Cantidad = item.Cantidad;
                    detalleFactura.IdFactura = num;
                    detalleFactura.IdProducto = item.Id;
                    detalleFactura.Subtotal = item.Subtotal;
                    detalleFactura.Impuestos = item.Impuestos;
                    detalleFactura.Total = item.Total;

                    insertarDetalle = accionesFactura.agregarDetalle(detalleFactura);
                }
            }
            return insertarDetalle;
        }

        public Producto BuscarProducto(int codigo)
        {
            Producto producto = new Producto();

            producto = accionesProducto.buscar(codigo);

            return producto;
        }
    }
}
