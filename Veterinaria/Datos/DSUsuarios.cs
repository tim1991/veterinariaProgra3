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

        public bool Actualizar(Usuario vpoUsuario)
        {
            bool actualizar = false;
            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("actualizarUsuario", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@IDUsuario", SqlDbType.VarChar).Value = vpoUsuario.idUsuario;
                    vCmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = vpoUsuario.cedula;
                    vCmd.Parameters.Add("@NombrePersona", SqlDbType.VarChar).Value = vpoUsuario.nombre;
                    vCmd.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = vpoUsuario.contrasena;
                    vCmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = vpoUsuario.apellidos;
                    vCmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = vpoUsuario.email;
                    vCmd.Parameters.Add("@Telefono", SqlDbType.Int).Value = vpoUsuario.telefono;
                    vCmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = vpoUsuario.direccion;
                    vCmd.Parameters.Add("@IdRol", SqlDbType.Int).Value = vpoUsuario.rol;

                    vCmd.ExecuteNonQuery();

                    actualizar = true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                Close();
            }


            return actualizar;
        }

        public List<Usuario> listarUsuarios()
        {
            List<Usuario> RolList = new List<Usuario>();
            Usuario usuario = null;
            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("listarUsuarios", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = vCmd.ExecuteReader();
                    while (reader.Read())
                    {

                        usuario = new Usuario();
                        usuario.idUsuario = int.Parse(reader["IDUsuario"].ToString());
                        usuario.cedula = int.Parse(reader["Cedula"].ToString());
                        usuario.nombre = reader["NombrePersona"].ToString();
                        usuario.contrasena = reader["Contrasena"].ToString();
                        usuario.apellidos = reader["Apellidos"].ToString();
                        usuario.email = reader["Email"].ToString();
                        usuario.telefono = int.Parse(reader["Telefono"].ToString());
                        usuario.direccion = reader["Direccion"].ToString();
                        usuario.descripcionRol = reader["Detalle"].ToString();
                        usuario.rol = int.Parse(reader["IdRol"].ToString());
                        RolList.Add(usuario);
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


        public Sesion Loguear(Usuario vpoUsuario)
        {
            Sesion sesion; 
            sesion = null;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("ingresar", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = vpoUsuario.email;
                    vCmd.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = vpoUsuario.contrasena;

                    SqlDataReader reader = vCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sesion = new Sesion();
                        sesion.nombre = reader["NombrePersona"].ToString() + " " + reader["Apellidos"].ToString();
                        sesion.idRol = int.Parse(reader["IdRol"].ToString());
                        sesion.nombreRol = reader["Detalle"].ToString();
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


            return sesion;

        }

        public Usuario Buscar(int cedula)
        {
            Usuario usuario;
            usuario = null;

            try
            {
                if (Open())
                {
                    vCmd = new SqlCommand("obtenerUsuarioCedula", vCnx);
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;

                    SqlDataReader reader = vCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        usuario = new Usuario();
                        usuario.idUsuario= int.Parse(reader["idUsuario"].ToString());
                        usuario.cedula = int.Parse(reader["cedula"].ToString());
                        usuario.nombre = reader["NombrePersona"].ToString();
                        usuario.apellidos = reader["Apellidos"].ToString();
                        usuario.direccion = reader["Direccion"].ToString();
                        usuario.email = reader["Email"].ToString();
                        usuario.telefono = int.Parse(reader["Telefono"].ToString());
                        usuario.rol = int.Parse(reader["idRol"].ToString());
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


            return usuario;

        }
    }

}
