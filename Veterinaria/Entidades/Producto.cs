﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public Producto()
        {

        }

        private int idProducto;
        private string nombre;
        private decimal precio;

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string nombreProducto
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal precioProducto
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
