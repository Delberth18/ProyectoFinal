<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="mantEventos.aspx.cs" Inherits="SurfTribeSystem1._0.mantEventos" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--principal-->
    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <br />
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="Label1" Font-Size="xX-Large" Text="Mantenimiento de eventos"></asp:Label></h2>

                    </div>
                </div>
            </div>
            <div class="row">


                <div class="col-xs-12">

                    <a aria-label="NuevaPreguntado" href="registroEvento.aspx">
                        <span aria-hidden="true" style="margin: 2px 2px 2px 2px; font-size: x-large; color: saddlebrown">Nuevo evento>></span>
                    </a>
                </div>
            </div>

            <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">
                <div class="row" style="margin: 4px 4px 4px 4px;">

                    <div class="col-sm-6 col-xs-12 accordionsTransparent" style="width: 100%">

                        <div class="review-aria">

                            <div class="reviewContent" style="margin: 8px 8px 8px 8px;">

                                <asp:ListView runat="server" ID="eventosLst">
                                    <ItemTemplate>

                                        <div class="reviewMedia">
                                            <ul class="media-list">
                                                <li class="media">
                                                    <div class="media-body">
                                                        <div class="row" style="border: solid; border-color: white">
                                                            <div class=" col-sm-7">
                                                                <ul>
                                                                    <li>

                                                                        <label style="color: SaddleBrown; font-size: x-large"><%# Eval("Titulo") %></label>
                                                                        <br />
                                                                        <div class="media" style="overflow-wrap: break-word">

                                                                            <p style="color: black; font-weight: bold"><%# Eval("Descripcion").ToString() %></p>

                                                                        </div>
                                                                    </li>
                                                                </ul>
                                                            </div>
                                                            <div class=" col-sm-4 ">
                                                                <ul>
                                                                    <li>
                                                                        <img src='data:image/jpg;base64,<%#Eval("Imagen") %>' width="330"  alt="" />
                                                                    </li>
                                                                </ul>
                                                            </div>
                                                            <br />
                                                        </div>
                                                        <a aria-label="Editar" style="border: solid; border-color: #ff891e; border-radius: 8px; border-width: thin">
                                                            <asp:LinkButton ID="noConfirmarBtn" CommandName='<%# Eval("Id") %>' Text="Eliminar" runat="server"
                                                                OnClick="eliminar_Click" aria-hidden="true" Style="margin: 2px 2px 2px 2px; color: darkred; font-weight: bold; font-size: medium" />
                                                        </a>    
                                                        <div class="row"></div>
                                                    </div>
                                                </li>

                                            </ul>
                                        </div>
                                        <br />

                                    </ItemTemplate>
                                </asp:ListView>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

        </div>
    </section>

</asp:Content>

