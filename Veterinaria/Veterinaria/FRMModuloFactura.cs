using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Veterinaria
{
    public partial class FRMModuloFactura : Form
    {
        private NegFactura accionesFactura = new NegFactura();
        private NegUsuario accionesUsuario = new NegUsuario();
        private Producto producto = new Producto();

        private int idFactura = 0;
        private decimal subtotal = 0;
        private decimal impuestos = 0;
        private decimal total = 0;
        private int idUsuario = 0;
        private string nomUsuario = "";

        public FRMModuloFactura()
        {
            InitializeComponent();

            txtCedula.Focus();
            txtCantidad.Text = "1";

            idFactura = accionesFactura.idFactura();
            lbl_IdFactura.Text = "" + idFactura.ToString();
            bloquearCampos();
        }

        #region Metodos buscar
        public void buscarUsuario()
        {
            try
            {
                int cedula = int.Parse(txtCedula.Text);

                Usuario usuario = accionesUsuario.BuscarUsuario(cedula);

                if (usuario != null)
                {
                    idUsuario = usuario.idUsuario;
                    nomUsuario = usuario.nombre + " " + usuario.apellidos;

                    txtNomCliente.Text = nomUsuario;

                    gpbPago.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCedula.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número de cédula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtCedula.Focus();
        }

        public void buscarProducto()
        {
            try
            {
                int codigo = int.Parse(txtBuscarProd.Text);
                producto = accionesFactura.BuscarProducto(codigo);

                if (producto != null)
                {
                    calcularMontos(producto);
                    txtCantidad.Enabled = true;
                    btnAgregarProd.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El artículo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantidad.Enabled = false;
                    btnAgregarProd.Enabled = false;

                    limpiarCampos();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese el código de un artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                limpiarCampos();
            }
        }

        #endregion

        #region Metodos factura

        public void calcularMontos(Producto producto)
        {
            try
            {
                if (rdbEfectivo.Checked == true)
                {
                    txtIVAProd.Text = "13";

                    decimal impuestos = decimal.Parse(txtIVAProd.Text);
                    decimal cantidad = decimal.Parse(txtCantidad.Text);
                    decimal precio = producto.precioProducto;
                    decimal subtotal = producto.precioProducto * cantidad;
                    decimal impuesto = subtotal * (impuestos / 100);
                    decimal total = subtotal + impuesto;

                    txtCantidad.Text = cantidad.ToString();
                    txtCodigo.Text = producto.IdProducto.ToString();
                    txtNomProd.Text = producto.nombreProducto;
                    txtIVAProd.Text = impuestos.ToString();
                    txtPrecio.Text = producto.precioProducto.ToString();
                    txtSubtotalProd.Text = subtotal.ToString();
                    txtTotalProd.Text = total.ToString();
                }
                else if (rdbTarjeta.Checked == true)
                {
                    txtIVAProd.Text = "20";

                    decimal impuestos = decimal.Parse(txtIVAProd.Text);
                    decimal cantidad = decimal.Parse(txtCantidad.Text);
                    decimal precio = producto.precioProducto;
                    decimal subtotal = producto.precioProducto * cantidad;
                    decimal impuesto = subtotal * (impuestos / 100);
                    decimal total = subtotal + impuesto;

                    txtCantidad.Text = cantidad.ToString();
                    txtCodigo.Text = producto.IdProducto.ToString();
                    txtNomProd.Text = producto.nombreProducto;
                    txtIVAProd.Text = impuestos.ToString();
                    txtPrecio.Text = producto.precioProducto.ToString();
                    txtSubtotalProd.Text = subtotal.ToString();
                    txtTotalProd.Text = total.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void limpiarCampos()
        {
            this.txtBuscarProd.Text = "";
            this.txtCodigo.Text = "";
            this.txtNomProd.Text = "";
            this.txtPrecio.Text = "";
            this.txtCantidad.Text = "1";
            this.txtSubtotalProd.Text = "";
            this.txtIVAProd.Text = "";
            this.txtTotalProd.Text = "";

            //producto = null;
        }


        private void bloquearCampos()
        {
            this.txtCodigo.Enabled = false;
            this.txtNomProd.Enabled = false;
            this.txtPrecio.Enabled = false;
            this.txtCantidad.Text = "1";
            this.txtSubtotalProd.Enabled = false;
            this.txtIVAProd.Enabled = false;
            this.txtTotalProd.Enabled = false;

            //producto = null;
        }

        public void agregarProducto()
        {
            DetalleVenta detalles = new DetalleVenta();

            decimal impuesto = Decimal.Parse(txtSubtotalProd.Text) * (Decimal.Parse(txtIVAProd.Text) / 100);

            try
            {
                detalles.Id = int.Parse(txtCodigo.Text);
                detalles.Nombre = txtNomProd.Text;
                detalles.Precio = Decimal.Parse(txtPrecio.Text);
                detalles.Cantidad = int.Parse(txtCantidad.Text);
                detalles.Subtotal = Decimal.Parse(txtSubtotalProd.Text);
                detalles.Impuestos = impuesto;
                detalles.Total = Decimal.Parse(txtTotalProd.Text);
                accionesFactura.agregarDetalle(detalles);

                cargarDetalles();
            }
            catch (Exception ex)
            {

            }

            txtCantidad.Enabled = false;
            btnAgregarProd.Enabled = false;
            txtBuscarProd.Focus();

            limpiarCampos();
        }

        public void cargarDetalles()
        {
            List<DetalleVenta> detallesVenta = accionesFactura.listar();
            dgvVenta.DataSource = null;
            dgvVenta.DataSource = detallesVenta;
            dgvVenta.Refresh();

            totalizar();
        }

        public void totalizar()
        {
            decimal[] totales = new decimal[3];

            totales = accionesFactura.totalizar();

            subtotal = totales[0];
            impuestos = totales[1];
            total = totales[2];

            txtSubtotal.Text = subtotal.ToString("#.##");
            txtIVA.Text = impuestos.ToString("#.##");
            txtTotal.Text = total.ToString("#.##");
        }

        public void realizarCompra()
        {
            Factura factura = new Factura();

            if (rdbEfectivo.Checked == true)
            {
                int usuario = idUsuario;
                factura.Fecha = DateTime.Now;
                factura.idUsuario = usuario;
                factura.MetodoPago = "Efectivo";
                factura.Subtotal = subtotal;
                factura.Impuestos = impuestos;
                factura.Total = total;
                factura.Id = idFactura;
            }
            else if (rdbTarjeta.Checked == true)
            {
                factura.Fecha = DateTime.Now;
                factura.idUsuario = idUsuario;
                factura.MetodoPago = "Tarjeta";
                factura.Subtotal = subtotal;
                factura.Impuestos = impuestos;
                factura.Total = total;
                factura.Id = idFactura;
            }

            bool insert = accionesFactura.procesarFactura(factura);

            if (insert)
            {
                idFactura = accionesFactura.idFactura();
                lblNumFactura.Text = "" + idFactura.ToString();
                txtNomCliente.Text = "";
                txtCedula.Text = "";
                Reporte reporte = new Reporte(factura.Id);
                reporte.Show();
                MessageBox.Show("Compra Exitosa.", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarDetalles();
                this.Close();
            }
            else
            {
                MessageBox.Show("¡Ha ocurrido un error! \n\n" +
                "Verifique que la cédula y el nombre son correctos, \n" +
                "que haya escogido un método de pago y que en el \n" +
                "carrito de compras haya al menos un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //FacturaVenta factVenta = new FacturaVenta(idFactura);
            //factVenta.ShowDialog();
        }

        #endregion

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            buscarUsuario();
        }

        private void rdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            gpbCarritoCompras.Enabled = true;
            gpbCliente.Enabled = false;
            gpbPago.Enabled = false;
            txtBuscarProd.Focus();
        }

        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            gpbCarritoCompras.Enabled = true;
            gpbCliente.Enabled = false;
            gpbPago.Enabled = false;
            txtBuscarProd.Focus();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            buscarProducto();
          
        }

        private void txtIVAProd_TextChanged(object sender, EventArgs e)
        {
            calcularMontos(producto);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            realizarCompra();
        }

      

        private void btnAgregarProd_Click_1(object sender, EventArgs e)
        {
            agregarProducto();
            limpiarCampos();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            calcularMontos(producto);
        }

        private void FRMModuloFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
