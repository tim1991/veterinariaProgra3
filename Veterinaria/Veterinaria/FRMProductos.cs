﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace Veterinaria
{
    public partial class FRMProductos : Form
    {
        public FRMProductos()
        {
            InitializeComponent();
        }

        private NegProducto accionesProducto = new NegProducto();

        #region Metodos

        private void Limpiar()
        {
            this.txbNombre.Text = "";
            this.txbPrecio.Text = "";
            this.txbStock.Text = "";
        }

        private bool validar()
        {
            if (txbNombre.Text != String.Empty && txbPrecio.Text != String.Empty && txbStock.Text != String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Agregar()
        {
            try
            {
                if (validar())
                {
                    Producto nuevo = new Producto();

                    nuevo.nombreProducto = txbNombre.Text;
                    nuevo.precioProducto = int.Parse(txbPrecio.Text);
                    nuevo.stockProducto = int.Parse(txbStock.Text);

                    bool insertar = accionesProducto.Agregar(nuevo);

                    if (insertar)
                    {
                        MessageBox.Show("Producto agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Todos los espacios deben llenarse\nVerificar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar los datos\nVerifique la información", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Limpiar();
        }

        private void Actualizar()
        {
            try
            {
                if (validar())
                {
                    Producto actualizar = new Producto();

                    actualizar.nombreProducto = txbNombre.Text;
                    actualizar.precioProducto = int.Parse(txbPrecio.Text);
                    actualizar.stockProducto = int.Parse(txbStock.Text);

                    bool update = accionesProducto.Actualizar(actualizar);

                    if (update)
                    {
                        MessageBox.Show("Producto actualizado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                        cargarProductos();
                    }
                }
                else
                {
                    MessageBox.Show("Error al actualizar\nVerifique la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar los datos\nVerifique la información", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Limpiar();
        }

        public void cargarProductos()
        {
            NegProducto listProducto = new NegProducto();
            dgvBuscar.DataSource = listProducto.dtTblProducto();
        }

        private void selecDatos()
        {
            txbNombre.Text = this.dgvBuscar.CurrentRow.Cells[1].Value.ToString();
            txbPrecio.Text = this.dgvBuscar.CurrentRow.Cells[2].Value.ToString();
            txbStock.Text = this.dgvBuscar.CurrentRow.Cells[3].Value.ToString();
        }

        #endregion

        private void btnVer_Click(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selecDatos();
        }
    }
}
