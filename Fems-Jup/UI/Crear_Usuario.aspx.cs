using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using Fems_Jup.BO;
using System.Net;

namespace Fems_Jup.UI
{
    public partial class Crear_Usuario : System.Web.UI.Page
    {
        conexion objConectar = new conexion();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IniciarLlenarDropDown();
            }
        }

        private void IniciarLlenarDropDown()
        {
            dpd_Pais.DataSource = objConectar.Consulta("select * from Pais");
            dpd_Pais.DataValueField = "Id_pais";
            dpd_Pais.DataTextField = "Pais";
            dpd_Pais.DataBind();
            dpd_Pais.Items.Insert(0, new ListItem("[Seleccionar]","0"));
            dpd_Estado.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            dpd_Municipio.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            dpd_Pais.SelectedIndex = 0;

            dpd_tusuario.DataSource = objConectar.Consulta("select * from Tipo_Usuario where id_tipousuario=1");
            dpd_tusuario.DataValueField = "id_tipousuario";
            dpd_tusuario.DataTextField = "TipoUsuario";
            dpd_tusuario.DataBind();            
            dpd_tusuario.SelectedIndex = 0;
            

            dpd_estatus.DataSource = objConectar.Consulta("select * from Estatus where id_estatus=1");
            dpd_estatus.DataValueField = "id_estatus";
            dpd_estatus.DataTextField = "estatus";
            dpd_estatus.DataBind();            
            dpd_estatus.SelectedIndex = 0;
        }


        protected void Estado_Seleccionado(object sender, EventArgs e)
        {
            int EstadoID = Convert.ToInt32(dpd_Estado.SelectedValue);
            dpd_Municipio.DataSource = objConectar.Consulta("select * from Municipio where id_estado=" + EstadoID);
            dpd_Municipio.DataValueField = "id_municipio";
            dpd_Municipio.DataTextField = "municipio";
            dpd_Municipio.DataBind();
            dpd_Municipio.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            dpd_Municipio.SelectedIndex = 0;
        }

        protected void Pais_Seleccionado(object sender, EventArgs e)
        {
            int PaisID = Convert.ToInt32(dpd_Pais.SelectedValue);
            dpd_Estado.DataSource = objConectar.Consulta("select * from Estado where id_pais1="+PaisID);
            dpd_Estado.DataValueField = "id_estado";
            dpd_Estado.DataTextField = "estado";
            dpd_Estado.DataBind();
            dpd_Estado.Items.Insert(0, new ListItem("[Seleccionar]", "0"));            
            dpd_Estado.SelectedIndex = 0;
        }

        protected void Municipio_Seleccionado(object sender, EventArgs e)
        {

        }

        protected void Tusuario_Seleccionado(object sender, EventArgs e)
        {

        }

        protected void Estatus_Seleccionado(object sender, EventArgs e)
        {

        }
      

        protected void Crear(object sender, EventArgs e)
        {
            UsuarioAdmin BO = new UsuarioAdmin();
            BO.Nombre = txt_nombre2.Value;
            BO.ApellidoP = txt_apellidop.Value;
            BO.ApellidoM = txt_apellidom.Value;
            BO.Correo = txt_correo.Value;
            BO.Contrasenia = txt_password.Value;
            BO.Telefono = txt_telefono.Value;
            BO.Direccion = txt_direccion.Value;
            BO.Tusuario = dpd_tusuario.SelectedValue;
            BO.Estatus = dpd_estatus.SelectedValue;
            BO.Pais = dpd_Pais.SelectedValue;
            BO.Estado = dpd_Estado.SelectedValue;
            BO.Municipio = dpd_Municipio.SelectedValue;

            //SI EXISTE ARCHIVO EN EL CONTROL
            if (fuPerfil.HasFile)
            {
                //validar extensiones aceptadas
                //OBTIENE LA EXTENSION DEL ARCHIVO
                String fileExtension = Path.GetExtension(fuPerfil.FileName).ToLower();

                //ARREGLO TIPO STRING DE EXTENSIONES.
                String[] Exten_validas = { ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < Exten_validas.Length; i++)
                {
                    //si la extensión es alguna de las válidas
                    if (fileExtension == Exten_validas[i])
                    {
                        System.Drawing.Image ObjetoImagen;
                        string NombreArchivoPequenio = "_" + Path.GetFileName(fuPerfil.PostedFile.FileName.Replace("_", ""));
                        BO.Foto = NombreArchivoPequenio;
                        string RutaImagenes = "~/Resourse/images/fotosperfil/";
                        Bitmap ImagenEnBinario = new Bitmap(fuPerfil.PostedFile.InputStream);
                        ObjetoImagen = BO.RedimencionarImagen(ImagenEnBinario, 200);
                        switch (fileExtension)
                        {
                            case ".png":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + NombreArchivoPequenio, ImageFormat.Png);

                                break;
                            case ".jpg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                            case ".jpeg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                        }
                    }
                }

            }
            else
            {
                BO.Foto = "";
            }

            string sUrlRequest = "http://localhost:51437/SQL.asmx/Crear_Usuario?nombre="+ BO.Nombre + "&apellidop=" + BO.ApellidoP +
                "&apellidom=" + BO.ApellidoM + "&correo=" + BO.Correo + "&contrasenia=" + BO.Contrasenia + "&foto=" + BO.Foto + "&telefono=" + BO.Telefono +
                "&direccion=" + BO.Direccion + "&tusuario=" + BO.Tusuario + "&estatus=" + BO.Estatus + "&pais=" + BO.Pais + 
                "&estado=" + BO.Estado + "&municipio=" + BO.Municipio;
            var json = new WebClient().DownloadString(sUrlRequest);
            Limpiar();
        }
      

        private void Limpiar()
        {            
            txt_nombre2.Value = "";
            txt_apellidom.Value = "";
            txt_apellidop.Value = "";
            txt_correo.Value = "";
            txt_telefono.Value = "";
            txt_direccion.Value = "";            
            dpd_Pais.SelectedIndex = 0;
            dpd_Estado.SelectedIndex = 0;
            dpd_Municipio.SelectedIndex = 0;
        }

        protected void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}