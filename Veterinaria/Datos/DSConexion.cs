using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DSConexion
    {
        public SqlConnection vCnx;
        public SqlCommand vCmd;
        public SqlDataAdapter adaptador;

        private static string servidor = "DESKTOP-KGJOPLI";
        private static string baseDatos = "MundoAnimalia";

        private string connectionString = "Data Source="+servidor+";Initial Catalog="+baseDatos+";Integrated Security=True";
        public bool Open()
        {
            try
            {
                vCnx = new SqlConnection(this.connectionString);
                vCnx.Open();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Close()
        {
            try
            {
                vCnx.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
