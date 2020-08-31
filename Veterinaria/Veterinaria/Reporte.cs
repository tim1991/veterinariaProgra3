using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class Reporte : Form
    {
        private int idFactura;
        public Reporte(int id )
        {
            idFactura = id;
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'MundoAnimaliaDataSet.selectDetalles' Puede moverla o quitarla según sea necesario.
            this.selectDetallesTableAdapter.Fill(this.MundoAnimaliaDataSet.selectDetalles, idFactura);
            // TODO: esta línea de código carga datos en la tabla 'MundoAnimaliaDataSet.selectIdFactura' Puede moverla o quitarla según sea necesario.
            this.selectIdFacturaTableAdapter.Fill(this.MundoAnimaliaDataSet.selectIdFactura, idFactura);

            this.reportViewer1.RefreshReport();
        }
    }
}
