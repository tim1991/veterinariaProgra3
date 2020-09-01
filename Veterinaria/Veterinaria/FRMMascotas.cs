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
        public FRMMascotas()
        {
            InitializeComponent();
            cargarMascotas();
        }

        #region Metodos

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            Mascota nuevaMascota = new Mascota();

            try
            {
                nuevaMascota.nombremascota = txtNombreMascota.Text;
                nuevaMascota.especie = txtEspecie.Text;
                nuevaMascota.raza = txtRaza.Text;
                nuevaMascota.nacimiento = dtpFechaNacimiento.Value;
                nuevaMascota.genero = cbGenero.Text;
                nuevaMascota.idUsuario = int.Parse(txtUsuarioMascota.Text);
                bool insertar = accionesMascotas.AgregarMascota(nuevaMascota);
                limpiarCampos();
                cargarMascotas();

                if (insertar)
                {
                    MessageBox.Show("Mascota creada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Problema al crear la mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarMascotas()
        {
            List<Mascota> listarMascotas = accionesMascotas.ListarMascota();
            dgvMascotas.DataSource = listarMascotas;
        }

        public void buscarMascota()
        {
            try
            {
                int id = int.Parse(txtFiltroMascotas.Text);

                Mascota mascota = accionesMascotas.buscarMascota(id);

                if (mascota != null)
                {
                    dgvMascotas.DataSource = txtFiltroMascotas.Text;
                }
                else
                {
                    MessageBox.Show("La mascota no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtFiltroMascotas.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese el ID de una mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public void limpiarCampos()
        {
            txtNombreMascota.Text = String.Empty;
            txtEspecie.Text = String.Empty;
            txtRaza.Text = String.Empty;
            dtpFechaNacimiento.Text = String.Empty;
            cbGenero.Text = String.Empty;
        }

        private void btnBuscarMascotas_Click(object sender, EventArgs e)
        {
            buscarMascota();
        }
    }
}
