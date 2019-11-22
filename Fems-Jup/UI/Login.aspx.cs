using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fems_Jup.BO;
using Newtonsoft.Json;

namespace Fems_Jup.UI
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioAdmin obj = new UsuarioAdmin();
            obj.Correo = txtcorreo.Text;
            obj.Contrasenia = txtcontra.Text;
            string sUrlRequest = "http://localhost:51437/SQL.asmx/Login?correo=" + obj.Correo +
                 "&contrasenia=" + obj.Contrasenia;
            var json = new WebClient().DownloadString(sUrlRequest);
            
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));            

            if (dt.Rows.Count > 0)
            {                                
                Response.Redirect("Index.aspx");                
            }
            else
            {
                Response.Redirect("Login.aspx");
            }          

        }
        public class Resultado
        {
            public string result { get; set; }
        }


    }
}
