<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Aprobados.aspx.cs" Inherits="Fems_Jup.UI.Aprobados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <form runat="server">
    <div class="col-md-4">
                                <div class="card">
                                    <div class="card-header bg-success">
                                        <strong class="card-title text-light">Card Header</strong>
                                    </div>
                                    <div class="card-body text-white bg-warning">
                                        <p class="card-text text-light">Some quick example text to build on the card title and make up the bulk of the card's
                                            content.
                                        </p>
                                    </div>
                                </div>
                            </div>


    <div class="form-group">
	    <asp:Button ID="btnConsulta" runat="server" Text="Consulta" class="btn float-right login_btn" OnClick="btnConsulta_Click"  />
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
