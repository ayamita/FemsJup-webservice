using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Fems_Jup.BO;
using Web.Service;
using Newtonsoft.Json;
using System.Data;
using System.Net;
using Fems_Jup.BO;

namespace Fems_Jup.UI
{
    public partial class Aprobados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grid();
        }

        public void Grid ()
        {
            string sUrlRequest = "http://localhost:51437/SQL.asmx/Mostrar";
            var json = new WebClient().DownloadString(sUrlRequest);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            dgvDatos.DataSource = dt;
            dgvDatos.DataBind();
        }
        protected void btnConsulta_Click(object sender, EventArgs e)
        {         
        }

        protected void btnInvocar_Click(object sender, EventArgs e)
        {
          
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            UsuarioAdmin usuario = new UsuarioAdmin();
            usuario.Id = int.Parse(txt_Id.Text);
            string sUrlRequest = "http://localhost:51437/SQL.asmx/Eliminar?id=" + usuario.Id;
            var json = new WebClient().DownloadString(sUrlRequest);
            txt_Id.Text = "";
            Grid();
        }

        protected void dgv_usuario_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //sirve para que al usuario le de la opcion de apretar con un cursor
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgvDatos, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }

        protected void Seleccionar_registro(object sender, EventArgs e)
        {
            txt_Id.Text = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[0].Text);
            txt_Nombre.Text = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[1].Text);
        }
    }
}