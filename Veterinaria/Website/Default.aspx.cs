using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class _Default : Page
    {
        private NegCita accionesCita = new NegCita();

        public List<Cita> misCitas = new List<Cita>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

       

        protected void txtServicio_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int consecutivo = accionesCita.consecutivoCita();
            Cita nuevaCitaWeb = new Cita();
            string servicio = txtServicio.Text;
            int usuario = int.Parse(txtCliente.Text);
            DateTime fecha = DateTime.Parse(txtFecha.Text);

            nuevaCitaWeb.idcita = consecutivo;
            nuevaCitaWeb.idUsuario = usuario;
            nuevaCitaWeb.fechacita = fecha;
            nuevaCitaWeb.servicio = servicio;

           bool insertar = accionesCita.AgregarCita(nuevaCitaWeb);

            if (insertar)
            {
                Response.Write("<script> alert('Cita agendada correctamente'); </script>");
                txtServicio.Text = string.Empty;
                txtCliente.Text = string.Empty;
                txtFecha.Text = string.Empty;
            }
            else
            {
                Response.Write("<script> alert('Error al agendar la cita'); </script>");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int cedula = int.Parse(txtCedula.Text);


            misCitas = accionesCita.buscarCita(cedula);

            
        }
    }
}