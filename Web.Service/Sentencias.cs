using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Service
{
    public class Sentencias
    {
        private readonly ConexionWS.ConexionSQLSoapClient proxy = null;
        //[Serializable = "nombre"]
        public Sentencias()
        {
            proxy = new ConexionWS.ConexionSQLSoapClient();
        }
        public bool Login(string correo,string contrasenia)
        {
            return proxy.Login(correo, contrasenia);
        }
       
    }
}
