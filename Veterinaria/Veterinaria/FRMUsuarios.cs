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
    public partial class FRMUsuarios : Form
    {

        private NegUsuario accionesUsuario = new NegUsuario();
        private NegRol accionesRol = new NegRol();
        private Rol rolSeleccionado;
        public FRMUsuarios()
        {
            InitializeComponent();
            cargarRoles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (validar())
            {
                rolSeleccionado = (Rol)cboRol.SelectedItem;

                usuario.cedula = int.Parse(txtCedula.Text);
                usuario.nombre = txtNombre.Text;
                usuario.apellidos = txtApellidos.Text;
                usuario.telefono = int.Parse(txtTelefono.Text);
                usuario.direccion = txtDireccion.Text;
                usuario.email = txtEmail.Text;
                usuario.contrasena = txtContrasena.Text;
                usuario.rol = rolSeleccionado.idRol;

                bool insertar = accionesUsuario.AgregarUsuario(usuario);

                if (insertar)
                {
                    MessageBox.Show("Usuario creado correctamente","Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Problema al agregar el usuario","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error debe ingresar todos los campos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        public bool validar()
        {

            if(txtCedula.Text != String.Empty || txtNombre.Text != String.Empty || txtApellidos.Text != String.Empty 
                || txtTelefono.Text != String.Empty || txtDireccion.Text != String.Empty || txtEmail.Text != String.Empty
                || txtContrasena.Text != String.Empty || cboRol.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        public void cargarRoles()
        {
            List<Rol> litaRoles = accionesRol.ListarRoles();
            cboRol.DataSource = litaRoles;
            cboRol.DisplayMember = "Detalle";
            cboRol.ValueMember = "IdRol";


        }
    }
}
