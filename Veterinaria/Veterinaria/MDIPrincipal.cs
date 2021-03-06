﻿using Entidades;
using Entidades.Enumeradores;
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
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        private Sesion datosUsuario = new Sesion();

        public MDIPrincipal(Sesion sesion)
        {
            datosUsuario = sesion;
            InitializeComponent();
            permisos();
            lblUsuario.Text = datosUsuario.nombre;
            lblRol.Text = datosUsuario.nombreRol;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.TopLevel = false;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        public void permisos()
        {
            if (datosUsuario.idRol != (int)EnumRoles.Administrador)
            {
                usuariosToolStripMenuItem.Visible = false;
                productosToolStripMenuItem.Visible = false;
            }
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMUsuarios usuarios = new FRMUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void mantMascotaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMMascotas mascotas = new FRMMascotas();
            mascotas.MdiParent = this;
            mascotas.Show();
        }

        private void nuevaCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCitas citas = new FRMCitas();
            citas.MdiParent = this;
            citas.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMProductos productos = new FRMProductos();
            productos.MdiParent = this;
            productos.Show();
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMModuloFactura factura = new FRMModuloFactura();
            factura.MdiParent = this;
            factura.Show();
        }
    }
}
