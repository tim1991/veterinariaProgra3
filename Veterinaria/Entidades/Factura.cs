﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura : Usuario
    {
        public Factura() { }

        private int id;
        private DateTime fecha;
        private decimal subtotal;
        private decimal impuestos;
        private decimal total;
        private string metodoPago;
        private int idUsuario;
        private int idProducto;

        public int Id { get => id; set => id = value; }

        public DateTime Fecha { get => fecha; set => fecha = value; }

        public decimal Subtotal { get => subtotal; set => subtotal = value; }

        public decimal Impuestos { get => impuestos; set => impuestos = value; }

        public decimal Total { get => total; set => total = value; }

        public string MetodoPago { get => metodoPago; set => metodoPago = value; }

        public int IDUsuario { get => idUsuario; set => idUsuario = value; }

        public int ISProducto { get => idProducto; set => idProducto = value; }
    }
}
