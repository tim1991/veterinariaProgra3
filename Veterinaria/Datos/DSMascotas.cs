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
    public class DSMascotas : DSConexion
    {
        public void NuevaMascota(Mascota mascota)
        {
            SqlCommand cmd = new SqlCommand("agregarMascota", vCnx);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreMascota", mascota.nombremascota);
                cmd.Parameters.AddWithValue("@Especie", mascota.especie);
                cmd.Parameters.AddWithValue("@Raza", mascota.raza);
                cmd.Parameters.AddWithValue("@Nacimiento", mascota.nacimiento);
                cmd.Parameters.AddWithValue("@Genero", mascota.genero);
                cmd.Parameters.AddWithValue("@IDUsuario", mascota.idUsuario);

                vCnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                vCnx.Close();
            }
        }

        public List<Mascota> listarMascotas()
        {
            List<Mascota> mascotaList = new List<Mascota>();
            Mascota mascota = null;
            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("mostrarMascotas", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = vCmd.ExecuteReader();
                    while (reader.Read())
                    {

                        mascota = new Mascota();
                        mascota.idmascota = int.Parse(reader["IdMascota"].ToString());
                        mascota.nombremascota = reader["NombreMascota"].ToString();
                        mascota.especie = reader["Especie"].ToString();
                        mascota.raza = reader["Raza"].ToString();
                        mascota.nacimiento = DateTime.Parse(reader["Nacimiento"].ToString());
                        mascota.genero = reader["Genero"].ToString();
                        mascota.idUsuario = int.Parse(reader["IDUsuario"].ToString());
                        mascotaList.Add(mascota);
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

            return mascotaList;
        }

        public Mascota BuscarMascota(int idMascot)
        {
            Mascota mascota = null;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("buscarMascota", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@IdMascota", SqlDbType.Int).Value = idMascot;

                    SqlDataReader reader = vCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        mascota = new Mascota();
                        mascota.idmascota = int.Parse(reader["IdMascota"].ToString());
                        mascota.nombremascota = reader["NombreMascota"].ToString();
                        mascota.especie = reader["Especie"].ToString();
                        mascota.raza = reader["Raza"].ToString();
                        mascota.nacimiento = DateTime.Parse(reader["Nacimiento"].ToString());
                        mascota.genero = reader["Genero"].ToString();
                        mascota.idUsuario = int.Parse(reader["IDUsuario"].ToString());
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

            return mascota;
        }

        public bool ActualizarMascota(Mascota mascot)
        {
            bool actualizar = false;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("actualizarMascota", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@IdMascota", SqlDbType.Int).Value = mascot.idmascota;
                    vCmd.Parameters.Add("@NombreMascota", SqlDbType.NVarChar).Value = mascot.nombremascota;
                    vCmd.Parameters.Add("@Especie", SqlDbType.NVarChar).Value = mascot.especie;
                    vCmd.Parameters.Add("@Raza", SqlDbType.NVarChar).Value = mascot.raza;
                    vCmd.Parameters.Add("@Nacimiento", SqlDbType.Int).Value = mascot.nacimiento;
                    vCmd.Parameters.Add("@Genero", SqlDbType.NVarChar).Value = mascot.genero;
                    vCmd.Parameters.Add("@IDUsuario", SqlDbType.Int).Value = mascot.idUsuario;

                    vCmd.ExecuteNonQuery();

                    actualizar = true;
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

            return actualizar;
        }

        public bool EliminarMascota(Mascota mascot)
        {
            bool borrar = false;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("deleteMascota", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;

                    vCmd.Parameters.Add("@IdMascota", SqlDbType.Int).Value = mascot.idmascota;

                    vCmd.ExecuteNonQuery();

                    borrar = true;
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

            return borrar;
        }
    }
}
