<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="registroEvento.aspx.cs" Inherits="SurfTribeSystem1._0.registroEvento" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        
                <br />
                <div class="sectionTitle">
                    <h2>
                        <asp:Label runat="server" ID="Label1" Font-Size="xX-Large" Text="Registro de eventos"></asp:Label></h2>

                </div>
                <br />
                <div class="container">

                    <a aria-label="NuevaPreguntado" href="mantEventos.aspx">
                        <span aria-hidden="true" style="margin: 2px 2px 2px 2px; font-size: x-large; color: saddlebrown"><<-Listado</span>
                    </a>

                    <asp:Button class="btn btn-default" ID="btnGuardar" OnClick="btnGuardar_Click" runat="server" Style="padding: 15px; background-color: darkorange; color: white; 
                        font-family: Arial; text-transform: none; font-size: large; margin-left: 52%" Text=" Guardar evento "></asp:Button>

                    <br />
                    <br />




                    <div class="row">

                        <div class="form-group" style="box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px; padding: 15px 15px 15px 15px; width: 100%; background-color: white; background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg');">

                            <div class="row">
                                <div class=" col-sm-9">
                                    <ul>
                                        <li>
                                            <label style="color: saddlebrown; font-size: x-large">Título:</label>
                                            <asp:TextBox class="form-control  bg-ashh" ID="tituloText" runat="server" placeholder="Escriba el título" /><br />
                                        </li>
                                    </ul>
                                </div>
                                <div class=" col-sm-3">
                                    <ul>
                                        <li>
                                            <label style="color: saddlebrown; font-size: x-large">Imagen:</label>

                                            <asp:FileUpload ID="FileUpload" runat="server" class="form-control  bg-ashh" ClientIDMode="Static" />
                                            <br />
                                        </li>
                                    </ul>
                                </div>

                            </div>
                            <div class="row">
                                <div class=" col-sm-12">
                                    <ul>
                                        <li>
                                            <label style="color: saddlebrown; font-size: x-large">Descripción:</label>
                                            <asp:TextBox Rows="7" class="form-control bg-ashh" TextMode="MultiLine" ID="dscText" runat="server" placeholder="Escriba la descripción" /><br />
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>


                        <div>
                            <br />
                        </div>
                    </div>

                </div>
    </section>



</asp:Content>
