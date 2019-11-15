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
            string strBuscar = string.Format("SELECT u.id_usuario as ID,u.nombre as Nombre, u.apellido_p as ApellidoP, u.apellido_m as ApellidoM, u.correo as Correo, u.contrasenia , u.fotoperfil, u.telefono, u.direccion, tu.TipoUsuario, es.estatus as Estatus, p.pais, e.estado, m.municipio"+
                                                " FROM Usuario as u "+
                                                " INNER JOIN Tipo_Usuario as tu "+
                                                " ON u.id_tipousuario = tu.id_tipousuario "+
                                                " INNER JOIN Estatus as es "+
                                                " ON u.id_estatus = es.id_estatus and u.id_estatus = 1 "+
                                                " INNER JOIN Pais as p " +
                                                " ON u.id_pais = p.id_pais " +
                                                " INNER JOIN Estado as e " +
                                                " ON u.id_estado = e.id_estado " +
                                                " INNER JOIN Municipio as m " +
                                                " ON u.id_municipio = m.id_municipio ");
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

            int idusu = miConexion.ejecutarSentencia(string.Format("DELETE FROM Usuario WHERE id_usuario = {0}", id));
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
