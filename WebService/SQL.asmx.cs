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
        //string cs = "Data Source=PCAYAM\\SQLEXPRESS;Initial Catalog=FEMSJUP;Integrated Security=True";

        /*
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public bool Login(string correo, string contrasenia)
        {

            var query = "";
            con = new SqlConnection(cs); //instancia el objeto para la conexion a la bd
            con.Open();
            var sentencia = new SqlCommand(query, con);
            sentencia.Parameters.AddWithValue("correo", correo);
            sentencia.Parameters.AddWithValue("contrasenia", contrasenia);
            return true;
        }
        */
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void Login(string correo, string contrasenia)
        {
            string strBuscar = string.Format("SELECT * FROM Usuario WHERE correo='{0}' and contrasenia='{1}'", correo, contrasenia);
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
        public void FotoAP(string id)
        {
            string strBuscar = string.Format("SELECT foto FROM Usuario WHERE id_usuario='{0}'", id);
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
        public void Mostrar_aprobados()
        {
            string strBuscar = string.Format("SELECT u.id_usuario as ID,u.nombre as Nombre, u.apellido_p as ApellidoP, u.apellido_m as ApellidoM, u.correo as Correo, u.contrasenia , u.foto, u.telefono, u.direccion, tu.TipoUsuario, es.estatus as Estatus, p.pais, e.estado, m.municipio" +
                                                " FROM Usuario as u " +
                                                " INNER JOIN Tipo_Usuario as tu " +
                                                " ON u.id_tipousuario = tu.id_tipousuario " +
                                                " INNER JOIN Estatus as es " +
                                                " ON u.id_estatus = es.id_estatus and u.id_estatus = 1 " +
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
        public void Mostrar_PorAutorizar()
        {
            string strBuscar = string.Format("SELECT u.id_usuario as ID,u.nombre as Nombre, u.apellido_p as ApellidoP, u.apellido_m as ApellidoM, u.correo as Correo, u.contrasenia , u.foto, u.telefono, u.direccion, tu.TipoUsuario, es.estatus as Estatus, p.pais, e.estado, m.municipio" +
                                                " FROM Usuario as u " +
                                                " INNER JOIN Tipo_Usuario as tu " +
                                                " ON u.id_tipousuario = tu.id_tipousuario " +
                                                " INNER JOIN Estatus as es " +
                                                " ON u.id_estatus = es.id_estatus and u.id_estatus = 3 " +
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

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void Autorizar(int id)
        {

            int idusu = miConexion.ejecutarSentencia(string.Format("Update Usuario set id_estatus=1 where id_usuario = {0}", id));
            //Se convierte a JSON
            string SalidaJSON = string.Empty;
            SalidaJSON = JsonConvert.SerializeObject(idusu);
            //Salida del webservice
            HttpContext Contexto = HttpContext.Current;
            Context.Response.ContentType = "application/json";
            Context.Response.Write(SalidaJSON);
            Context.Response.End();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void Crear_Usuario(string nombre, string apellidop, string apellidom, string correo, string contrasenia, string foto, string telefono, string direccion, string tusuario, string estatus, string pais, string estado, string municipio)
        {
            string strExec = string.Format("INSERT INTO Usuario(nombre,apellido_p,apellido_m,correo,contrasenia," +
                "foto,telefono,direccion,id_tipousuario,id_estatus,id_pais,id_estado,id_municipio)" +
                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", nombre, apellidop, apellidom, correo, contrasenia, foto, telefono, direccion, tusuario, estatus, pais, estado, municipio);
            int idusu = miConexion.ejecutarSentencia(strExec);
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
