﻿using System;
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
        public int ConsecutivoCita()
        {
            int conse = 0;

            try
            {
                if (Open())
                {
                    SqlCommand cmd = new SqlCommand("ConsecutivoCita", vCnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    conse = int.Parse(reader[0].ToString());
                }
            }

            catch (Exception)
            {

            }

            finally
            {
                Close();
            }

            return conse;
        }

        public void NuevaCita(Cita cita)
        {
            SqlCommand cmd = new SqlCommand("agregarCita", vCnx);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCita", cita.idcita);
                cmd.Parameters.AddWithValue("@Servicio", cita.servicio);
                cmd.Parameters.AddWithValue("@FechaCita", cita.fechacita);
                cmd.Parameters.AddWithValue("@IDUsuario", cita.idUsuario);

                vCnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                vCnx.Close();
            }
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

        public Cita BuscarCita(int idCita)
        {
            Cita cita = null;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("buscarCita", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@IdCita", SqlDbType.Int).Value = idCita;

                    SqlDataReader reader = vCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cita = new Cita();
                        cita.idcita = int.Parse(reader["IdMascota"].ToString());
                        cita.servicio = reader["NombreMascota"].ToString();
                        cita.fechacita = DateTime.Parse(reader["Especie"].ToString());
                        cita.idUsuario = int.Parse(reader["Raza"].ToString());
                    }
                }
            }
            catch (Exception error)
            {
                throw error;
            }

            finally
            {
                Close();
            }

            return cita;
        }
    }
}
