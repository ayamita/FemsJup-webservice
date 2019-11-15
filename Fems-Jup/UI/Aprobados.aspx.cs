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
        UsuarioAdmin usu = new UsuarioAdmin();      
        protected void Page_Load(object sender, EventArgs e)
        {
            Grid();
            ocultar_columnas();
            bloqueo();
        }
        public void bloqueo()
        {
            txt_Id.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_nombre2.Enabled = false;
            txt_apellidon.Enabled = false;
            txt_apellidop.Enabled = false;
            txt_correo.Enabled = false;
            txt_telefono.Enabled = false;
            txt_direccion.Enabled = false;
            txt_tusuario.Enabled = false;
            txt_estatus.Enabled = false;
            txt_pais.Enabled = false;
            txt_estado.Enabled = false;
            txt_municipio.Enabled = false;
        }

        public void limipiar()
        {
            txt_Id.Text = "";
            txt_Nombre.Text = "";
            txt_nombre2.Text = "";
            txt_apellidon.Text = "";
            txt_apellidop.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
            txt_direccion.Text = "";
            txt_tusuario.Text = "";
            txt_estatus.Text = "";
            txt_pais.Text = "";
            txt_estado.Text = "";
            txt_municipio.Text = "";
        }
        public void ocultar_columnas()
        {
            dgvDatos.HeaderRow.Cells[5].Visible = false;
            dgvDatos.HeaderRow.Cells[6].Visible = false;
            dgvDatos.HeaderRow.Cells[7].Visible = false;
            dgvDatos.HeaderRow.Cells[8].Visible = false;
            dgvDatos.HeaderRow.Cells[11].Visible = false;
            dgvDatos.HeaderRow.Cells[12].Visible = false;
            dgvDatos.HeaderRow.Cells[13].Visible = false;

            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                dgvDatos.Rows[i].Cells[5].Visible = false;
                dgvDatos.Rows[i].Cells[6].Visible = false;
                dgvDatos.Rows[i].Cells[7].Visible = false;
                dgvDatos.Rows[i].Cells[8].Visible = false;
                dgvDatos.Rows[i].Cells[11].Visible = false;
                dgvDatos.Rows[i].Cells[12].Visible = false;
                dgvDatos.Rows[i].Cells[13].Visible = false;
            }
                

        }

        public void Grid ()
        {
            string sUrlRequest = "http://localhost:51437/SQL.asmx/Mostrar";
            var json = new WebClient().DownloadString(sUrlRequest);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));            
            dgvDatos.DataSource = dt;
            dgvDatos.DataBind();
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
            usu.Id = Convert.ToInt32(HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[0].Text));
            usu.Nombre = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[1].Text);
            usu.ApellidoP = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[2].Text);
            usu.ApellidoM = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[3].Text);
            usu.Correo = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[4].Text);
            usu.Foto = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[6].Text);
            usu.Telefono = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[7].Text);
            usu.Direccion = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[8].Text);
            usu.Tusuario = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[9].Text);
            usu.Estatus = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[10].Text);            
            usu.Pais = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[11].Text);
            usu.Estado = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[12].Text);
            usu.Municipio = HttpUtility.HtmlDecode(dgvDatos.SelectedRow.Cells[13].Text);

            txt_Id.Text = Convert.ToString(usu.Id);
            txt_Nombre.Text = usu.Nombre;
            txt_nombre2.Text = usu.Nombre;
            txt_apellidon.Text = usu.ApellidoM;
            txt_apellidop.Text = usu.ApellidoP;
            txt_correo.Text = usu.Correo;
            txt_telefono.Text = usu.Telefono;
            txt_direccion.Text = usu.Direccion;
            txt_tusuario.Text = usu.Tusuario;
            txt_estatus.Text = usu.Estatus;
            txt_pais.Text = usu.Pais;
            txt_estado.Text = usu.Estatus;
            txt_municipio.Text = usu.Municipio;
        }

        protected void btn_Eliminar_Click1(object sender, EventArgs e)
        {
            UsuarioAdmin usuario = new UsuarioAdmin();
            usuario.Id = int.Parse(txt_Id.Text);
            string sUrlRequest = "http://localhost:51437/SQL.asmx/Eliminar?id=" + usuario.Id;
            var json = new WebClient().DownloadString(sUrlRequest);

            txt_Id.Text = "";
            Grid();
            ocultar_columnas();
            limipiar();

        }
    }
}