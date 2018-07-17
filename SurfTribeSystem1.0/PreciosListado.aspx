<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="PreciosListado.aspx.cs" Inherits="SurfTribeSystem1._0.PreciosListado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!--principal-->
    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="sectionTitle">
                                <h2>
                                    <asp:Label runat="server" ID="tituloLabel" Text="Precios" BackColor="#f5f5f5"></asp:Label></h2>

                            </div>
                            <h4>
                                <asp:Label runat="server" ID="info1" Text="Les mostramos nuestros diferentes precios para las clases y alquiler de tablas. Seleccione la escuela:"></asp:Label></h4>

                            <div class="col-sm-4 col-xs-12 ">

                                <asp:DropDownList ID="ddlEscuela" AutoPostBack="true" OnSelectedIndexChanged="Seleccionar" runat="server" CssClass="bg-ashh" Width="100%">
                                </asp:DropDownList>

                            </div>

                        </div>
                    </div>
                    <br />


                    <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 11px;">

                        <div class="row">



                            <asp:ListView runat="server" ID="preciosLst">
                                <ItemTemplate>
                                    <div class="col-lg-4 col-sm-6 col-xs-12 " >
                                        <div class="thumbnail deals packagesPage" style="background-color: rgba(142, 120, 39, 0.4);">

                                            <div class="caption">
                                                <h4><a class="captionTitle" style="font-size:x-large"><%# Eval("Tipo") %></a></h4>
                                                <p style="color:white; font-size:large"><%# Eval("Descripcion") %></p>
                                                <div class="detailsInfo">
                                                    <h5 style="font-size:x-large; font-weight:bold; color:saddlebrown">
                                                        <%# Eval("PrecioD") %> colones - imp incluidos
                                                    </h5>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:ListView>



                        </div>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="ddlEscuela" EventName="SelectedIndexChanged" />
            </Triggers>
        </asp:UpdatePanel>
    </section>


</asp:Content>



