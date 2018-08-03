<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="registroEscuela.aspx.cs" Inherits="SurfTribeSystem1._0.registroEscuela" %>

<%@ MasterType VirtualPath="~/Site2.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- PAGE TITLE -->
    <%--    <section class="pageTitle" style="background-image: url(Imagenes/IMG-20171029-WA0010.jpeg); margin-top: 96px;">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="titleTable">
                        <div class="titleTableInner">
                            <div class="pageTitleInfo">
                                <br />
                                <br />
                                <br />
                                <h1>Registro de Escuelas</h1>
                                <div class="under-border"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>--%>

    <!--Contenido principal-->
    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                 <br />
          <div class="row">
                <div class="col-xs-12">
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="tituloLabel" Text="registro de escuelas" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                    </div>
                    
                </div>
            </div>
                <br />
                <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">
                    <div class="row">
                        <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li>
                                    <label style="color: SaddleBrown; font-size: x-large">Nombre:</label>

                                    <asp:TextBox ID="txtNombre" OnTextChanged="txtNombre_TextChanged" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                </li>
                                <li>
                                    <br />
                                </li>

                            </ul>

                        </div>

                        <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li>
                                    <label style="color: SaddleBrown; font-size: x-large">Ubicación:</label>

                                    <asp:TextBox ID="txtUbicacion" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                </li>
                                <li>
                                    <br />
                                </li>
                            </ul>
                        </div>

                        <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li>
                                    <label style="color: SaddleBrown; font-size: x-large">Zona:</label>
                                    <br />
                                    <asp:DropDownList ID="ddlZona" runat="server" CssClass="bg-ashh" Width="100%"  ForeColor="Black" style="font-size:large">
                                        <asp:ListItem>LIMON</asp:ListItem>
                                        <asp:ListItem>GUANACASTE</asp:ListItem>
                                        <asp:ListItem>PUNTARENAS</asp:ListItem>
                                    </asp:DropDownList>
                                </li>
                                <li>
                                    <br />
                                </li>

                            </ul>

                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li>
                                    <label style="color: SaddleBrown; font-size: x-large">Playa concurrida:</label>

                                    <asp:TextBox ID="txtPlaya" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                </li>
                            </ul>
                        </div>
                        <div class="col-xs-12 col-sm-8">
                            <ul>
                                <li>
                                    <label style="color: SaddleBrown; font-size: x-large">Descripción:</label>

                                    <asp:TextBox ID="txtDescripcion" runat="server" class="form-control  bg-ashh" TextMode="MultiLine"></asp:TextBox>
                                </li>
                            </ul>

                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li>
                                    <br />
                                    <label style="color: SaddleBrown; font-size: x-large">Año fundación:</label>

                                    <asp:TextBox ID="txtAnioFundacion" runat="server" class="form-control  bg-ashh" TextMode="number"></asp:TextBox>
                                </li>
                                <li>
                                    <br />
                                    <label style="color: SaddleBrown; font-size: x-large">Correo:</label>

                                    <asp:TextBox ID="txtCorreo" runat="server" class="form-control  bg-ashh" TextMode="Email"></asp:TextBox>
                                </li>
                                <li>
                                    <br />

                                    <label style="color: SaddleBrown; font-size: x-large">Telefono 1:</label>

                                    <asp:TextBox ID="txtTelefono1" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                </li>
                                <li>
                                    <br />
                                    <label style="color: SaddleBrown; font-size: x-large">Telefono 2:</label>

                                    <asp:TextBox ID="txtTelefono2" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                </li>
                            </ul>

                        </div>
                        <div class="col-xs-12 col-sm-8">
                            <ul>
                                <li>
                                    <img src="ccss/star-1-3/Static%20HTML/img/logo-grande.png" width="80%" />
                                </li>
                                <li>
                                    <asp:Button ID="btnGuardar" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White" runat="server" OnClick="btnGuardar_Click" Text="Guardar" Width="80%" />
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnGuardar" EventName="" />
            </Triggers>
        </asp:UpdatePanel>
    </section>

</asp:Content>
