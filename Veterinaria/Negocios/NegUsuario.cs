﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegUsuario
    {
        private DSUsuarios accionesUsuario = new DSUsuarios();

        public bool AgregarUsuario(Usuario vpoUsuario)
        {
            bool insertar = accionesUsuario.Agregar(vpoUsuario);

            return insertar;
        }  
        
        public Sesion Loguear(Usuario vpoUsuario)
        {
            Sesion sesion = accionesUsuario.Loguear(vpoUsuario);

            return sesion;
        } 

        public bool ActualizarUsuario(Usuario vpoUsuario)
        {
            return true;
        } 

        public bool EliminarUsuario()
        {
            return true;
        }
        
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> vloUsuarios = accionesUsuario.listarUsuarios();

            return vloUsuarios;
        } 
        public Usuario BuscarUsuario(int vpcIdUsuario = 0, string vpcNombre = null)
        {
            Usuario vloUsuario = new Usuario();

            return vloUsuario;
        }
    }
}