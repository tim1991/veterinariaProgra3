﻿namespace Veterinaria
{
    partial class FRMCitas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnBuscarUsuarioCita = new System.Windows.Forms.Button();
            this.txtUsuarioCita = new System.Windows.Forms.TextBox();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtIDCita = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCita = new System.Windows.Forms.Button();
            this.txtFiltroMascotas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cita N°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgendarCita);
            this.groupBox1.Controls.Add(this.btnBuscarUsuarioCita);
            this.groupBox1.Controls.Add(this.txtUsuarioCita);
            this.groupBox1.Controls.Add(this.cbTipoServicio);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtIDCita);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(35, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Cita";
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Location = new System.Drawing.Point(384, 80);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(142, 23);
            this.btnAgendarCita.TabIndex = 4;
            this.btnAgendarCita.Text = "Agendar cita";
            this.btnAgendarCita.UseVisualStyleBackColor = true;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnBuscarUsuarioCita
            // 
            this.btnBuscarUsuarioCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuarioCita.Location = new System.Drawing.Point(249, 80);
            this.btnBuscarUsuarioCita.Name = "btnBuscarUsuarioCita";
            this.btnBuscarUsuarioCita.Size = new System.Drawing.Size(45, 23);
            this.btnBuscarUsuarioCita.TabIndex = 21;
            this.btnBuscarUsuarioCita.Text = "...";
            this.btnBuscarUsuarioCita.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioCita
            // 
            this.txtUsuarioCita.Location = new System.Drawing.Point(62, 82);
            this.txtUsuarioCita.Name = "txtUsuarioCita";
            this.txtUsuarioCita.Size = new System.Drawing.Size(171, 20);
            this.txtUsuarioCita.TabIndex = 20;
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Items.AddRange(new object[] {
            "Veterinaria",
            "Compra"});
            this.cbTipoServicio.Location = new System.Drawing.Point(281, 28);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cbTipoServicio.TabIndex = 1;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(480, 28);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 3;
            // 
            // txtIDCita
            // 
            this.txtIDCita.Location = new System.Drawing.Point(62, 28);
            this.txtIDCita.Name = "txtIDCita";
            this.txtIDCita.Size = new System.Drawing.Size(100, 20);
            this.txtIDCita.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarCita);
            this.groupBox2.Controls.Add(this.txtFiltroMascotas);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvCitas);
            this.groupBox2.Location = new System.Drawing.Point(35, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 377);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Citas";
            // 
            // btnBuscarCita
            // 
            this.btnBuscarCita.Location = new System.Drawing.Point(196, 29);
            this.btnBuscarCita.Name = "btnBuscarCita";
            this.btnBuscarCita.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCita.TabIndex = 6;
            this.btnBuscarCita.Text = "Buscar";
            this.btnBuscarCita.UseVisualStyleBackColor = true;
            // 
            // txtFiltroMascotas
            // 
            this.txtFiltroMascotas.Location = new System.Drawing.Point(63, 31);
            this.txtFiltroMascotas.Name = "txtFiltroMascotas";
            this.txtFiltroMascotas.Size = new System.Drawing.Size(99, 20);
            this.txtFiltroMascotas.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "N° cita";
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(18, 76);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(550, 283);
            this.dgvCitas.TabIndex = 19;
            // 
            // FRMCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRMCitas";
            this.Text = "FRMCitas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtIDCita;
        private System.Windows.Forms.ComboBox cbTipoServicio;
        private System.Windows.Forms.Button btnBuscarUsuarioCita;
        private System.Windows.Forms.TextBox txtUsuarioCita;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarCita;
        private System.Windows.Forms.TextBox txtFiltroMascotas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCitas;
    }
}