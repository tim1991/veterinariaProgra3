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
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            Cita nuevaCita = new Cita();

            try
            {
                nuevaCita.idcita = int.Parse(txtIDCita.Text);
                nuevaCita.servicio = txtIDCita.Text;
                nuevaCita.fechacita = int.Parse(txtFecha.Text);
                nuevaCita.idUsuario = int.Parse(txtUsuarioCita.Text);
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
            txtIDCita.Text = String.Empty;
            cbTipoServicio.Text = String.Empty;
            txtFecha.Text = String.Empty;
            txtUsuarioCita.Text = String.Empty;
        }

        public void cargarCitas()
        {
            List<Cita> listarCitas = accionesCitas.ListarCita();
            dgvCitas.DataSource = listarCitas;
        }
    }
}
