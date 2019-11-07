<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Aprobados.aspx.cs" Inherits="Fems_Jup.UI.Aprobados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <form runat="server">	    
     <button class="btn btn-primary" id="btnConsulta" type="button"><i class="fa fa-search" aria-hidden="true"></i> Search</button>
      <div class="container">
        <div class="panel panel-info">
            <div class="panel-heading"><h4>Result</h4></div>
            <div class="panel-body"><div id="dvResults"></div></div>
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
