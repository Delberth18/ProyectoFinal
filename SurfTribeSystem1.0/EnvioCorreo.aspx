<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="EnvioCorreo.aspx.cs" Inherits="SurfTribeSystem1._0.EnvioCorreo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
      
                <br />
                <div class="row">
                    <div class="col-xs-12">
                        <div class="sectionTitle">
                            <h2>
                                <asp:Label runat="server" ID="tituloLabel" Text="Envío de correos" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                        </div>

                    </div>
                </div>
                <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">

                    <div>
                        <div class="col-xs-12 col-sm-8">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Asunto:</label>

                                    <asp:TextBox ID="asuntoText" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                </li>
                            </ul>

                        </div>
                        <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li>
                                    <br />
                                    <asp:Button ID="btnEnviar" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White" OnClick="btnEnviar_Click" runat="server" Text="Enviar" Width="150px" />

                                </li>
                            </ul>

                        </div>

                        <div class="col-xs-12 col-sm-11">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Mensaje:</label>

                                    <asp:TextBox ID="mensajeText" runat="server" class="form-control  bg-ashh" TextMode="MultiLine" Rows="14"></asp:TextBox>
                                </li>
                                <li>
                                    <label style="color: darkred; font-size: x-small">**El correo será enviado a todos los usuarios.</label>
                                </li>
                            </ul>

                        </div>
                    </div>


                </div>
    </section>





</asp:Content>
