using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Fems_Jup.BO;
using Newtonsoft.Json;
using System.Data;
using System.Net;

namespace Fems_Jup.UI
{
    public partial class Aprobados : System.Web.UI.Page
    {
        UsuarioAdmin usu = new UsuarioAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {
            Grid();
            ocultar_columnas();
        }

        public void foto()
        {
            UsuarioAdmin usuario = new UsuarioAdmin();
            usuario.Id = int.Parse(txt_Id.Value);
            string sUrlRequest = "http://femsjup.somee.com/SQL.asmx/Eliminar?id=" + usuario.Id;
            var json = new WebClient().DownloadString(sUrlRequest);
        }

        public void limipiar()
        {
            txt_Id.Value = "";
            txt_Nombre.Value = "";
            txt_nombre2.Value = "";
            txt_apellidom.Value = "";
            txt_apellidop.Value = "";
            txt_correo.Value = "";
            txt_telefono.Value = "";
            txt_direccion.Value = "";
            txt_tusuario.Value = "";
            txt_estatus.Value = "";
            txt_pais.Value = "";
            txt_estado.Value = "";
            txt_municipio.Value = "";
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

        public void Grid()
        {
            string sUrlRequest = "http://femsjup.somee.com/SQL.asmx/Mostrar_aprobados";
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


            txt_Id.Value = Convert.ToString(usu.Id);
            txt_Nombre.Value = usu.Nombre;
            txt_nombre2.Value = usu.Nombre;
            txt_apellidom.Value = usu.ApellidoM;
            txt_apellidop.Value = usu.ApellidoP;
            txt_correo.Value = usu.Correo;
            txt_telefono.Value = usu.Telefono;
            txt_direccion.Value = usu.Direccion;
            txt_tusuario.Value = usu.Tusuario;
            txt_estatus.Value = usu.Estatus;
            txt_pais.Value = usu.Pais;
            txt_estado.Value = usu.Estatus;
            txt_municipio.Value = usu.Municipio;

            UsuarioAdmin obj = new UsuarioAdmin();           
            string sUrlRequest = "http://femsjup.somee.com/SQL.asmx/FotoAP?id=" + usu.Id;
            var json = new WebClient().DownloadString(sUrlRequest);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
           
            DataRow row = dt.Rows[0];
            string foto = row["foto"].ToString();     
            string ruta = "~/Resourse/images/fotosperfil/" + foto;
            foto_perfil.ImageUrl = ruta;


        }     

        protected void btn_Eliminar_Click1(object sender, EventArgs e)
        {
            UsuarioAdmin usuario = new UsuarioAdmin();
            usuario.Id = int.Parse(txt_Id.Value);
            string sUrlRequest = "http://femsjup.somee.com/SQL.asmx/Eliminar?id=" + usuario.Id;
            var json = new WebClient().DownloadString(sUrlRequest);

            txt_Id.Value = "";
            Grid();
            ocultar_columnas();
            limipiar();

        }        
    }
}
