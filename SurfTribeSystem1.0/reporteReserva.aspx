<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reporteReserva.aspx.cs" Inherits="SurfTribeSystem1._0.reporteReserva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <script src="ccss/star-1-3/SCSS/js/jquery-2.1.4.min.js"></script>
    <script src="ccss/star-1-3/SCSS/js/jspdf.debug.js"></script>
    <style type="text/css">
        .form_input {
            font-family: Verdana;
            font-size: 12;
            background-color: white;
            border-width: 0;
            text-align: right;
        }
       
     
    </style>
    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <br /><br /><br />
        <div class="row">
            <div class="col-xs-12">
                <div class="sectionTitle">
                    <h2>
                        <asp:Label runat="server" ID="tituloLabel" Text="Reporte de Reservas Realizadas" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                </div>

            </div>
        </div><br />
        <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div style="text-align: center;  color: saddlebrown;" >
                        
                       

                      <asp:Label ID="lblEti" runat="server"   Text="No has realizado reservas" Visible="false" Font-Size="XX-Large" Font-Bold="true"></asp:Label>

                    <center>

                        <div class="col-xs-13" style="text-align: center;">
                            <br />
                                      <asp:GridView ID="grvreportes" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" CssClass="" BackColor="White" BorderColor="SaddleBrown"
                                                                                BorderStyle="None" BorderWidth="1px" CellPadding="3"  
                                                                                SelectedIndex="0" HeaderStyle-HorizontalAlign="Center" RowHeaderColumn="center" SortedAscendingHeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="40%">
                                                                                <Columns>


                                                                                    <asp:BoundField DataField="FECHA" HeaderText="Fecha"  HeaderStyle-HorizontalAlign="Center" ></asp:BoundField>
                                                                                    <asp:BoundField DataField="NOMBREUSU" HeaderText="Alumno(a)" ReadOnly="True" HeaderStyle-Width="20%  "></asp:BoundField>
                                                                                    <asp:BoundField DataField="IDESCUELA" HeaderText="Escuela"></asp:BoundField>
                                                                                    <asp:BoundField HeaderText="Dificultad" DataField="DIFICULTAD"></asp:BoundField>
                                                                                    <asp:BoundField HeaderText="Instructor(a)" DataField="NOMBREINS"></asp:BoundField>
                                                                                    <asp:BoundField HeaderText="Hra Inicio" DataField="HORAINICIO"></asp:BoundField>
                                                                                    <asp:BoundField HeaderText="Alquiler" DataField="MARCA"></asp:BoundField>
                                                                                    <asp:BoundField HeaderText="Precio Alquiler" DataField="PRECIORESERVA"></asp:BoundField>
                                                                                    <asp:BoundField HeaderText="Precio Clase" DataField="PRECIOCL"></asp:BoundField>
                                                                                    <asp:BoundField HeaderText="Total" DataField="PRECIOTOTAL"></asp:BoundField>
                                                                                    <asp:BoundField HeaderText="Estado" DataField="ESTADO"></asp:BoundField>
                                                                                </Columns>


                                                                                <FooterStyle BackColor="White" ForeColor="#000066"></FooterStyle>

                                                                                <HeaderStyle BackColor="DarkOrange" Font-Bold="True" ForeColor="White"   HorizontalAlign="Center" ></HeaderStyle>
                                                                                <PagerStyle HorizontalAlign="Center" BackColor="White" ForeColor="#000066"></PagerStyle>

                                                                                <RowStyle ForeColor="SaddleBrown" Font-Bold="true" ></RowStyle>

                                                                                

                                                                                <SortedAscendingCellStyle BackColor="#F1F1F1"></SortedAscendingCellStyle>

                                                                                <SortedAscendingHeaderStyle BackColor="#007DBB"></SortedAscendingHeaderStyle>

                                                                                <SortedDescendingCellStyle BackColor="#CAC9C9"></SortedDescendingCellStyle>

                                                                                <SortedDescendingHeaderStyle BackColor="#00547E"></SortedDescendingHeaderStyle>
                                                                            </asp:GridView>
                           
                       
                        

                        </div>
                        </center>
                        </ContentTemplate>
                <Triggers>
                    
                </Triggers>
            </asp:UpdatePanel> 
                    </div><br /><br />
                <asp:Button ID="btnGenerar" class="btn btn-default btn-circle-2 " BackColor="SaddleBrown" ForeColor="White"
                                runat="server" Text="Generar Reporte" Width="200px"  OnClick="GenerarReporte" />
        <br />
    </section>
</asp:Content>
