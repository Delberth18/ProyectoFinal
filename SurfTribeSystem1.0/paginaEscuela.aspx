<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="paginaEscuela.aspx.cs" Inherits="SurfTribeSystem1._0.paginaEscuela" %>

<%@ MasterType VirtualPath="~/Site1.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- PAGE TITLE -->
    <asp:Repeater runat="server" ID="banerImg">
        <ItemTemplate>
            <section class="pageTitle" style="background-image: url('data:image/jpg;base64,<%# Eval("Imgs") %>');">
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
    <section class="mainContentSection singleHotel">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div id="package-carousel" class="carousel slide" data-ride="carousel">
                        <div id="rev_slider_container" class="rev_slider custom_rev_slider " data-version="5.4.1">
                            <ul>
                                <asp:Repeater runat="server" ID="galeria">
                                    <ItemTemplate>
                                        <li data-transition="parallaxvertical">
                                            <img src='data:image/jpg;base64,<%# Eval("Imgs") %>' alt="slidebg1">
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                        <a class="left carousel-control" href="#package-carousel" data-slide="prev"><span class="glyphicon glyphicon-menu-left"></span></a>
                        <a class="right carousel-control" href="#package-carousel" data-slide="next"><span class="glyphicon glyphicon-menu-right"></span></a>
                    </div>
                </div>
            </div>
            <div class="row" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="description-aria">
                            <asp:Repeater runat="server" ID="info">
                                <ItemTemplate>
                                    <div class="sectionTitle2">
                                        <h1 style="color: darkorange;">Descripción</h1>
                                        <p style="color: white; font-size: x-large"><%# Eval("Descripcion") %> </p>
                                    </div>
                                    <div class="row">
                                        <div class="col-xs-12 col-sm-6">
                                            <ul class="descriptionList">

                                                <li>
                                                    <div class="sectionTitle2">
                                                        <h2>Zona de:</h2>
                                                    </div>
                                                </li>
                                                <li style="color: white; font-size: x-large"><i class="fa fa-dot-circle-o" aria-hidden="true"></i><%# Eval("Zona") %></li>
                                                <li>
                                                    <div class="sectionTitle2">
                                                        <h2>Nos ubicamos en:</h2>
                                                    </div>
                                                </li>
                                                <li style="color: white; font-size: x-large"><i class="fa fa-dot-circle-o" aria-hidden="true"></i><%# Eval("Ubicacion") %></li>
                                                <li>
                                                    <div class="sectionTitle2">
                                                        <h2>Playa en la cual se imparten la mayoría de lecciones:</h2>
                                                    </div>
                                                </li>
                                                <li style="color: white; font-size: x-large"><i class="fa fa-dot-circle-o" aria-hidden="true"></i><%# Eval("Playa_concurrida") %></li>
                                            </ul>
                                        </div>
                                        <div class="col-xs-12 col-sm-6">
                                            <ul class="descriptionList">
                                                <li>
                                                    <div class="sectionTitle2">
                                                        <h2>Nos pueden contactar por:</h2>
                                                    </div>
                                                </li>
                                                <li style="color: darkorange; font-size: x-large; font-weight: bold;"><i class="fa fa-dot-circle-o" aria-hidden="true"></i><a href='mailto:<%# Eval("Correo") %>'><%# Eval("Correo") %></a></li>
                                                <li style="color: white; font-size: x-large"><i class="fa fa-dot-circle-o" aria-hidden="true"></i><%# Eval("Telefono") %>          <%# Eval("Telefono2") %></li>

                                                <br />
                                                <br />
                                                <br />
                                                <br />

                                                <li>
                                                    <a class="btn btn-block buttonCustomPrimary" style="font-size: xx-large">Reserva ya!</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>

                <%-- <div class="row">
                <div class="col-xs-12">
                    <div class="rooms-types-aria">
                        <div class="sectionTitle2">
                            <h2>rooms types</h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam</p>
                        </div>
                        <div class="roomCategory">
                            <div class="sub-title">
                                <h4>Double Room</h4>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip  commodo consequat. Duis aute irure dolor in reprehenderit</p>
                            </div>


                            <hr>
                            <div class="roomCategory">
                                <div class="sub-title">
                                    <h4>Single Room</h4>
                                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip  commodo consequat. Duis aute irure dolor in reprehenderit</p>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>--%>


                <div class="row">
                    <!-- opiniones -->
                    <div class="col-xs-12 col-sm-6">
                        <div class="review-aria">
                            <div class="sectionTitle2">
                                <h1 style="color: darkorange;"><a href="#">Opiniones >>></a></h1>
                            </div>
                        </div>
                    </div>
                    <!-- precios -->
                    <div class="col-xs-12 col-sm-6">
                        <div class="review-aria">
                            <div class="sectionTitle2">
                                <h1 style="color: darkorange;"><a href="#">Precios >>></a></h1>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </section>

    <!-- RELATED SECTION -->
    <section class="relatedSection">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="sectionTitle2">
                        <h1>También puedes ver</h1>
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
                                        <h4><a href="single-hotel-right-sidebar.html" class="captionTitle">Escuela <%# Eval("Nombre") %></a></h4>
                                        <p>
                                            Zona de: <%# Eval("Zona") %><br />
                                            Playa: <%# Eval("Playa_concurrida") %>
                                        </p>
                                        <div class="detailsInfo">
                                            <ul class="list-inline detailsBtn">
                                                <li><a href='booking-1.html' class="btn buttonTransparent">Ir ahora</a></li>
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
</asp:Content>
