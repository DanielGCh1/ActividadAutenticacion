using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelos
{
    public class Usuario
    {
        public Usuario()
        {
            NombreUsuario = "";
            ContraseñaUsuario = "";
        }

        public string NombreUsuario
        {
            get;
            set;
        }

        public string ContraseñaUsuario
        {
            get;
            set;
        }

        public bool  ComprobarUsuario( string nombreUsuario)
        {
            if(NombreUsuario == nombreUsuario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ComprobarContraseña(string contraseñaUsuario)
        {
            
            if ( ContraseñaUsuario == contraseñaUsuario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}