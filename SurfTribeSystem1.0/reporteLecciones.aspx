<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reporteLecciones.aspx.cs" Inherits="SurfTribeSystem1._0.reporteLecciones" %>


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
        <br />
        <div class="row">
            <div class="col-xs-12">
                <div class="sectionTitle">
                    <h2>
                        <asp:Label runat="server" ID="tituloLabel" Text="Reporte de sesiones " BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                </div>

            </div>
        </div>
        <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div>
                        
                        <div class="col-xs-12 col-sm-3">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Dificultad:</label>
                                </li>
                                <li>
                                    <asp:DropDownList ID="dificultadLst" runat="server" CssClass="bg-ashh" Width="100%" AutoPostBack="true" DataTextField=""
                                        DataValueField="" OnSelectedIndexChanged="reportSesion" ForeColor="Black" Style="font-size: large">
                                    </asp:DropDownList>
                                </li>
                            </ul>
                        </div>

                        <div class="col-xs-12 col-sm-3">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Fecha:</label>
                                </li>
                                <li>

                                    <asp:DropDownList ID="fechalst" runat="server" CssClass="bg-ashh" Width="100%" AutoPostBack="true" DataTextField=""
                                        DataValueField="" OnSelectedIndexChanged="reportSesion" ForeColor="Black" Style="font-size: large">
                                    </asp:DropDownList>

                                </li>
                            </ul>

                        </div>
                        <div class="col-xs-12 col-sm-3">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Instructor:</label>
                                </li>
                                <li>

                                    <asp:DropDownList ID="instructorlst" runat="server" CssClass="bg-ashh" Width="100%" AutoPostBack="true" DataTextField=""
                                        DataValueField="" OnSelectedIndexChanged="reportSesion" ForeColor="Black" Style="font-size: large">
                                    </asp:DropDownList>

                                </li>
                            </ul>

                        </div>
                        <div class="col-xs-12 col-sm-3">
                            <ul>
                                <li>
                                    <br />
                                    <asp:Button ID="btnRefrescar" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White"
                                        runat="server" Text="Refrescar" Width="150px" OnClick="reportSesion" />
                                </li>

                            </ul>

                        </div>
                    </div>

                    

                        <div class="col-xs-12">
                            <br />
                            <div class="col-md-12">
                                <div class="col-md-3" style="color: saddlebrown; text-align: start; font-size: x-large; font-weight: bold">
                                    Instructor
                                </div>
                                <div class="col-md-2" style="color: saddlebrown; text-align: start; font-size: x-large; font-weight: bold">
                                    Fecha
                                </div>
                                <div class="col-md-2" style="color: saddlebrown; text-align: start; font-size: x-large; font-weight: bold">
                                    Dificultad
                                </div>
                                <div class="col-md-2" style="color: saddlebrown; text-align: start; font-size: x-large; font-weight: bold">
                                    Hora inicio
                                </div>
                                <div class="col-md-2" style="color: saddlebrown; text-align: start; font-size: x-large; font-weight: bold">
                                    Hora final
                                </div>
                                <div class="col-md-1" style="color: saddlebrown; text-align: start; font-size: x-large; font-weight: bold">
                                    Estado
                                </div>
                            </div>
                            <asp:Repeater ID="infoLst" runat="server">

                                <ItemTemplate>
                                    <div class="col-md-12" style="border-bottom: solid; border-color: saddlebrown; border-width: 2px">
                                        <div class="col-md-3" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: start; font-size: medium"><%# Eval("Nombre") %>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-md-2" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: start; font-size: medium"><%# Eval("FechaBasica") %>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-md-2" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: start; font-size: medium"><%# Eval("Dificultad") %>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-md-2" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: start; font-size: medium"><%# Eval("HraInicio1") %>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-md-2" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: start; font-size: medium"><%# Eval("HraFinal1") %>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-md-1" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: start; font-size: medium"><%# Eval("EstaActiva") %> 
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <br />
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                        </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="dificultadLst" EventName="" />
                    <asp:AsyncPostBackTrigger ControlID="fechalst" EventName="" />
                    <asp:AsyncPostBackTrigger ControlID="instructorlst" EventName="" />
                </Triggers>
            </asp:UpdatePanel>
                        <div class="col-xs-12">
                            <br />
                            <asp:Button ID="btnGenerar" class="btn btn-default btn-circle-2 " BackColor="SaddleBrown" ForeColor="White"
                                runat="server" Text="Generar Reporte" Width="200px" OnClick="GenerarReporte" />
                        </div>
                    </div>
                

        </div>

    </section>
</asp:Content>