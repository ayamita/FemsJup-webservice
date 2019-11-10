<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterP.Master" AutoEventWireup="true" CodeBehind="Aprobados.aspx.cs" Inherits="Fems_Jup.UI.Aprobados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <form runat="server">	    
     <asp:Button ID="btnInvocar" runat="server" Text="Invocar" OnClick="btnInvocar_Click" />
      <div class="container">
        <div class="panel panel-info">
            <div class="panel-heading"><h4>Result</h4></div>            
            <div class="panel-body"><div id="dvResults"></div></div>            
            <asp:GridView ID="dgvDatos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="dgv_usuario_RowDataBound" OnSelectedIndexChanged="Seleccionar_registro">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <br /><br />
            <asp:Label ID="lbl_Id" runat="server" Text="Id:"></asp:Label>
            <asp:TextBox ID="txt_Id" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txt_Nombre" runat="server"></asp:TextBox><br /><br />                        
            <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar" OnClick="btn_Eliminar_Click" />
        </div>
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
