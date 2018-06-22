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
                        <div id="rev_slider_container" class="rev_slider custom_rev_slider fullscreenbanner" style="display: none;" data-version="5.4.1">
                            <ul >
                            <asp:Repeater runat="server" ID="galeria">
                                <ItemTemplate>
                                    <li data-transition="parallaxvertical" >
                                        <img src='data:image/jpg;base64,<%# Eval("Imgs") %>' alt="slidebg1" data-bgparallax='<%# Eval("Num") %>' class="rev-slidebg"  >
                                   
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
            <div class="row">
                <div class="col-xs-12">
                    <div class="description-aria">
                        <div class="sectionTitle2">
                            <h2>Descripción</h2>
                            <p>AQUI VA LA DSC </p>
                        </div>
                        <%--<div class="row">
                            <div class="col-xs-12 col-sm-6">
                                <ul class="descriptionList">
                                    <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Cras tincidunt mi a sodales pulvinar.</li>
                                    <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Mauris in libero sodales ultrices purus</li>
                                    <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Quisque vulputate enim eu fringilla.</li>
                                    <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Eleifend mi vel nisl lobortis nec tincidunt</li>
                                    <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Mauris in libero sodales ultrices purus</li>
                                </ul>
                            </div>
                            <div class="col-xs-12 col-sm-6">
                                <ul class="descriptionList">
                                    <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Praesent nec nisl iaculis, pulvinar nunc.</li>
                                    <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Sed at erat lacinia, condimentum eros non</li>
                                    <li><i class="fa fa-dot-circle-o" aria-hidden="true"></i>Mauris in libero sodales ultrices purus at</li>
                                </ul>
                            </div>
                        </div>--%>
                    </div>
                </div>
            </div>
            <div class="row">
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
                            <div class="row">
                                <div class="col-xs-12 col-sm-9">
                                    <ul class="roomAdvantage">
                                        <li><a href="#">
                                            <img src="img/packages/shape-icon-1.png" alt="Image">Breakfast</a></li>
                                        <li><a href="#">
                                            <img src="img/packages/shape-icon-2.png" alt="Image">Plasma TV</a></li>
                                        <li><a href="#">
                                            <img src="img/packages/shape-icon-3.png" alt="Image">Free wifi</a></li>
                                    </ul>
                                </div>
                                <div class="col-xs-12 col-sm-3">
                                    <div class="roomRate">
                                        Per Night: <span>$150</span>
                                    </div>
                                </div>
                            </div>
                            <div class="roomGellary">
                                <div class="single-item">
                                    <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-01.jpg">
                                        <img src="img/holets/hotel-list-01.jpg" alt="Double Room">
                                    </a>
                                </div>
                                <div class="single-item">
                                    <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-02.jpg">
                                        <img src="img/holets/hotel-list-02.jpg" alt="Double Room">
                                    </a>
                                </div>
                                <div class="single-item">
                                    <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-03.jpg">
                                        <img src="img/holets/hotel-list-03.jpg" alt="Double Room">
                                    </a>
                                </div>
                                <div class="single-item">
                                    <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-04.jpg">
                                        <img src="img/holets/hotel-list-04.jpg" alt="Double Room">
                                    </a>
                                </div>
                                <div class="single-item">
                                    <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-05.jpg">
                                        <img src="img/holets/hotel-list-05.jpg" alt="Double Room">
                                    </a>
                                </div>
                            </div>
                        </div>
                        <hr>
                        <div class="roomCategory">
                            <div class="sub-title">
                                <h4>Single Room</h4>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip  commodo consequat. Duis aute irure dolor in reprehenderit</p>
                            </div>
                            <div class="row">
                                <div class="col-xs-12 col-sm-9">
                                    <ul class="roomAdvantage">
                                        <li><a href="#">
                                            <img src="img/packages/shape-icon-1.png" alt="Image">Breakfast</a></li>
                                        <li><a href="#">
                                            <img src="img/packages/shape-icon-2.png" alt="Image">Plasma TV</a></li>
                                        <li><a href="#">
                                            <img src="img/packages/shape-icon-3.png" alt="Image">Free wifi</a></li>
                                    </ul>
                                </div>
                                <div class="col-xs-12 col-sm-3">
                                    <div class="roomRate">
                                        Per Night: <span>$150</span>
                                    </div>
                                </div>
                            </div>
                            <div class="roomGellary">
                                <div class="single-item">
                                    <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-03.jpg">
                                        <img src="img/holets/hotel-list-03.jpg" alt="Double Room">
                                    </a>
                                </div>
                                <div class="single-item">
                                    <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-06.jpg">
                                        <img src="img/holets/hotel-list-06.jpg" alt="Double Room">
                                    </a>
                                </div>
                                <div class="single-item">
                                    <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-07.jpg">
                                        <img src="img/holets/hotel-list-07.jpg" alt="Double Room">
                                    </a>
                                </div>
                                <div class="single-item">
                                    <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-08.jpg">
                                        <img src="img/holets/hotel-list-08.jpg" alt="Double Room">
                                    </a>
                                </div>
                                <div class="single-item">
                                    <a class="fancybox-pop" rel="portfolio-1" href="img/holets/hotel-list-09.jpg">
                                        <img src="img/holets/hotel-list-09.jpg" alt="Double Room">
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-xs-12">
                    <div class="review-aria">
                        <div class="sectionTitle2">
                            <h2>Opiniones</h2>
                        </div>
                        <div class="reviewContent">

                            <button class="btn buttonCustomPrimary">Ver comentarios</button>

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
                        <h2>También puedes ver ...</h2>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-6 col-lg-4 col-xs-12">
                        <div class="thumbnail deals hotelgrid">
                            <img src="img/holets/hotel-list-01.jpg" alt="deal-image">
                            <a href="single-hotel-right-sidebar.html" class="pageLink"></a>
                            
                            <div class="caption">
                                <h4><a href="single-hotel-right-sidebar.html" class="captionTitle">The Rookery Hotel</a></h4>
                                <div class="detailsInfo">
                                    <ul class="list-inline detailsBtn">
                                        <li><a href='booking-1.html' class="btn buttonTransparent">Book now</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6 col-lg-4 col-xs-12">
                        <div class="thumbnail deals hotelgrid">
                            <img src="img/holets/hotel-list-02.jpg" alt="deal-image">
                            <a href="single-hotel-right-sidebar.html" class="pageLink"></a>
                            <div class="discountInfo discountCol-3">
                                <ul class="list-inline rating homePage">
                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                    <li><i class="fa fa-star-o" aria-hidden="true"></i></li>
                                    <li><i class="fa fa-star-o" aria-hidden="true"></i></li>
                                </ul>
                                <ul class="list-inline dates">
                                    <li>3 review</li>
                                </ul>
                            </div>
                            <div class="caption">
                                <h4><a href="single-hotel-right-sidebar.html" class="captionTitle">The Rookery Hotel</a></h4>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                                <div class="detailsInfo">
                                    <h5>
                                        <span>Start From</span>
                                        $35
                                    </h5>
                                    <ul class="list-inline detailsBtn">
                                        <li><a href='booking-1.html' class="btn buttonTransparent">Book now</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6 col-lg-4 col-xs-12">
                        <div class="thumbnail deals hotelgrid">
                            <img src="img/holets/hotel-list-03.jpg" alt="deal-image">
                            <a href="single-hotel-right-sidebar.html" class="pageLink"></a>
                            <div class="discountInfo discountCol-3">
                                <ul class="list-inline rating homePage">
                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                </ul>
                                <ul class="list-inline dates">
                                    <li>5 review</li>
                                </ul>
                            </div>
                            <div class="caption">
                                <h4><a href="single-hotel-right-sidebar.html" class="captionTitle">The Rookery Hotel</a></h4>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>
                                <div class="detailsInfo">
                                    <h5>
                                        <span>Start From</span>
                                        $40
                                    </h5>
                                    <ul class="list-inline detailsBtn">
                                        <li><a href='booking-1.html' class="btn buttonTransparent">Book now</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>
