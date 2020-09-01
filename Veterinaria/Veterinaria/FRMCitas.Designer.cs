namespace Veterinaria
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_cita = new System.Windows.Forms.DateTimePicker();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnBuscarUsuarioCita = new System.Windows.Forms.Button();
            this.txtUsuarioCita = new System.Windows.Forms.TextBox();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCita = new System.Windows.Forms.Button();
            this.txtFiltroCita = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_cita);
            this.groupBox1.Controls.Add(this.btnAgendarCita);
            this.groupBox1.Controls.Add(this.btnBuscarUsuarioCita);
            this.groupBox1.Controls.Add(this.txtUsuarioCita);
            this.groupBox1.Controls.Add(this.cbTipoServicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Cita";
            // 
            // dtp_cita
            // 
            this.dtp_cita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_cita.Location = new System.Drawing.Point(508, 14);
            this.dtp_cita.MinDate = new System.DateTime(2020, 9, 2, 0, 0, 0, 0);
            this.dtp_cita.Name = "dtp_cita";
            this.dtp_cita.Size = new System.Drawing.Size(86, 20);
            this.dtp_cita.TabIndex = 22;
            this.dtp_cita.Value = new System.DateTime(2020, 9, 2, 0, 0, 0, 0);
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Location = new System.Drawing.Point(106, 90);
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
            this.btnBuscarUsuarioCita.Location = new System.Drawing.Point(293, 18);
            this.btnBuscarUsuarioCita.Name = "btnBuscarUsuarioCita";
            this.btnBuscarUsuarioCita.Size = new System.Drawing.Size(45, 23);
            this.btnBuscarUsuarioCita.TabIndex = 21;
            this.btnBuscarUsuarioCita.Text = "...";
            this.btnBuscarUsuarioCita.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioCita
            // 
            this.txtUsuarioCita.Location = new System.Drawing.Point(106, 20);
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
            this.cbTipoServicio.Location = new System.Drawing.Point(106, 57);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cbTipoServicio.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarCita);
            this.groupBox2.Controls.Add(this.txtFiltroCita);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvCitas);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
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
            this.btnBuscarCita.Click += new System.EventHandler(this.btnBuscarCita_Click);
            // 
            // txtFiltroCita
            // 
            this.txtFiltroCita.Location = new System.Drawing.Point(63, 31);
            this.txtFiltroCita.Name = "txtFiltroCita";
            this.txtFiltroCita.Size = new System.Drawing.Size(99, 20);
            this.txtFiltroCita.TabIndex = 5;
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
            this.ClientSize = new System.Drawing.Size(630, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRMCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCitas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTipoServicio;
        private System.Windows.Forms.Button btnBuscarUsuarioCita;
        private System.Windows.Forms.TextBox txtUsuarioCita;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarCita;
        private System.Windows.Forms.TextBox txtFiltroCita;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.DateTimePicker dtp_cita;
    }
}