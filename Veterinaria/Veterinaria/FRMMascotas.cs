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

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            Mascota nuevaMascota = new Mascota();

            try
            {
                nuevaMascota.idmascota = int.Parse(txtIDMascota.Text);
                nuevaMascota.nombremascota = txtNombreMascota.Text;
                nuevaMascota.especie = txtEspecie.Text;
                nuevaMascota.raza = txtRaza.Text;
                nuevaMascota.nacimiento = int.Parse(txtNacimiento.Text);
                nuevaMascota.genero = cbGenero.Text;
                nuevaMascota.idUsuario = int.Parse(txtUsuarioMascota.Text);
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

        public void limpiarCampos()
        {
            txtIDMascota.Text = String.Empty;
            txtNombreMascota.Text = String.Empty;
            txtEspecie.Text = String.Empty;
            txtRaza.Text = String.Empty;
            txtNacimiento.Text = String.Empty;
            cbGenero.Text = String.Empty;
        }

        public void cargarMascotas()
        {
            List<Mascota> listarMascotas = accionesMascotas.ListarMascota();
            dgvMascotas.DataSource = listarMascotas;
        }
    }
}
