using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.Sql;
using Newtonsoft.Json;
using WebService.DAO;
using System.Web.Script.Services;

namespace WebService
{
    /// <summary>
    /// Descripción breve de SQL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SQL : System.Web.Services.WebService
    {

        Conexion miConexion = new Conexion();
        //datos para la conexión usuario, bd, etc.
        SqlConnection con = new SqlConnection();
        string cs = "Data Source=PCAYAM\\SQLEXPRESS;Initial Catalog=FEMSJUP;Integrated Security=True";

        [WebMethod]
        public bool Login(string correo, string contrasenia)
        {

            var query = "SELECT * FROM Usuario WHERE correo='{0}',contrasenia='{1}'";
            con = new SqlConnection(cs); //instancia el objeto para la conexion a la bd
            con.Open();
            var sentencia = new SqlCommand(query, con);
            sentencia.Parameters.AddWithValue("correo", correo);
            sentencia.Parameters.AddWithValue("contrasenia", contrasenia);
            return true;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void Mostrar()
        {
            string strBuscar = string.Format("SELECT * FROM Usuario");
            DataTable datos = miConexion.EjecutarSentenciaBus(strBuscar);
            //Se convierte a JSON
            string SalidaJSON = string.Empty;
            SalidaJSON = JsonConvert.SerializeObject(datos);
            //Salida del webservice
            HttpContext Contexto = HttpContext.Current;
            Context.Response.ContentType = "application/json";
            Context.Response.Write(SalidaJSON);
            Context.Response.End();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void Eliminar(int id)
        {

            int idusu = miConexion.ejecutarSentencia(string.Format("DELETE FROM Usuario WHERE id = {0}", id));
            //Se convierte a JSON
            string SalidaJSON = string.Empty;
            SalidaJSON = JsonConvert.SerializeObject(idusu);
            //Salida del webservice
            HttpContext Contexto = HttpContext.Current;
            Context.Response.ContentType = "application/json";
            Context.Response.Write(SalidaJSON);
            Context.Response.End();

        }
    }
}
