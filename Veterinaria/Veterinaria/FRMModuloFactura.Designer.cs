namespace Veterinaria
{
    partial class FRMModuloFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.gpbPago = new System.Windows.Forms.GroupBox();
            this.rdbTarjeta = new System.Windows.Forms.RadioButton();
            this.rdbEfectivo = new System.Windows.Forms.RadioButton();
            this.lblPago = new System.Windows.Forms.Label();
            this.gpbCarritoCompras = new System.Windows.Forms.GroupBox();
            this.gpbTotalProd = new System.Windows.Forms.GroupBox();
            this.txtTotalProd = new System.Windows.Forms.TextBox();
            this.txtIVAProd = new System.Windows.Forms.TextBox();
            this.txtSubtotalProd = new System.Windows.Forms.TextBox();
            this.lbl_IVAProd = new System.Windows.Forms.Label();
            this.lblTotalProd = new System.Windows.Forms.Label();
            this.lblSubtotalProd = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lbl_IVA = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.lblBuscarProd = new System.Windows.Forms.Label();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.lbl_IdFactura = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gpbCliente.SuspendLayout();
            this.gpbPago.SuspendLayout();
            this.gpbCarritoCompras.SuspendLayout();
            this.gpbTotalProd.SuspendLayout();
            this.gpbTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.btnBuscarCliente);
            this.gpbCliente.Controls.Add(this.txtNomCliente);
            this.gpbCliente.Controls.Add(this.txtCedula);
            this.gpbCliente.Controls.Add(this.lblNomCliente);
            this.gpbCliente.Controls.Add(this.lblCedula);
            this.gpbCliente.Location = new System.Drawing.Point(12, 23);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(338, 101);
            this.gpbCliente.TabIndex = 0;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(229, 16);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(90, 40);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(76, 66);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.ReadOnly = true;
            this.txtNomCliente.Size = new System.Drawing.Size(243, 20);
            this.txtNomCliente.TabIndex = 3;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(76, 16);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(128, 20);
            this.txtCedula.TabIndex = 2;
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Location = new System.Drawing.Point(20, 69);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(44, 13);
            this.lblNomCliente.TabIndex = 1;
            this.lblNomCliente.Text = "Nombre";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(24, 19);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cédula";
            // 
            // gpbPago
            // 
            this.gpbPago.Controls.Add(this.rdbTarjeta);
            this.gpbPago.Controls.Add(this.rdbEfectivo);
            this.gpbPago.Controls.Add(this.lblPago);
            this.gpbPago.Enabled = false;
            this.gpbPago.Location = new System.Drawing.Point(12, 130);
            this.gpbPago.Name = "gpbPago";
            this.gpbPago.Size = new System.Drawing.Size(338, 87);
            this.gpbPago.TabIndex = 1;
            this.gpbPago.TabStop = false;
            // 
            // rdbTarjeta
            // 
            this.rdbTarjeta.AutoSize = true;
            this.rdbTarjeta.Location = new System.Drawing.Point(230, 41);
            this.rdbTarjeta.Name = "rdbTarjeta";
            this.rdbTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rdbTarjeta.TabIndex = 2;
            this.rdbTarjeta.TabStop = true;
            this.rdbTarjeta.Text = "Tarjeta";
            this.rdbTarjeta.UseVisualStyleBackColor = true;
            this.rdbTarjeta.CheckedChanged += new System.EventHandler(this.rdbTarjeta_CheckedChanged);
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Location = new System.Drawing.Point(140, 41);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbEfectivo.TabIndex = 1;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            this.rdbEfectivo.CheckedChanged += new System.EventHandler(this.rdbEfectivo_CheckedChanged);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(20, 25);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(85, 13);
            this.lblPago.TabIndex = 0;
            this.lblPago.Text = "Método de pago";
            // 
            // gpbCarritoCompras
            // 
            this.gpbCarritoCompras.Controls.Add(this.gpbTotalProd);
            this.gpbCarritoCompras.Controls.Add(this.btnFacturar);
            this.gpbCarritoCompras.Controls.Add(this.gpbTotal);
            this.gpbCarritoCompras.Controls.Add(this.btnAgregarProd);
            this.gpbCarritoCompras.Controls.Add(this.dgvVenta);
            this.gpbCarritoCompras.Controls.Add(this.btnBuscarProd);
            this.gpbCarritoCompras.Controls.Add(this.txtNomProd);
            this.gpbCarritoCompras.Controls.Add(this.txtCodigo);
            this.gpbCarritoCompras.Controls.Add(this.txtPrecio);
            this.gpbCarritoCompras.Controls.Add(this.txtCantidad);
            this.gpbCarritoCompras.Controls.Add(this.txtBuscarProd);
            this.gpbCarritoCompras.Controls.Add(this.lblCodigo);
            this.gpbCarritoCompras.Controls.Add(this.lblPrecio);
            this.gpbCarritoCompras.Controls.Add(this.lblCantidad);
            this.gpbCarritoCompras.Controls.Add(this.lblNomProducto);
            this.gpbCarritoCompras.Controls.Add(this.lblBuscarProd);
            this.gpbCarritoCompras.Enabled = false;
            this.gpbCarritoCompras.Location = new System.Drawing.Point(12, 223);
            this.gpbCarritoCompras.Name = "gpbCarritoCompras";
            this.gpbCarritoCompras.Size = new System.Drawing.Size(776, 291);
            this.gpbCarritoCompras.TabIndex = 2;
            this.gpbCarritoCompras.TabStop = false;
            this.gpbCarritoCompras.Text = "Carrito de Compras";
            // 
            // gpbTotalProd
            // 
            this.gpbTotalProd.Controls.Add(this.txtTotalProd);
            this.gpbTotalProd.Controls.Add(this.txtIVAProd);
            this.gpbTotalProd.Controls.Add(this.txtSubtotalProd);
            this.gpbTotalProd.Controls.Add(this.lbl_IVAProd);
            this.gpbTotalProd.Controls.Add(this.lblTotalProd);
            this.gpbTotalProd.Controls.Add(this.lblSubtotalProd);
            this.gpbTotalProd.Location = new System.Drawing.Point(653, 186);
            this.gpbTotalProd.Name = "gpbTotalProd";
            this.gpbTotalProd.Size = new System.Drawing.Size(123, 99);
            this.gpbTotalProd.TabIndex = 13;
            this.gpbTotalProd.TabStop = false;
            this.gpbTotalProd.Visible = false;
            // 
            // txtTotalProd
            // 
            this.txtTotalProd.Enabled = false;
            this.txtTotalProd.Location = new System.Drawing.Point(39, 69);
            this.txtTotalProd.Name = "txtTotalProd";
            this.txtTotalProd.Size = new System.Drawing.Size(69, 20);
            this.txtTotalProd.TabIndex = 5;
            this.txtTotalProd.Text = "0";
            this.txtTotalProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIVAProd
            // 
            this.txtIVAProd.Enabled = false;
            this.txtIVAProd.Location = new System.Drawing.Point(39, 40);
            this.txtIVAProd.Name = "txtIVAProd";
            this.txtIVAProd.Size = new System.Drawing.Size(69, 20);
            this.txtIVAProd.TabIndex = 4;
            this.txtIVAProd.Text = "0";
            this.txtIVAProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIVAProd.TextChanged += new System.EventHandler(this.txtIVAProd_TextChanged);
            // 
            // txtSubtotalProd
            // 
            this.txtSubtotalProd.Enabled = false;
            this.txtSubtotalProd.Location = new System.Drawing.Point(39, 11);
            this.txtSubtotalProd.Name = "txtSubtotalProd";
            this.txtSubtotalProd.Size = new System.Drawing.Size(69, 20);
            this.txtSubtotalProd.TabIndex = 3;
            this.txtSubtotalProd.Text = "0";
            this.txtSubtotalProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_IVAProd
            // 
            this.lbl_IVAProd.AutoSize = true;
            this.lbl_IVAProd.Location = new System.Drawing.Point(9, 43);
            this.lbl_IVAProd.Name = "lbl_IVAProd";
            this.lbl_IVAProd.Size = new System.Drawing.Size(24, 13);
            this.lbl_IVAProd.TabIndex = 2;
            this.lbl_IVAProd.Text = "IVA";
            // 
            // lblTotalProd
            // 
            this.lblTotalProd.AutoSize = true;
            this.lblTotalProd.Location = new System.Drawing.Point(19, 72);
            this.lblTotalProd.Name = "lblTotalProd";
            this.lblTotalProd.Size = new System.Drawing.Size(14, 13);
            this.lblTotalProd.TabIndex = 1;
            this.lblTotalProd.Text = "T";
            // 
            // lblSubtotalProd
            // 
            this.lblSubtotalProd.AutoSize = true;
            this.lblSubtotalProd.Location = new System.Drawing.Point(12, 14);
            this.lblSubtotalProd.Name = "lblSubtotalProd";
            this.lblSubtotalProd.Size = new System.Drawing.Size(21, 13);
            this.lblSubtotalProd.TabIndex = 0;
            this.lblSubtotalProd.Text = "ST";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(495, 199);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(126, 72);
            this.btnFacturar.TabIndex = 13;
            this.btnFacturar.Text = "Finalizar para comprar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // gpbTotal
            // 
            this.gpbTotal.Controls.Add(this.txtTotal);
            this.gpbTotal.Controls.Add(this.txtIVA);
            this.gpbTotal.Controls.Add(this.txtSubtotal);
            this.gpbTotal.Controls.Add(this.lbl_IVA);
            this.gpbTotal.Controls.Add(this.lblTotal);
            this.gpbTotal.Controls.Add(this.lblSubtotal);
            this.gpbTotal.Location = new System.Drawing.Point(268, 186);
            this.gpbTotal.Name = "gpbTotal";
            this.gpbTotal.Size = new System.Drawing.Size(200, 99);
            this.gpbTotal.TabIndex = 12;
            this.gpbTotal.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(74, 69);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(74, 40);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 4;
            this.txtIVA.Text = "0";
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(74, 11);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.Text = "0";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_IVA
            // 
            this.lbl_IVA.AutoSize = true;
            this.lbl_IVA.Location = new System.Drawing.Point(29, 43);
            this.lbl_IVA.Name = "lbl_IVA";
            this.lbl_IVA.Size = new System.Drawing.Size(24, 13);
            this.lbl_IVA.TabIndex = 2;
            this.lbl_IVA.Text = "IVA";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(22, 72);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(7, 14);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Enabled = false;
            this.btnAgregarProd.Location = new System.Drawing.Point(114, 237);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(90, 34);
            this.btnAgregarProd.TabIndex = 11;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(229, 28);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(541, 152);
            this.dgvVenta.TabIndex = 10;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(114, 30);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(90, 34);
            this.btnBuscarProd.TabIndex = 5;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // txtNomProd
            // 
            this.txtNomProd.Enabled = false;
            this.txtNomProd.Location = new System.Drawing.Point(23, 98);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(165, 20);
            this.txtNomProd.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(23, 149);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(60, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(23, 197);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(107, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(23, 245);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(60, 20);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.Location = new System.Drawing.Point(23, 44);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(60, 20);
            this.txtBuscarProd.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 133);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 181);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 229);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Location = new System.Drawing.Point(20, 82);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(44, 13);
            this.lblNomProducto.TabIndex = 1;
            this.lblNomProducto.Text = "Nombre";
            // 
            // lblBuscarProd
            // 
            this.lblBuscarProd.AutoSize = true;
            this.lblBuscarProd.Location = new System.Drawing.Point(20, 28);
            this.lblBuscarProd.Name = "lblBuscarProd";
            this.lblBuscarProd.Size = new System.Drawing.Size(85, 13);
            this.lblBuscarProd.TabIndex = 0;
            this.lblBuscarProd.Text = "Buscar producto";
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.Location = new System.Drawing.Point(429, 130);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(184, 25);
            this.lblNumFactura.TabIndex = 3;
            this.lblNumFactura.Text = "Factura número:";
            // 
            // lbl_IdFactura
            // 
            this.lbl_IdFactura.AutoSize = true;
            this.lbl_IdFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdFactura.Location = new System.Drawing.Point(619, 130);
            this.lbl_IdFactura.Name = "lbl_IdFactura";
            this.lbl_IdFactura.Size = new System.Drawing.Size(34, 25);
            this.lbl_IdFactura.TabIndex = 4;
            this.lbl_IdFactura.Text = "ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(434, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            // 
            // FRMModuloFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_IdFactura);
            this.Controls.Add(this.lblNumFactura);
            this.Controls.Add(this.gpbCarritoCompras);
            this.Controls.Add(this.gpbPago);
            this.Controls.Add(this.gpbCliente);
            this.Name = "FRMModuloFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMModuloFactura";
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbPago.ResumeLayout(false);
            this.gpbPago.PerformLayout();
            this.gpbCarritoCompras.ResumeLayout(false);
            this.gpbCarritoCompras.PerformLayout();
            this.gpbTotalProd.ResumeLayout(false);
            this.gpbTotalProd.PerformLayout();
            this.gpbTotal.ResumeLayout(false);
            this.gpbTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.GroupBox gpbPago;
        private System.Windows.Forms.GroupBox gpbCarritoCompras;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.Label lbl_IdFactura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdbTarjeta;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtNomProd;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.Label lblBuscarProd;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.GroupBox gpbTotalProd;
        private System.Windows.Forms.TextBox txtTotalProd;
        private System.Windows.Forms.TextBox txtIVAProd;
        private System.Windows.Forms.TextBox txtSubtotalProd;
        private System.Windows.Forms.Label lbl_IVAProd;
        private System.Windows.Forms.Label lblTotalProd;
        private System.Windows.Forms.Label lblSubtotalProd;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.GroupBox gpbTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lbl_IVA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.DataGridView dgvVenta;
    }
}