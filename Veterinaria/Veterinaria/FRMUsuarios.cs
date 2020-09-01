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
        private bool insertar = true;
        private int vgIdUsuario = 0;

        public FRMUsuarios()
        {
            InitializeComponent();
            cargarRoles();
            cargarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (validar())
            {
                bool ejecutar = false;
                rolSeleccionado = (Rol)cboRol.SelectedItem;

                usuario.cedula = int.Parse(txtCedula.Text);
                usuario.nombre = txtNombre.Text;
                usuario.apellidos = txtApellidos.Text;
                usuario.telefono = int.Parse(txtTelefono.Text);
                usuario.direccion = txtDireccion.Text;
                usuario.email = txtEmail.Text;
                usuario.contrasena = txtContrasena.Text;
                usuario.rol = rolSeleccionado.idRol;

                if (insertar)
                {
                    ejecutar = accionesUsuario.AgregarUsuario(usuario);
                }
                else
                {
                    usuario.idUsuario = vgIdUsuario;
                    ejecutar = accionesUsuario.ActualizarUsuario(usuario);
                }
               

                if (ejecutar)
                {
                    limpiarCampos();
                    cargarUsuarios();
                    MessageBox.Show("Usuario guardado correctamente","Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Problema al guardar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error debe ingresar todos los campos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        public bool validar()
        {

            if(txtCedula.Text != String.Empty && txtNombre.Text != String.Empty && txtApellidos.Text != String.Empty
                && txtTelefono.Text != String.Empty && txtDireccion.Text != String.Empty && txtEmail.Text != String.Empty
                && txtContrasena.Text != String.Empty && cboRol.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public void limpiarCampos()
        {
            txtCedula.Text = String.Empty; 
            txtNombre.Text = String.Empty; 
            txtApellidos.Text = String.Empty;
            txtTelefono.Text = String.Empty; 
            txtDireccion.Text = String.Empty; 
            txtEmail.Text = String.Empty;
            txtContrasena.Text = String.Empty; 
        }


        public void cargarRoles()
        {
            List<Rol> litaRoles = accionesRol.ListarRoles();
            cboRol.DataSource = litaRoles;
            cboRol.DisplayMember = "Detalle";
            cboRol.ValueMember = "IdRol";


        } public void cargarUsuarios()
        {
            List<Usuario> litaUsuarios = accionesUsuario.ListarUsuarios();
            dgvUsuarios.DataSource = litaUsuarios;


        }

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = dgvUsuarios.CurrentCell.RowIndex;
            int columIndex = 5;
            string codigo = this.dgvUsuarios[columIndex, rowIndex].Value.ToString();

            Usuario usuario = accionesUsuario.BuscarUsuario(int.Parse(codigo));

            if (usuario != null)
            {
                insertar = false;
                btnCancelar.Visible = true;
                btnAgregarUsuario.Text = "Actualizar";
                vgIdUsuario = usuario.idUsuario;
                txtCedula.Text = usuario.cedula.ToString();
                txtNombre.Text = usuario.nombre;
                txtApellidos.Text = usuario.apellidos;
                txtTelefono.Text = usuario.telefono.ToString();
                txtDireccion.Text = usuario.direccion;
                txtContrasena.Text = usuario.contrasena;
                txtEmail.Text = usuario.email;

                cboRol.SelectedValue = usuario.rol;

            }
            else
            {
                MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
