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
    <section class="mainContentSection packagesSection">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="tituloLabel" Text="Precios" BackColor="#f5f5f5"></asp:Label></h2>

                    </div>
                    <h4>
                        <asp:Label runat="server" ID="info1" Text="Les mostramos nuestros diferentes precios para las clases y alquiler de tablas"></asp:Label></h4>
                  
                </div>
            </div>



            <div class="col-sm-9 col-xs-12" style="width:100%">
                <div class="row">



                    <asp:ListView runat="server" ID="preguntasLst">
                        <ItemTemplate>
                            <div class="col-lg-4 col-sm-6 col-xs-12 " >
                                <div class="thumbnail deals packagesPage">
                                    <%--<img src="img/home/deal/deal-01.jpg" alt="deal-image">--%>
                                    <a href="single-package-right-sidebar.html" class="pageLink"></a>
                                    <%--<div class="discountInfo">
                    <div class="discountOffer">
                      <h4>
                        50% <span>OFF</span>
                      </h4>
                    </div>
                    <ul class="list-inline rating homePage">
                      <li><i class="fa fa-star" aria-hidden="true"></i></li>
                      <li><i class="fa fa-star" aria-hidden="true"></i></li>
                      <li><i class="fa fa-star" aria-hidden="true"></i></li>
                      <li><i class="fa fa-star" aria-hidden="true"></i></li>
                      <li><i class="fa fa-star" aria-hidden="true"></i></li>
                    </ul>
                    <ul class="list-inline duration">
                      <li>7 days</li>
                      <li>15 hrs</li>
                      <li>15 min</li>
                    </ul>
                  </div>--%>
                                    <div class="caption">
                                        <h4><a href="single-package-left-sidebar.html" class="captionTitle"><%# Eval("Tipo") %></a></h4>
                                        <p><%# Eval("Descripcion") %></p>
                                        <div class="detailsInfo">
                                            <h5>
                                                <span>Por persona</span>
                                                <%# Eval("PrecioD") %> colones - imp incluidos
                                            </h5>
                                            <%--<ul class="list-inline detailsBtn">
                                                <li><a data-toggle="modal" data-target="#inquiryModal" href="#" class="btn buttonTransparent">Inquiry</a></li>
                                            </ul>--%>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>



                </div>
            </div>
        </div>
    </section>


</asp:Content>



