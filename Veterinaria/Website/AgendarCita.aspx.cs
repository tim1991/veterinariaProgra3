using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class AgendarCita : System.Web.UI.Page
    {
        private NegCita acciones = new NegCita();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            //acciones.AgregarCita();
        }

       
    }
}