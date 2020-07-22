using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DSRol : DSConexion
    {
        public List<Rol> listarRoles()
        {
            List<Rol> RolList = new List<Rol>();
            Rol rol = null;
            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("listarRoles", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = vCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        rol = new Rol();
                        rol.idRol = int.Parse(reader["IdRol"].ToString());
                        rol.detalle = reader["Detalle"].ToString();
                        RolList.Add(rol);
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


            return RolList;

        }

    }
}
