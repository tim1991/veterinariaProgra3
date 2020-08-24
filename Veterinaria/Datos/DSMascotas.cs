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
                cmd.Parameters.AddWithValue("@IdMascota", mascota.idmascota);
                cmd.Parameters.AddWithValue("@NombreMascota", mascota.nombremascota);
                cmd.Parameters.AddWithValue("@Especie", mascota.especie);
                cmd.Parameters.AddWithValue("@Nacimiento", mascota.raza);
                cmd.Parameters.AddWithValue("@Genero", mascota.nacimiento);
                cmd.Parameters.AddWithValue("@IDUsuario", mascota.idUsuario);

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

        public List<Mascota> listarMascotas()
        {
            List<Mascota> mascotaList = new List<Mascota>();
            Mascota mascota = null;
            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("listarMascotas", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = vCmd.ExecuteReader();
                    while (reader.Read())
                    {

                        mascota = new Mascota();
                        mascota.idmascota = int.Parse(reader["IdMascota"].ToString());
                        mascota.nombremascota = reader["NombreMascota"].ToString();
                        mascota.especie = reader["Especie"].ToString();
                        mascota.raza = reader["Raza"].ToString();
                        mascota.nacimiento = int.Parse(reader["Nacimiento"].ToString());
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
    }
}
