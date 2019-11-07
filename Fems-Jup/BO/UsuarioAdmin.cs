using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fems_Jup.BO
{
    public class UsuarioAdmin
    {
        private int id;
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private string direccion;
        private string telefono;
        private string pais;
        private string estado;
        private string municipio;
        private string correo;
        private string contrasenia;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string ApellidoP
        {
            get
            {
                return apellidoP;
            }

            set
            {
                apellidoP = value;
            }
        }

        public string ApellidoM
        {
            get
            {
                return apellidoM;
            }

            set
            {
                apellidoM = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                pais = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Municipio
        {
            get
            {
                return municipio;
            }

            set
            {
                municipio = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Contrasenia
        {
            get
            {
                return contrasenia;
            }

            set
            {
                contrasenia = value;
            }
        }
    }
}