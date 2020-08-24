using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalles
    {
        public Detalles() { }

        private int id;
        private int cantidad;
        private decimal subtotal;
        private decimal impuestos;
        private decimal total;
        private int idProducto;
        private int idFactura;

        public int Id { get => id; set => id = value; }

        public int Cantidad { get => cantidad; set => cantidad = value; }

        public decimal Subtotal { get => subtotal; set => subtotal = value; }

        public decimal Impuestos { get => impuestos; set => impuestos = value; }

        public decimal Total { get => total; set => total = value; }

        public int IdProducto { get => idProducto; set => idProducto = value; }

        public int IdFactura { get => idFactura; set => idFactura = value; }
    }
}
