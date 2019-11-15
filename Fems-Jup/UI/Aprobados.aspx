<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterP.Master" AutoEventWireup="true" CodeBehind="Aprobados.aspx.cs" Inherits="Fems_Jup.UI.Aprobados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <form runat="server">	    
             <div class="col-lg-8">
                <div class="card">
                    <div class="card-header"><strong>Usuarios Aprobados</strong><small> Form</small></div>
                    <div class="card-body card-block">
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="lbl_Id" runat="server" Text="Id:"></asp:Label><br />
                            <asp:TextBox ID="txt_Id"  class="form-control"  runat="server" placeholder="Id de usuario"></asp:TextBox><br />
                        </div>  
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="lbl_Nombre" runat="server" Text="Nombre:"></asp:Label><br />
                            <asp:TextBox ID="txt_Nombre" runat="server" placeholder="Nombre de usuario" class="form-control"></asp:TextBox><br />                                            
                        </div>                        
                        <div class="form-group">                            
                             <button type="button" class="btn btn-danger" data-toggle="modal" data-target="#exampleModal" style="background-color:#7F183A"">
                                Ver más
                            </button>
                        </div>                                                  
                    </div>                
                </div>
            </div>
                         <!-- Modal -->
            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
              <div class="modal-dialog" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Datos de Usuario</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                    </button>
                  </div>
                  <div class="modal-body">                        
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="Label2" runat="server" Text="Nombre:"></asp:Label><br />
                            <asp:TextBox ID="txt_nombre2" runat="server" placeholder="" class="form-control"></asp:TextBox><br />                                            
                        </div>        
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="Label3" runat="server" Text="Apellido Paterno:"></asp:Label><br />
                            <asp:TextBox ID="txt_apellidop" runat="server" placeholder="" class="form-control"></asp:TextBox><br />                                                              
                        </div>  
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="Label4" runat="server" Text="Apellido Materno:"></asp:Label><br />
                            <asp:TextBox ID="txt_apellidon" runat="server" placeholder="" class="form-control"></asp:TextBox><br />                                            
                        </div>        
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="Label5" runat="server" Text="Correo:"></asp:Label><br />
                            <asp:TextBox ID="txt_correo" runat="server" placeholder="" class="form-control"></asp:TextBox><br />                                                              
                        </div>
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="Label11" runat="server" Text="Teléfono:"></asp:Label><br />
                            <asp:TextBox ID="txt_telefono" runat="server" placeholder="" class="form-control"></asp:TextBox><br />                                            
                        </div>       
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="Label1" runat="server" Text="Dirección:"></asp:Label><br />
                            <asp:TextBox ID="txt_direccion" runat="server" placeholder="" class="form-control"></asp:TextBox><br />                                                              
                        </div>  
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="Label6" runat="server" Text="Tipo Usuario:"></asp:Label><br />
                            <asp:TextBox ID="txt_tusuario" runat="server" placeholder="" class="form-control"></asp:TextBox><br />                                            
                        </div>        
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="Label7" runat="server" Text="Estatus:"></asp:Label><br />
                            <asp:TextBox ID="txt_estatus" runat="server" placeholder="" class="form-control"></asp:TextBox><br />                                                              
                        </div>  
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="Label8" runat="server" Text="País:"></asp:Label><br />
                            <asp:TextBox ID="txt_pais" runat="server" placeholder="" class="form-control"></asp:TextBox><br />                                            
                        </div>        
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="Label9" runat="server" Text="Estado:"></asp:Label><br />
                            <asp:TextBox ID="txt_estado" runat="server" placeholder="" class="form-control"></asp:TextBox><br />                                                              
                        </div>  
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="Label10" runat="server" Text="Municipio:"></asp:Label><br />
                            <asp:TextBox ID="txt_municipio" runat="server" placeholder="" class="form-control"></asp:TextBox><br />                                            
                        </div>        
                  </div>
                  <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar" Click="btn_Eliminar_Click1" class="btn btn-danger" BackColor="#7F183A" OnClick="btn_Eliminar_Click1" />                    
                  </div>
                </div>
              </div>
            </div>
           
            <div class="col-lg-10">
                <asp:GridView ID="dgvDatos" runat="server" CellPadding="4" ForeColor="#ffffff" GridLines="None" OnRowDataBound="dgv_usuario_RowDataBound" OnSelectedIndexChanged="Seleccionar_registro">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#7F183A" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#7F183A " Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFFFFF" ForeColor="#7F183A" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFFFF" ForeColor="#7F183A" />
                    <SelectedRowStyle BackColor="#BD3D67" Font-Bold="True" ForeColor="#FFFFFF" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </div>     
 </form>
                                 <!-- Jquery JS-->
    <script src="../Recursos/vendor/jquery-3.2.1.min.js"></script>
    <!-- Bootstrap JS-->
    <script src="../Recursos/vendor/bootstrap-4.1/popper.min.js"></script>
    <script src="../Recursos/vendor/bootstrap-4.1/bootstrap.min.js"></script>
    <!-- Vendor JS       -->
    <script src="../Recursos/vendor/slick/slick.min.js">
    </script>
    <script src="../Recursos/vendor/wow/wow.min.js"></script>
    <script src="../Recursos/vendor/animsition/animsition.min.js"></script>
    <script src="../Recursos/vendor/bootstrap-progressbar/bootstrap-progressbar.min.js">
    </script>
    <script src="../Recursos/vendor/counter-up/jquery.waypoints.min.js"></script>
    <script src="../Recursos/vendor/counter-up/jquery.counterup.min.js">
    </script>
    <script src="../Recursos/vendor/circle-progress/circle-progress.min.js"></script>
    <script src="../Recursos/vendor/perfect-scrollbar/perfect-scrollbar.js"></script>
    <script src="../Recursos/vendor/chartjs/Chart.bundle.min.js"></script>
    <script src="../Recursos/vendor/select2/select2.min.js">
    </script>

    <!-- Main JS-->
    <script src="../Recursos/js/main.js"></script>
    <script src="../Recursos/js/app.js"></script>

                               
   
</asp:Content>
