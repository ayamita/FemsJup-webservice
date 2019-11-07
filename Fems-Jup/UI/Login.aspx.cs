using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fems_Jup.BO;
using Web.Service;

namespace Fems_Jup.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var datos = new Sentencias();
            UsuarioAdmin obj = new UsuarioAdmin();
            obj.Correo = txtcorreo.Text;
            obj.Contrasenia = txtcontra.Text;
           var respuesta= datos.Login(obj.Correo, obj.Contrasenia);
            if( respuesta == true)
            {
                Response.Redirect("Index.aspx");
            }
          
          
        }
    }
}