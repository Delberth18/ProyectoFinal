<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="mantComentarios.aspx.cs" Inherits="SurfTribeSystem1._0.mantComentarios" %>

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
                            <asp:Label runat="server" ID="Label1" Font-Size="xX-Large" Text="Mantenimiento de comenterios"></asp:Label></h2>

                    </div>
                    <h4>
                        <asp:Label runat="server" ID="info1" Text="Comentarios faltantes de revisión"></asp:Label></h4>
                </div>
            </div>

            <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">
                <div class="row" style="margin: 4px 4px 4px 4px;">

                    <div class="col-sm-6 col-xs-12 accordionsTransparent" style="width: 100%">

                        <div class="review-aria">

                            <div class="reviewContent" style="margin: 8px 8px 8px 8px;">
                                <h3 style="color: SaddleBrown; font-size: x-large;">Opiniones
                                        <asp:Label ForeColor="SaddleBrown" Font-Size="Large" runat="server" ID="cantidadLabel"></asp:Label>
                                </h3>
                                <asp:ListView runat="server" ID="preguntasLst">
                                    <ItemTemplate>

                                        <div class="reviewMedia">
                                            <ul class="media-list">
                                                <li class="media">
                                                    <div class="media-body">
                                                        <h4 class="media-heading">
                                                            <asp:Label runat="server" Font-Size="X-Large" ForeColor="White" ID="preguntaLabel" Text='<%# Eval("Nombre") %>'></asp:Label></h4>

                                                        <p>
                                                            <asp:Label ForeColor="#333333" runat="server" Font-Size="X-Large" ID="Label2" Text='<%# Eval("Comentariol") %>'></asp:Label>
                                                        </p>
                                                        <a aria-label="Editar" style="border: solid; border-color: #ff891e; border-radius: 8px; border-width: thin">
                                                            <asp:LinkButton ID="rechazarBtn" CommandName='<%# Eval("ID") %>' Text="Rechazar" runat="server" aria-hidden="true" Style="margin: 2px 2px 2px 2px;color:saddlebrown" OnClick="rechazar_Click" />
                                                        </a>
                                                        <a aria-label="Borrar" style="margin-left: 15px; border: solid; border-color: #ff891e; border-radius: 8px; border-width: thin">
                                                            <asp:LinkButton ID="aceptarBtn" CommandName='<%# Eval("ID") %>' Text="Aceptar" runat="server" aria-hidden="true" Style="margin: 2px 2px 2px 2px;color:saddlebrown" OnClick="aceptar_Click" />
                                                        </a>
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
