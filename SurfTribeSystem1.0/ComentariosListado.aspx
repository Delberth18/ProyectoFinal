<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ComentariosListado.aspx.cs" Inherits="SurfTribeSystem1._0.ComentariosListado" %>

<%@ MasterType VirtualPath="~/Site2.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <br />
                <div class="row">
                    <div class="col-xs-12">
                        <div class="sectionTitle">
                            <h2>
                                <asp:Label runat="server" ID="tituloLabel" Text="Opiniones" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                        </div>
                        <div class="sectionTitle">
                                    <h2>
                                        <asp:Label runat="server" ID="Label1" ForeColor="SaddleBrown" Font-Bold="true" Font-Size="X-Large" Text="En este apartado se muestran todos las opiniones de nuestros diferentes usuarios"></asp:Label></h2>
                                </div>
                    </div>
                </div>
                <br />
                <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">
                    <div class="row" style="margin: 4px 4px 4px 4px;">

                        <div class="col-sm-6 col-xs-12 accordionsTransparent" style="width: 100%">

                            <div class="review-aria">
                                
                                <div class="reviewContent" style="margin: 8px 8px 8px 8px;">
                                    <h3 style="color: black; font-size: x-large;">Opiniones
                                        <asp:Label ForeColor="Black" Font-Size="Large" runat="server" ID="cantidadLabel"></asp:Label>
                                    </h3>
                                    <asp:ListView runat="server" ID="preguntasLst">
                                        <ItemTemplate>

                                            <div class="reviewMedia" style="border:solid;border-color:white">
                                                <ul class="media-list">
                                                    <li class="media">
                                                        <div class="media-body">
                                                            <h4 class="media-heading" style="text-align:center">
                                                                <asp:Label runat="server" Font-Size="X-Large" ForeColor="SaddleBrown" ID="preguntaLabel" Text='<%# Eval("Nombre") %>'></asp:Label></h4>

                                                            <p style="text-align:center">
                                                                <asp:Label ForeColor="Black" runat="server" Font-Size="X-Large" ID="Label2" Text='<%# Eval("Comentariol") %>'></asp:Label></p>
                                                        </div>
                                                    </li>

                                                </ul>
                                            </div>
                                            <br />

                                        </ItemTemplate>
                                    </asp:ListView>

                                    <h3 class="reviewTitle" style="color: SaddleBrown; font-size: x-large;">Brindenos su opinión</h3>

                                    <div class="row">
                                        <div class="col-xs-12">
                                            <div class="form-group">
                                                <asp:TextBox TextMode="MultiLine" runat="server" ID="comentarioText" Class="form-control" Rows="5"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <asp:Button ID="btnGuardar" OnClick="Unnamed_Click" class="btn btn-default" runat="server" Style="padding: 15px; background-color: darkorange; color: white; font-family: Arial; text-transform: none; font-size: large;" Text=" Guardar opinión "></asp:Button>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
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





