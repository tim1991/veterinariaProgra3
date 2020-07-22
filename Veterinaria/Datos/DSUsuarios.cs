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
    public class DSUsuarios:DSConexion
    {

        public bool Agregar(Usuario vpoUsuario)
        {
                bool insertar = false;
                try
                {
                    if (Open())
                    {
                        vCmd = new SqlCommand("agregarUsuario", vCnx);
                        vCmd.CommandType = CommandType.StoredProcedure;
                        vCmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = vpoUsuario.cedula;
                        vCmd.Parameters.Add("@NombrePersona", SqlDbType.VarChar).Value = vpoUsuario.nombre;
                        vCmd.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = vpoUsuario.contrasena;
                        vCmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = vpoUsuario.apellidos;
                        vCmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = vpoUsuario.email;
                        vCmd.Parameters.Add("@Telefono", SqlDbType.Int).Value = vpoUsuario.telefono;
                        vCmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = vpoUsuario.direccion;
                        vCmd.Parameters.Add("@IdRol", SqlDbType.Int).Value = vpoUsuario.rol;

                        vCmd.ExecuteNonQuery();

                        insertar = true;
                    }
                }
                catch (Exception e)
                {

                }
                finally
                {
                    Close();
                }


                return insertar;
            }
        


    }
}
