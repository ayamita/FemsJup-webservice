using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fems_Jup.UI
{
    public partial class No_Aprobados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Seleccionar_registro(object sender, EventArgs e)
        {
            txt_Id.Text = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[0].Text);
            txt_Nombre.Text = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[1].Text);
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
    }
}