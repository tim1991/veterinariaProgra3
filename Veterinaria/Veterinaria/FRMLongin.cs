using Entidades;
using Negocios;
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
    public partial class FRMLongin : Form
    {

        private NegUsuario accionesUsuario = new NegUsuario();
        public FRMLongin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();

            if (validar())
            {
                usuario.email = txtEmail.Text;
                usuario.contrasena = txtContrasena.Text;
                Sesion sesion = accionesUsuario.Loguear(usuario);

                if (sesion != null)
                {

                    MDIPrincipal principal = new MDIPrincipal(sesion);
                    principal.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        public bool validar()
        {
            if (txtEmail.Text != String.Empty && txtContrasena.Text != String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
