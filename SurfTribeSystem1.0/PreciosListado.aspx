<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PreciosListado.aspx.cs" Inherits="SurfTribeSystem1._0.PreciosListado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- PAGE TITLE -->
    <section class="pageTitle" style="background-image: url(ccss/star-1-3/Static%20HTML/img/pages/page-title-bg6.jpg);">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="titleTable">
                        <div class="titleTableInner">
                            <div class="pageTitleInfo">
                                <h1>Nuestros Precios</h1>
                                <div class="under-border"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- PAGE CONTENT -->

    <!--principal-->
    <section class="mainContentSection">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="tituloLabel" Text="Sus dudas"></asp:Label></h2>

                    </div>
                    <h4>
                        <asp:Label runat="server" ID="info1" Text="Todos nos han hecho llegar sus dudas, aquí les mostramos las más comunes"></asp:Label></h4>
                    <p>
                        <asp:Label runat="server" ID="info2" Text="Esperamos haber aclarado estas dudas. Si tienen alguna otra no la pueden hacer llegar por medio de la página de consultas, al correo o cuando nos visiten."></asp:Label>
                    </p>
                </div>
            </div>

            <div class="row" style="margin: 4px 4px 4px 4px; border: solid 1px #000000; border-top-left-radius: 27px; border-top-right-radius: 27px; border-bottom-left-radius: 27px; border-bottom-right-radius: 28px;">

                <div class="col-sm-6 col-xs-12 accordionsTransparent" style="width: 100%">
                    <div class="solidBgTitle">
                        <div class="panel-group" id="accordionSolid">

                            <asp:ListView runat="server" ID="preguntasLst">
                                <ItemTemplate>

                                    <div class="media-body">
                                        <div class="bodyLeft">
                                            <h4 class="media-heading"><a href="single-package-right-sidebar.html">Suspendisse Tour</a></h4>
                                            <div class="countryRating">
                                                <span>Asia</span>
                                                <ul class="list-inline rating">
                                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                    <li><i class="fa fa-star" aria-hidden="true"></i></li>
                                                </ul>
                                            </div>
                                            <p>Integer purus ex, dictum nec elementum eu, tristique vel lectus. Donec rutrum lectus et pharetra egestas.</p>
                                            <ul class="list-inline detailsBtn">
                                                <li><span class="textInfo"><i class="fa fa-calendar" aria-hidden="true"></i>27 jan, 2016</span></li>
                                                <li><span class="textInfo"><i class="fa fa-clock-o" aria-hidden="true"></i>5 days</span></li>
                                            </ul>
                                        </div>
                                        <div class="bodyRight">
                                            <div class="bookingDetails">
                                                <h2>$499</h2>
                                                <p>Per Person</p>
                                                <a href="single-package-right-sidebar.html" class="btn buttonTransparent clearfix">Details</a>
                                                <a data-toggle="modal" data-target="#inquiryModal" href="#" class="btn buttonTransparent">Inquiry</a>
                                            </div>
                                        </div>
                                    </div>

                                </ItemTemplate>
                            </asp:ListView>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>


</asp:Content>



