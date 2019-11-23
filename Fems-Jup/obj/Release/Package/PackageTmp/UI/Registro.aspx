<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/login.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Fems_Jup.UI.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    
    <script>
          function cambia_nombre() {
              var fileName = $("#<%=fuPerfil2.ClientID %>").val();
            $("#<%=fuPerfil2.ClientID%>").next('.custom-file-label').html(fileName);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
     <div class="col-md-12" >
        <div class="col-md-12">                       
                <div class="card-header"  style="background-color:#970664;color:#ffffff" >
                    <strong>Registrar Administrador</strong> 
                </div>
               <div class="card-body card-block">                                                        
                        <div class="row form-group">
                        <div class="col-12 col-md-4"><asp:TextBox ID="txtid" runat="server" class="form-control" Visible="false"></asp:TextBox></div>                                                                
                            <asp:TextBox ID="txtfoto_usuario" runat="server" Visible="False"></asp:TextBox> 
                        </div>
                        <div class="row form-group">
                            <div class="col col-md-2"><label class=" form-control-label">Nombre: </label></div>                                            
                            <div class="col-12 col-md-10">
                                <input runat="server" type="text" id="txt_nombre" name="text-input" placeholder="" class="form-control"/><small class="form-text text-muted"></small>   
                            </div>   
                            </div>
                   <div class="row form-group">
                            <div class="col col-md-2"><label for="text-input" class=" form-control-label">Apellido Paterno:</label></div>
                            <div class="col-12 col-md-4">
                                <input runat="server" type="text" id="txt_ap" name="text-input" placeholder="" class="form-control"/><small class="form-text text-muted"></small>
                            </div>

                            <div class="col col-md-2"><label for="text-input" class=" form-control-label">Apellido Materno:</label></div>
                            <div class="col-12 col-md-4">
                                <input runat="server" type="text" id="txt_am" name="text-input" placeholder="" class="form-control"/><small class="form-text text-muted"></small> 
                            </div>
                        </div>
                   <div class="row form-group">
                            <div class="col col-md-2"><label for="text-input" class=" form-control-label">Dirección:</label></div>
                            <div class="col-12 col-md-4">
                                <input runat="server" type="tel" id="txt_dir" name="text-input" placeholder="" class="form-control"/><small class="form-text text-muted" ></small>                                
                            </div>
                       <div class="col col-md-2"><label for="text-input" class=" form-control-label">Teléfono:</label></div>
                            <div class="col-12 col-md-4">
                                <input runat="server" type="tel" id="txt_tel" name="text-input" placeholder="" class="form-control"/><small class="form-text text-muted" ></small>                                
                            </div>
                       </div>
                    <div class="row form-group">
                            <div class="col col-md-2"><label for="selectSm" class=" form-control-label">País:</label></div>
                            <div class="col-12 col-md-4">
                                <asp:DropDownList ID="DropDownList2" class="form-control-sm form-control" runat="server"  AutoPostBack="true" Height="36px"></asp:DropDownList>                                
                            </div>
                            <div class="col col-md-2"><label for="selectSm" class=" form-control-label">Estado:</label></div>
                            <div class="col-12 col-md-4">
                                <asp:DropDownList ID="DropDownList3" class="form-control-sm form-control" runat="server"  AutoPostBack="true" Height="35px"></asp:DropDownList>
                            </div>
                        </div> 
                         <div class="row form-group">
                            <div class="col col-md-2"><label for="selectSm" class=" form-control-label">Municipio:</label></div>
                            <div class="col-12 col-md-4">
                             <asp:DropDownList ID="DropDownList4" class="form-control-sm form-control" runat="server"  AutoPostBack="true" Height="36px"></asp:DropDownList>                                
                            </div>
                             <div class="col col-md-2"><label for="text-input" class=" form-control-label">Foto:</label></div>
                            <div class="col-12 col-md-4"><small class="help-block form-text"><asp:FileUpload ID="fuPerfil2" runat="server" onchange="javascript:cambia_nombre()" /></small></div>
                        </div>
                   <div class="row form-group">
                            <div class="col col-md-2"><label for="email-input" class=" form-control-label">Email:</label></div>
                            <div class="col-12 col-md-4">
                                <input  runat="server" type="email" id="txt_email" name="email-input" placeholder="" class="form-control"/><small class="help-block form-text"></small>
                               
                            </div>
                            <div class="col col-md-2"><label for="text-input" class=" form-control-label">Contraseña:</label></div>
                       <div class="col-12 col-md-4">
                                <input runat="server" type="password" id="txt_contra" name="password-input" placeholder="" class="form-control"/><small class="help-block form-text"></small>
                               
                            </div>
                   </div>  
                   <div class="col-md-12">                                        
                        <div class="col-md-4">
                        </div>
                        <div class="col-md-5">                                       
                            <br />                                      
                                    <asp:Button ID="btn_agregar" runat="server" Text="Crear Cuenta" class="btn" style="background-color:#790851;color:#fff" />                                                    
                                    <asp:Button ID="btn_limpiar" runat="server" Text="Limpiar"  class="btn" style="background-color:#790851;color:#fff"/>
                                    <asp:Button ID="btn_modificar" runat="server" Text="Modificar"  class="btn" style="background-color:#790851;color:#fff"/>
                                    <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar"  class="btn" style="background-color:#790851;color:#fff"/>
                                      
                            <br /> 
                        </div>                        
                    </div>      
            </div>
         </div>
</asp:Content>
