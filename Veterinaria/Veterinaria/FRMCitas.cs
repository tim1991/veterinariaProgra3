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
    public partial class FRMCitas : Form
    {
        NegCita accionesCitas = new NegCita();
        public FRMCitas()
        {
            InitializeComponent();
            cargarCitas();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            Cita nuevaCita = new Cita();

            try
            {
                nuevaCita.fechacita = dtpFechaCita.Value;
                nuevaCita.idUsuario = int.Parse(txtUsuarioCita.Text);
                nuevaCita.servicio = cbTipoServicio.SelectedItem.ToString();
                accionesCitas.AgregarCita(nuevaCita);
                limpiarCampos();
                cargarCitas();
                MessageBox.Show("Cita agendada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }

        public void limpiarCampos()
        {
            cbTipoServicio.Text = String.Empty;
            dtpFechaCita.Text = String.Empty;
            txtUsuarioCita.Text = String.Empty;
        }

        public void cargarCitas()
        {
            List<Cita> listarCitas = accionesCitas.ListarCita();
            dgvCitas.DataSource = listarCitas;
        }
    }
}
