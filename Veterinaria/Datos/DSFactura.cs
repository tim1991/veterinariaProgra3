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
    public class DSFactura : DSConexion
    {
        #region Metodos

        DataTable dtFactura;

        public int idFactura()
        {

            int idFactura = 0;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("selectNumFactura", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = vCmd.ExecuteReader();
                    reader.Read();
                    idFactura = int.Parse(reader[0].ToString());
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                Close();
            }
            return idFactura;
        }

        public int agregarFactura(Factura factura)
        {
            int num = 0;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("InsertarFactura", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@FechaFactura", SqlDbType.DateTime).Value = factura.Fecha;
                    vCmd.Parameters.Add("@Subtotal", SqlDbType.Decimal).Value = factura.Subtotal;
                    vCmd.Parameters.Add("@Impuestos", SqlDbType.Decimal).Value = factura.Impuestos;
                    vCmd.Parameters.Add("@Total", SqlDbType.Decimal).Value = factura.Total;
                    vCmd.Parameters.Add("@MetodoPago", SqlDbType.VarChar).Value = factura.MetodoPago;
                    vCmd.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = factura.IDUsuario;
                    vCmd.ExecuteNonQuery();

                    Factura fact = buscarFactura(factura.Id);
                    num = fact.Id;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                Close();
            }
            return num;
        }

        public Factura buscarFactura(int numFact)
        {
            Factura fact = null;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("selectIdFactura", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@IDFactura", SqlDbType.Int).Value = numFact;
                    SqlDataReader reader = vCmd.ExecuteReader();


                    while (reader.Read())
                    {
                        fact = new Factura();
                        fact.Id = int.Parse(reader["IdFactura"].ToString());
                        fact.Fecha = DateTime.Parse(reader["FechaFactura"].ToString());
                        fact.Subtotal = decimal.Parse(reader["Subtotal"].ToString());
                        fact.Impuestos = decimal.Parse(reader["Impuestos"].ToString());
                        fact.Total = decimal.Parse(reader["Total"].ToString());
                        fact.MetodoPago = reader["MetodoPago"].ToString();
                        fact.IDUsuario = int.Parse(reader["IDUsuario"].ToString());
                    }
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                Close();
            }
            return fact;
        }

        public DataTable getTblFactura()
        {
            try
            {
                if (Open())
                {
                    adaptador = new SqlDataAdapter("selectFacturas", vCnx);
                    dtFactura = new DataTable();
                    adaptador.Fill(dtFactura);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                vCnx.Close();
            }
            return dtFactura;
        }

        #endregion

        #region Metodos Detalle

        public bool agregarDetalle(Detalles detalle)
        {
            bool insertar = false;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("insertDetalle", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = detalle.Cantidad;
                    vCmd.Parameters.Add("@SubtotalDetalle", SqlDbType.Decimal).Value = detalle.Subtotal;
                    vCmd.Parameters.Add("@ImpuestosDetalle", SqlDbType.Decimal).Value = detalle.Impuestos;
                    vCmd.Parameters.Add("@TotalDetalle", SqlDbType.Decimal).Value = detalle.Total;
                    vCmd.Parameters.Add("@IDProducto", SqlDbType.Int).Value = detalle.IdProducto;
                    vCmd.Parameters.Add("@IDFactura", SqlDbType.Int).Value = detalle.IdFactura;
                    vCmd.ExecuteNonQuery();

                    insertar = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                Close();
            }
            return insertar;
        }

        #endregion
    }
}
