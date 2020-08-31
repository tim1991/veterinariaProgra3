namespace Veterinaria
{
    partial class Reporte
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.selectDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MundoAnimaliaDataSet = new Veterinaria.MundoAnimaliaDataSet();
            this.selectDetallesTableAdapter = new Veterinaria.MundoAnimaliaDataSetTableAdapters.selectDetallesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.selectIdFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectIdFacturaTableAdapter = new Veterinaria.MundoAnimaliaDataSetTableAdapters.selectIdFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.selectDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MundoAnimaliaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectIdFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // selectDetallesBindingSource
            // 
            this.selectDetallesBindingSource.DataMember = "selectDetalles";
            this.selectDetallesBindingSource.DataSource = this.MundoAnimaliaDataSet;
            // 
            // MundoAnimaliaDataSet
            // 
            this.MundoAnimaliaDataSet.DataSetName = "MundoAnimaliaDataSet";
            this.MundoAnimaliaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectDetallesTableAdapter
            // 
            this.selectDetallesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.selectDetallesBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.selectIdFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Veterinaria.Factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // selectIdFacturaBindingSource
            // 
            this.selectIdFacturaBindingSource.DataMember = "selectIdFactura";
            this.selectIdFacturaBindingSource.DataSource = this.MundoAnimaliaDataSet;
            // 
            // selectIdFacturaTableAdapter
            // 
            this.selectIdFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MundoAnimaliaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectIdFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource selectDetallesBindingSource;
        private MundoAnimaliaDataSet MundoAnimaliaDataSet;
        private MundoAnimaliaDataSetTableAdapters.selectDetallesTableAdapter selectDetallesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource selectIdFacturaBindingSource;
        private MundoAnimaliaDataSetTableAdapters.selectIdFacturaTableAdapter selectIdFacturaTableAdapter;
    }
}