using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FemsJubService.SQL;

namespace FemsJubService
{
    public class Service
    {
        private readonly SQL.SQLSoapClient proxy = null;

        public Service()
        {
            proxy = new SQLSoapClient();
        }

        public bool Login(string correo, string contrasenia)
        {
            return proxy.Login(correo, contrasenia);
        }
    }
}
