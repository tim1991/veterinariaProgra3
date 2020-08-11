using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DSProducto : DSConexion
    {
        SqlDataAdapter adaptador;
        DataTable tblProducto;

        #region Metodos

        public bool InsertarProducto(Producto producto)
        {
            bool insertar = false;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("agregarProducto", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@NombreProducto", SqlDbType.NVarChar).Value = producto.nombreProducto;
                    vCmd.Parameters.Add("@Precio", SqlDbType.Int).Value = producto.precioProducto;
                    vCmd.Parameters.Add("@Stock", SqlDbType.Int).Value = producto.stockProducto;
                    vCmd.ExecuteNonQuery();

                    insertar = true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                vCnx.Close();
            }
            return insertar;
        }

        public bool ActualizarProducto(Producto producto)
        {
            bool update = false;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("actualizarProducto", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@NombreProducto", SqlDbType.NVarChar).Value = producto.nombreProducto;
                    vCmd.Parameters.Add("@Precio", SqlDbType.Int).Value = producto.precioProducto;
                    vCmd.Parameters.Add("@Stock", SqlDbType.Int).Value = producto.stockProducto;
                    vCmd.ExecuteNonQuery();

                    update = true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                vCnx.Close();
            }
            return update;
        }

        public DataTable GetTblProducto()
        {
            try
            {
                if (Open())
                {
                    adaptador = new SqlDataAdapter("mostrarProducto", vCnx);
                    tblProducto = new DataTable();
                    adaptador.Fill(tblProducto);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                vCnx.Close();
            }
            return tblProducto;
        }

        #endregion
    }
}
