using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVenta
    {
        public DetalleVenta() { }

        private int id;
        private string nombre;
        private decimal precio;
        private int cantidad;
        private decimal subtotal;
        private decimal impuestos;
        private decimal total;

        public int Id { get => id; set => id = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public decimal Precio { get => precio; set => precio = value; }

        public int Cantidad { get => cantidad; set => cantidad = value; }

        public decimal Subtotal { get => subtotal; set => subtotal = value; }

        public decimal Impuestos { get => impuestos; set => impuestos = value; }

        public decimal Total { get => total; set => total = value; }
    }
}
