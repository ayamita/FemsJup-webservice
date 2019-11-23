<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterP.Master" AutoEventWireup="true" CodeBehind="No_Aprobados.aspx.cs" Inherits="Fems_Jup.UI.No_Aprobados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
               <form runat="server">	    
             <div class="col-lg-8">
                <div class="card">
                    <div class="card-header"><strong>Usuarios Aprobados</strong><small> Form</small></div>
                    <div class="card-body card-block">
                        <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Id:</label></div>
                            <div class="col-12 col-md-9"><input type="text" id="txt_Id"  runat="server"  name="text-input" placeholder="Id de usuario" class="form-control"  disabled></div>
                        </div>
                        <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Nombre:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_Nombre" runat="server"  name="text-input" placeholder="Nombre de usuario" class="form-control"  disabled></div>
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
                      <div class="row form-group" >                            
                          <div class="col col-md-2"></div>
                          <div class="col-12 col-md-10"><asp:Image ID="foto_perfil" runat="server" Height="222px" class="img-thumbnail" /></div>
                        </div> 
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Nombre:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_nombre2" runat="server"  name="text-input" placeholder="Nombre de usuario" class="form-control"  disabled></div>
                        </div>                  
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Apellido Paterno:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_apellidop" runat="server"  name="text-input" placeholder="Apellido Paterno" class="form-control"  disabled></div>
                        </div>                        
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Apellido Materno:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_apellidom" runat="server"  name="text-input" placeholder="Apellido Materno" class="form-control"  disabled></div>
                        </div>                                                
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Correo:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_correo" runat="server"  name="text-input" placeholder="Correo de Usuario" class="form-control"  disabled></div>
                        </div>                                              
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Teléfono:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_telefono" runat="server"  name="text-input" placeholder="Teléfono" class="form-control"  disabled></div>
                        </div>                                                                        
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Dirección:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_direccion" runat="server"  name="text-input" placeholder="Dirección" class="form-control"  disabled></div>
                        </div>                        
                       <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Tipo Usuario:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_tusuario" runat="server"  name="text-input" placeholder="Tipo Usuario" class="form-control"  disabled></div>
                        </div>                             
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Estatus:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_estatus" runat="server"  name="text-input" placeholder="Estatus" class="form-control"  disabled></div>
                        </div>                                                     
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">País:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_pais" runat="server"  name="text-input" placeholder="País" class="form-control"  disabled></div>
                        </div>                             
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">Estado:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_estado" runat="server"  name="text-input" placeholder="Estado" class="form-control"  disabled></div>
                        </div>                  
                      <div class="row form-group">
                            <div class="col col-md-3"><label for="text-input" class=" form-control-label">País:</label></div>
                            <div class="col-12 col-md-9"><input type="text" ID="txt_municipio" runat="server"  name="text-input" placeholder="Municipio" class="form-control"  disabled></div>
                        </div>                                           
                  </div>
                  <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button ID="btn_aprobar" runat="server" Text="Aprobar"  class="btn btn-danger" BackColor="#7F183A" OnClick="btn_Aprobar" />                    
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
