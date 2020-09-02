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
    public partial class FRMMascotas : Form
    {
        NegMascota accionesMascotas = new NegMascota();
        NegUsuario accionesUsuario = new NegUsuario();

        private int v_idMascota = 0;

        public FRMMascotas()
        {
            InitializeComponent();
            cargarMascotas();
            cargarUsuarios();
        }

        #region metodos

        public void limpiarCampos()
        {
            txtFiltroMascotas.Text = String.Empty;
            txtIDMascota.Text = String.Empty;
            txtNombreMascota.Text = String.Empty;
            txtEspecie.Text = String.Empty;
            txtRaza.Text = String.Empty;
            dtpNacimiento.Text = String.Empty;
            cbGenero.Text = String.Empty;
        }

        public void cargarMascotas()
        {
            List<Mascota> listarMascotas = accionesMascotas.ListarMascota();
            dgvMascotas.DataSource = listarMascotas;
        }

        public void m_agregarMascota()
        {
            Mascota nuevaMascota = new Mascota();
            Usuario selectedUsusario = (Usuario)cbUsuario.SelectedItem;
            try
            {
                nuevaMascota.nombremascota = txtNombreMascota.Text;
                nuevaMascota.especie = txtEspecie.Text;
                nuevaMascota.raza = txtRaza.Text;
                nuevaMascota.nacimiento = dtpNacimiento.Value;
                nuevaMascota.genero = cbGenero.Text;
                nuevaMascota.idUsuario = selectedUsusario.idUsuario;
                accionesMascotas.AgregarMascota(nuevaMascota);
                limpiarCampos();
                cargarMascotas();
                MessageBox.Show("Mascota creada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }

        public void m_buscarMascota()
        {
            int idMascota = int.Parse(txtFiltroMascotas.Text);

            Mascota mascota = accionesMascotas.buscarMascota(idMascota);

            try
            {
                v_idMascota = mascota.idmascota;

                txtIDMascota.Text = mascota.idmascota.ToString();
                txtNombreMascota.Text = mascota.nombremascota.ToString();
                txtEspecie.Text = mascota.especie.ToString();
                txtRaza.Text = mascota.raza.ToString();
                dtpNacimiento.Text = mascota.nacimiento.ToString();
                cbGenero.Text = mascota.genero.ToString();
                cbUsuario.SelectedItem  = mascota.idUsuario;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public void m_actualizarMascota()
        {
            try
            {
                Mascota mascota = new Mascota();
                Usuario selectedUsusario = (Usuario)cbUsuario.SelectedItem;
                mascota.idmascota = int.Parse(txtIDMascota.Text);
                mascota.nombremascota = txtNombreMascota.Text;
                mascota.especie = txtEspecie.Text;
                mascota.raza = txtRaza.Text;
                mascota.nacimiento = dtpNacimiento.Value;
                mascota.genero = cbGenero.Text;
                mascota.idUsuario = selectedUsusario.idUsuario;

                bool actualizar = accionesMascotas.actualizarMascota(mascota);

                if (actualizar)
                {
                    MessageBox.Show("Información actualizada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarCampos();
                    cargarMascotas();
                }

                else
                {
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public void m_eliminarMascota()
        {
            try
            {
                Mascota mascota = new Mascota();

                mascota.idmascota = int.Parse(txtIDMascota.Text);

                bool borrar = accionesMascotas.eliminarMascota(mascota);

                if (borrar)
                {
                    MessageBox.Show("Registro eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarCampos();
                    cargarMascotas();
                }

                else
                {
                    MessageBox.Show("Error al eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        #endregion metodos

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            m_agregarMascota();
        }

        private void btnBuscarMascotas_Click(object sender, EventArgs e)
        {
            m_buscarMascota();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btn_actualizarMascota_Click(object sender, EventArgs e)
        {
            m_actualizarMascota();
        }

        private void btn_eliminarMascota_Click(object sender, EventArgs e)
        {
            m_eliminarMascota();
        }

        public void cargarUsuarios()
        {
            List<Usuario> litaUsuarios = accionesUsuario.ListarUsuarios();
            cbUsuario.DataSource = litaUsuarios;
            cbUsuario.DisplayMember = "Nombre";
            cbUsuario.ValueMember = "IdUsuario";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
