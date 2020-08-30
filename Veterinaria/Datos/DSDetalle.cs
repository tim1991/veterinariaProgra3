using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DSDetalle : DSConexion
    {
        DataTable dtDetalle;

        #region Metodos

        public DataTable getTblDetalle()
        {
            try
            {
                if (Open())
                {
                    adaptador = new SqlDataAdapter("selectDetalles", vCnx);
                    dtDetalle = new DataTable();
                    adaptador.Fill(dtDetalle);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                vCnx.Close();
            }
            return dtDetalle;
        }

        #endregion
    }
}
