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
        NegUsuario accionesUsuario = new NegUsuario();

        private int v_consecutivo = 0;
        private int v_idCita = 0;

        public FRMCitas()
        {
            InitializeComponent();
            v_consecutivo = accionesCitas.consecutivoCita();
            lb_numCita.Text = v_consecutivo.ToString();
            cargarCitas();
            cargarUsuarios();
        }

        #region metodos

        public void limpiarCampos()
        {
            cbTipoServicio.Text = String.Empty;
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

                Usuario selectedUsusario = (Usuario)cbUsuario.SelectedItem;
                nuevaCita.idcita = int.Parse(lb_numCita.Text);
                nuevaCita.servicio = cbTipoServicio.Text;
                nuevaCita.fechacita = dtp_cita.Value;
                nuevaCita.idUsuario = selectedUsusario.idUsuario;

                bool insertar = accionesCitas.AgregarCita(nuevaCita);

                limpiarCampos();
                cargarCitas();

                if (insertar)
                {
                    MessageBox.Show("Cita agendada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error creando la cita ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }

        public void m_buscarCita()
        {
            int idCita = int.Parse(txtFiltroCita.Text);

            List<Cita> cita = accionesCitas.buscarCita(idCita);

            try
            {
               

                dgvCitas.DataSource = cita;

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

        
        private void FRMCitas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCita_Click_1(object sender, EventArgs e)
        {
            m_buscarCita();
        }

        public void cargarUsuarios()
        {
            List<Usuario> litaUsuarios = accionesUsuario.ListarUsuarios();
            cbUsuario.DataSource = litaUsuarios;
            cbUsuario.DisplayMember = "Nombre";
            cbUsuario.ValueMember = "IdUsuario";

        }
    }
}
