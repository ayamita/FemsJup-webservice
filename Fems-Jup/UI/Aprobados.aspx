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
                            <asp:Label for="company" class=" form-control-label" ID="lbl_Id" runat="server" Text="Id:"></asp:Label>
                            <asp:TextBox ID="txt_Id" runat="server" placeholder="Id de usuario" class="form-control"></asp:TextBox>                                                              
                        </div>  
                        <div class="form-group">
                            <asp:Label for="company" class=" form-control-label" ID="lbl_Nombre" runat="server" Text="Nombre:"></asp:Label>
                            <asp:TextBox ID="txt_Nombre" runat="server" placeholder="Nombre de usuario" class="form-control"></asp:TextBox>                                            
                        </div>                        
                        <div class="form-group">
                            <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar" Click="btn_Eliminar_Click" class="btn btn-danger" BackColor="#7F183A" />
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
