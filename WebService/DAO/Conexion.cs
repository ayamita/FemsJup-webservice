using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebService.DAO;

namespace WebService.DAO
{
    public class Conexion
    {
        SqlConnection con;
        SqlCommand exec;
        public Conexion()
        {
            //con = new SqlConnection("workstation id=BDServiciosric.mssql.somee.com;packet size=4096;user id=Arc07_SQLLogin_1;pwd=noizupwqo8;data source=BDServiciosric.mssql.somee.com;persist security info=False;initial catalog=BDServiciosric");
            con = new SqlConnection("Data Source=PCAYAM\\SQLEXPRESS; Initial Catalog=FEMSJUP; Integrated Security=True");
            exec = new SqlCommand();
        }

        public void abrirconexion()
        {
            this.con.Open();
        }

        public void cerrarconexion()
        {
            this.con.Close();
        }
        public int ejecutarSentencia(string strSql)
        {
            try
            {
                this.exec.CommandText = strSql;
                this.exec.Connection = this.con;
                this.abrirconexion();
                this.exec.ExecuteNonQuery();
                this.cerrarconexion();
                return 1;

            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                this.cerrarconexion();
            }

        }

        public DataTable EjecutarSentenciaBus(string strsql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(strsql, this.con);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}