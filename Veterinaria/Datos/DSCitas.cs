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
    public class DSCitas : DSConexion
    {
        public bool NuevaCita(Cita cita)
        {
            bool insertar = true;



            try
            {
                if (Open())
                {
                    SqlCommand cmd = new SqlCommand("agregarCita", vCnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Servicio", cita.servicio);
                    cmd.Parameters.AddWithValue("@FechaCita", cita.fechacita);
                    cmd.Parameters.AddWithValue("@IDUsuario", cita.idUsuario);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                insertar = false;
            }
            finally
            {
                vCnx.Close();
            }

            return insertar;
        }

        public List<Cita> listarCitas()
        {
            List<Cita> citaList = new List<Cita>();
            Cita cita = null;
            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("listarCitas", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = vCmd.ExecuteReader();
                    while (reader.Read())
                    {

                        cita = new Cita();
                        cita.idcita = int.Parse(reader["IdCita"].ToString());
                        cita.servicio = reader["Servicio"].ToString();
                        cita.fechacita = DateTime.Parse(reader["FechaCita"].ToString());
                        cita.idUsuario = int.Parse(reader["IDUsuario"].ToString());
                        citaList.Add(cita);
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

            return citaList;
        }

        public Cita BuscarCita(int id)
        {
            Cita cita;
            cita = null;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("buscarCita", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@IdCita", SqlDbType.Int).Value = id;

                    SqlDataReader reader = vCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cita = new Cita();
                        cita.idcita = int.Parse(reader["IdCita"].ToString());
                        cita.servicio = reader["Servicio"].ToString();
                        cita.fechacita = DateTime.Parse(reader["FechaCita"].ToString());
                        cita.idcita = int.Parse(reader["IDUsuario"].ToString());
                    }
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Close();
            }
            return cita;
        }
    }
}
