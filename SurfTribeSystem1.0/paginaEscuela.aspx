<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="paginaEscuela.aspx.cs" Inherits="SurfTribeSystem1._0.paginaEscuela" %>

<%@ MasterType VirtualPath="~/Site2.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="background-image: url(Imagenes/fondo1.jpg); background-repeat: no-repeat; background-size: cover">
        <!-- PAGE TITLE -->
        <asp:Repeater runat="server" ID="banerImg">
            <ItemTemplate>
                <section class="pageTitle" style="background-image: url('data:image/jpg;base64,<%# Eval("Imgs") %>'); margin-top: 96px">
                    <div class="container">
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="titleTable">
                                    <div class="titleTableInner">
                                        <div class="pageTitleInfo">
                                            <h1><%# Eval("Dueño") %></h1>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </ItemTemplate>
        </asp:Repeater>

        
        
        <!-- PAGE CONTENT -->
        <section class="mainContentSection singlePackage" style="padding: 45px 0 70px 0;">
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label runat="server" ForeColor="DarkOrange" Font-Size="XX-Large" Font-Bold="true" style="margin-left:10%;" ><a href="#galery">Ver galeria >></a>
                       </asp:Label>

             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label runat="server" ForeColor="DarkOrange" Font-Size="XX-Large" Font-Bold="true" style="" ><a href="#otras">Ver otras escuelas >></a>
                       </asp:Label>

            <br />

            <div class="container">
                
                 
    <%--            <script type="text/javascript">
         $(document).ready(function () {
             $('#media').carousel({
                 pause: false,
                 interval: 4000,
             });
         });
                </script>

                <div class='row' >
                    <div class='col-md-12'>
                        <div class="carousel slide media-carousel" id="media">
                            <div class="carousel-inner">
                                <asp:Repeater ID="galeria" runat="server">

                                    <ItemTemplate>

                                        <div class="item <%# (Container.ItemIndex == 0 ? "active" : "") %>">
                                            <div class="row">
                                                <div class="col-md-8" style="height:600px">
                                                        <img alt="" src='data:image/jpg;base64,<%# Eval("Imgs") %>' style="max-height:100%;max-width:100%;position:fixed"></a>
                                                </div>
                                            </div>
                                        </div>

                                    </ItemTemplate>
                                </asp:Repeater>


                            </div>
                            <a data-slide="prev" href="#media" class="left carousel-control" ></a>
                            <a data-slide="next" href="#media" class="right carousel-control"></a>
                        </div>
                    </div>
                </div>--%>

                <div class="row"  style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); 
                                            position: relative; z-index: 1; box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); 
                                            border-radius: 12px; padding: 12px;">
                    
                    <div class="row" >
                        <div class="col-xs-12">
                            <div class="description-aria" >
                                <asp:Repeater runat="server" ID="info">
                                    <ItemTemplate>
                                        <div class="sectionTitle2">
                                            <h1 style="color: saddlebrown;">Descripción</h1>
                                            <p style="color: black; font-size: x-large"><%# Eval("Descripcion") %> </p>
                                        </div>
                                        <div class="row">
                                            <div class="col-xs-12 col-sm-6">
                                                <ul class="descriptionList">

                                                    <li>
                                                        <div class="sectionTitle2">
                                                            <h2 style="color: saddlebrown; font-weight: bold">Zona de:</h2>
                                                        </div>
                                                    </li>
                                                    <li style="color: black; font-size: x-large"><i class="fa fa-dot-circle-o" aria-hidden="true"></i><%# Eval("Zona") %></li>
                                                    <li>
                                                        <div class="sectionTitle2">
                                                            <h2 style="color: saddlebrown; font-weight: bold">Nos ubicamos en:</h2>
                                                        </div>
                                                    </li>
                                                    <li style="color: black; font-size: x-large"><i class="fa fa-dot-circle-o" aria-hidden="true"></i><%# Eval("Ubicacion") %></li>
                                                    <li>
                                                        <div class="sectionTitle2">
                                                            <h2 style="color: saddlebrown; font-weight: bold">Playa en la cual se imparten la mayoría de lecciones:</h2>
                                                        </div>
                                                    </li>
                                                    <li style="color: black; font-size: x-large"><i class="fa fa-dot-circle-o" aria-hidden="true"></i><%# Eval("Playa_concurrida") %></li>
                                                </ul>
                                            </div>
                                            <div class="col-xs-12 col-sm-6">
                                                <ul class="descriptionList">
                                                    <li>
                                                        <div class="sectionTitle2">
                                                            <h2 style="color: saddlebrown; font-weight: bold">Nos pueden contactar por:</h2>
                                                        </div>
                                                    </li>
                                                    <li style="color: darkred; font-size: x-large; font-weight: bold;"><i class="fa fa-dot-circle-o" aria-hidden="true"></i><a href='mailto:<%# Eval("Correo") %>' style="color: darkred;"><%# Eval("Correo") %></a></li>
                                                    <li style="color: black; font-size: x-large"><i class="fa fa-dot-circle-o" aria-hidden="true"></i><%# Eval("Telefono") %>          <%# Eval("Telefono2") %></li>

                                                    <br />
                                                    <br />
                                                    <br />

                                                    <li>
                                                        <a class="btn btn-block buttonCustomPrimary" style="font-size: xx-large" href="reservaClases.aspx">Reserva ya!</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>


                    <div class="row">
                        <!-- opiniones -->
                        <div class="col-xs-12 col-sm-6">
                            <div class="review-aria">
                                <div class="sectionTitle2">
                                    <h1 style="color: saddlebrown;"><a runat="server" id="linkComent" style="color: saddlebrown;">Opiniones >>></a></h1>
                                </div>
                            </div>
                        </div>
                        <!-- precios -->
                        <div class="col-xs-12 col-sm-6">
                            <div class="review-aria">
                                <div class="sectionTitle2">
                                    <h1 style="color: saddlebrown;"><a runat="server" id="linkPrecios" style="color: saddlebrown;">Precios >>></a></h1>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <br />
                <br />

                   <!-- galeria-->
                  <div class="row galleryCarousel" id="galery">
                    <div class="carousel slide" data-ride="carousel">
                        <div id="rev_slider_container" class="rev_slider custom_rev_slider " data-version="5.4.1" >
                            <ul>
                                <asp:Repeater runat="server" ID="galeria">
                                    <ItemTemplate>
                                                    <li class="item">
                                            <img src='data:image/jpg;base64,<%# Eval("Imgs") %>' alt="slidebg1">
                                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </div>

                </div>

            </div>
        </section>

        <!-- RELATED SECTION -->
        <section class="relatedSection" id="otras">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="sectionTitle2">
                            <br />
                            <h1>También puede ver</h1>
                        </div>
                    </div>
                    <div class="row">

                        <asp:Repeater runat="server" ID="infoSencilla">
                            <ItemTemplate>
                                <div class="col-sm-6 col-lg-4 col-xs-12">
                                    <div class="thumbnail deals hotelgrid">
                                        <img src='data:image/jpg;base64,<%# Eval("Imgs") %>' alt="deal-image">
                                        <a href="single-hotel-right-sidebar.html" class="pageLink"></a>

                                        <div class="caption">
                                            <h4><a href="single-hotel-right-sidebar.html" class="captionTitle" style="color: saddlebrown">Escuela <%# Eval("Nombre") %></a></h4>
                                            <p style="color: black">
                                                Zona de: <%# Eval("Zona") %><br />
                                                Playa: <%# Eval("Playa_concurrida") %>
                                            </p>
                                            <div class="detailsInfo">
                                                <ul class="list-inline detailsBtn">
                                                    <li><a href="paginaEscuela.aspx?idEscuela=<%# Eval("Nombre") %>" class="btn buttonTransparent" style="color: darkorange; font-weight: bold">Ir ahora</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>

                    </div>
                </div>
            </div>
        </section>
    </div>
</asp:Content>
