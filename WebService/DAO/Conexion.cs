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
            //con = new SqlConnection("workstation id=FemsJup.mssql.somee.com;packet size=4096;user id=UTM;pwd=Hola1234;data source=FemsJup.mssql.somee.com;persist security info=False;initial catalog=FemsJup");
            //con = new SqlConnection("Data Source=PCAYAM\\SQLEXPRESS; Initial Catalog=FEMSJUP; Integrated Security=True");
            con = new SqlConnection("Data Source = sql5047.site4now.net; Initial Catalog = DB_A5046F_FEMSJUP; User Id = DB_A5046F_FEMSJUP_admin; Password = Hola1234;");
            
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