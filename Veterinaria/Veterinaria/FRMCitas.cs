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

        private int v_consecutivo = 0;
        private int v_idCita = 0;

        public FRMCitas()
        {
            InitializeComponent();
            v_consecutivo = accionesCitas.consecutivoCita();
            lb_numCita.Text = v_consecutivo.ToString();
        }

        #region metodos

        public void limpiarCampos()
        {
            cbTipoServicio.Text = String.Empty;
            txtUsuarioCita.Text = String.Empty;
        }

        public void cargarCitas()
        {
            List<Cita> listarCitas = accionesCitas.ListarCita();
            dgvCitas.DataSource = listarCitas;
        }

        public void m_agendarCita()
        {
            Cita nuevaCita = new Cita();

            try
            {
                nuevaCita.idcita = int.Parse(lb_numCita.Text);
                nuevaCita.servicio = cbTipoServicio.Text;
                nuevaCita.fechacita = dtp_cita.Value;
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

        public void m_buscarCita()
        {
            int idCita = int.Parse(txtFiltroCita.Text);

            Cita cita = accionesCitas.buscarCita();

            try
            {
                v_idCita = cita.idUsuario;

                //dgvCitas.DataSource = buscarCita;

            }
            catch (Exception error)
            {
                throw error;
            }
        }

        #endregion metodos

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            m_agendarCita();
        }

        private void btnBuscarCita_Click(object sender, EventArgs e)
        {
            m_buscarCita();
        }
    }
}
