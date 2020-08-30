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
        DataTable tblProducto;

        #region Metodos

        public bool insertarProducto(Producto producto)
        {
            bool insertar = false;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("agregarProducto", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@NombreProducto", SqlDbType.NVarChar).Value = producto.nombreProducto;
                    vCmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = producto.precioProducto;
                    vCmd.ExecuteNonQuery();

                    insertar = true;
                }
            }
            catch (SqlException)
            {

            }
            finally
            {
                vCnx.Close();
            }
            return insertar;
        }

        public bool actualizarProducto(Producto producto)
        {
            bool update = false;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("actualizarProducto", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@NombreProducto", SqlDbType.NVarChar).Value = producto.nombreProducto;
                    vCmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = producto.precioProducto;
                    vCmd.ExecuteNonQuery();

                    update = true;
                }
            }
            catch (SqlException)
            {

            }
            finally
            {
                vCnx.Close();
            }
            return update;
        }

        public Producto buscar(int codigo)
        {
            Producto producto;
            producto = null;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("selectBuscarProducto", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@IDProducto", SqlDbType.Int).Value = codigo;

                    SqlDataReader reader = vCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        producto = new Producto();
                        producto.IdProducto = int.Parse(reader["IDProducto"].ToString());
                        producto.nombreProducto = reader["NombreProducto"].ToString();
                        producto.precioProducto = decimal.Parse(reader["Precio"].ToString());
                    }
                }
            }
            catch (SqlException)
            {

            }
            finally
            {
                Close();
            }
            return producto;
        }

        public bool eliminar(Producto producto)
        {
            bool delete = false;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("deleteProducto", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@NombreProducto", SqlDbType.NVarChar).Value = producto.nombreProducto;
                    vCmd.ExecuteNonQuery();

                    delete = true;
                }
            }
            catch (SqlException)
            {

            }
            finally
            {
                Close();
            }
            return delete;
        }

        public DataTable getTblProducto()
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
            catch (SqlException)
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
