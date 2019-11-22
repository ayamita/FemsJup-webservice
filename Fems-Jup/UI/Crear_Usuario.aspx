<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterP.Master" AutoEventWireup="true" CodeBehind="Crear_Usuario.aspx.cs" Inherits="Fems_Jup.UI.Crear_Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form runat="server" method="post" enctype="multipart/form-data" class="form-horizontal">    
          <div class="col-lg-11">
            <div class="card">
                <div class="card-header"><strong>Crear Usuario Adminisrador</strong><small> Form</small></div>
                    <div class="modal-body">                                                                  
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Nombre:</label></div>
                            <div class="col-12 col-md-3"><input type="text" ID="txt_nombre2" runat="server"  name="text-input" placeholder="Nombre de usuario" class="form-control" ></div>                            
                        </div>                                                        
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Apellido Paterno:</label></div>
                            <div class="col-12 col-md-3"><input type="text" ID="txt_apellidop" runat="server"  name="text-input" placeholder="Apellido Paterno" class="form-control"  ></div>
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Apellido Materno:</label></div>
                            <div class="col-12 col-md-3"><input type="text" ID="txt_apellidom" runat="server"  name="text-input" placeholder="Apellido Materno" class="form-control"  ></div>                            
                        </div>                    
                      <div class="row form-group">
                          <div class="col col-md-3"><label for="text-input" class=" form-control-label">País:</label></div>
                          <div class="col col-md-3"><asp:DropDownList ID="dpd_Pais" runat="server" OnSelectedIndexChanged="Pais_Seleccionado" class="form-control" AutoPostBack="True"></asp:DropDownList></div>
                          <div class="col col-md-3"><label for="text-input" class=" form-control-label">Estado:</label></div>
                          <div class="col col-md-3"><asp:DropDownList ID="dpd_Estado" runat="server" OnSelectedIndexChanged="Estado_Seleccionado" class="form-control" AutoPostBack="True"></asp:DropDownList></div>
                        </div>                                                  
                      <div class="row form-group">
                          <div class="col col-md-3"><label for="text-input" class=" form-control-label">País:</label></div>
                          <div class="col col-md-3"><asp:DropDownList ID="dpd_Municipio" runat="server" OnSelectedIndexChanged="Municipio_Seleccionado" class="form-control"></asp:DropDownList></div>                          
                        </div>
                      <div class="row form-group">
                          <div class="col col-md-3"><label for="text-input" class=" form-control-label">Correo:</label></div>
                          <div class="col-12 col-md-3"><input type="text" ID="txt_correo" runat="server"  name="text-input" placeholder="Correo de Usuario" class="form-control" ></div>
                          <div class="col col-md-3"><label for="text-input" class=" form-control-label">Contraseña:</label></div>
                          <div class="col-12 col-md-3"><input type="password" ID="txt_password" runat="server"  name="password3" placeholder="Contraseña" class="form-control"  ></div>                                         
                       </div>
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Teléfono:</label></div>
                            <div class="col-12 col-md-3"><input type="text" ID="txt_telefono" runat="server"  name="text-input" placeholder="Teléfono" class="form-control"  ></div>
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Dirección:</label></div>
                            <div class="col-12 col-md-3"><input type="text" ID="txt_direccion" runat="server"  name="text-input" placeholder="Dirección" class="form-control"  ></div>
                        </div>                                                                                                  
                       <div class="row form-group">
                          <div class="col col-md-3"><label for="text-input" class=" form-control-label">Tipo de Usuario:</label></div>
                          <div class="col col-md-3"><asp:DropDownList ID="dpd_tusuario" runat="server" OnSelectedIndexChanged="Tusuario_Seleccionado" class="form-control"></asp:DropDownList></div>
                          <div class="col col-md-3"><label for="text-input" class=" form-control-label">Estatus:</label></div>
                          <div class="col col-md-3"><asp:DropDownList ID="dpd_estatus" runat="server" OnSelectedIndexChanged="Estatus_Seleccionado" class="form-control"></asp:DropDownList></div>
                        </div>                                                                                                                                  
                      <div class="row form-group">  
                          <div class="col col-md-3"><label for="text-input" class=" form-control-label">Subir foto:</label></div>
                          <div class="col col-md-3"><asp:FileUpload ID="fuPerfil" runat="server" onchange="javascript:cambia_nombre()" /></div><br /><br />
                        </div>      
                  </div>
                  <div class="modal-footer">
                      <asp:Button ID="btn_Limpiar" runat="server" Text="Limpiar" class="btn btn-danger" BackColor="#7F183A" OnClick="btn_Limpiar_Click"/> 
                      <asp:Button ID="btn_Crear" runat="server" Text="Crear Usuario" class="btn btn-danger" BackColor="#7F183A" OnClick="Crear" />                                                           
                  </div>                                                            
                </div>
              </div>            
            </form>
</asp:Content>
