<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="galeria.aspx.cs" Inherits="SurfTribeSystem1._0.galeria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- PAGE TITLE -->
    <section class="pageTitle" style="background-image:url(ccss/star-1-3/Static%20HTML/img/pages/page-title-bg5.jpg);">
      <div class="container">
        <div class="row">
          <div class="col-xs-12">
            <div class="titleTable">
              <div class="titleTableInner">
                <div class="pageTitleInfo">
                  <h1>Galería</h1>
                  <div class="under-border"></div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- PAGE CONTENT -->
    <section class="mainContentSection singlePackage">
      <div class="container">
        <div class="row galleryCarousel">
          <div class="col-xs-12">
            <div id="package-carousel" class="carousel slide" data-ride="carousel">
              <ol class="carousel-indicators">
                <li data-target="#package-carousel" data-slide-to="0" class="active"><img src="ccss/star-1-3/Static%20HTML/img/gallery/gallery-single-thumb-01.jpg"></li>
                <li data-target="#package-carousel" data-slide-to="1" class=""><img src="ccss/star-1-3/Static%20HTML/img/gallery/gallery-single-thumb-02.jpg"></li>
                <li data-target="#package-carousel" data-slide-to="2" class=""><img src="ccss/star-1-3/Static%20HTML/img/gallery/gallery-single-thumb-03.jpg"></li>
              </ol>
              <div class="carousel-inner">
                <div class="item active">
                  <img alt="First slide" src="ccss/star-1-3/Static%20HTML/img/gallery/gallery-single-slider-01.jpg">
                </div>
                <div class="item">
                  <img alt="Second slide" src="ccss/star-1-3/Static%20HTML/img/gallery/gallery-single-slider-02.jpg">
                </div>
                <div class="item">
                  <img alt="Third slide" src="ccss/star-1-3/Static%20HTML/img/gallery/gallery-single-slider-03.jpg">
                </div>
              </div>
              <a class="left carousel-control" href="#package-carousel" data-slide="prev"><span class="glyphicon glyphicon-menu-left"></span></a>
              <a class="right carousel-control" href="#package-carousel" data-slide="next"><span class="glyphicon glyphicon-menu-right"></span></a>
            </div>
          </div>
          <div class="col-xs-12">
            <div class="generalInfo">
              <h2>maldives tour</h2>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
              <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>
            </div>
          </div>
          <div class="col-xs-12">
            <div class="buttonArea galleryBtnArea">
              <ul class="list-inline">
                <li><a href="" class="btn buttonTransparent">Prev Image</a></li>
                <li><a href="" class="btn buttonTransparent">next Image</a></li>
              </ul>
            </div>
          </div>
        </div>
        <div class="row">
          <div class="col-xs-12">
            <div class="relatedProduct">
              <h2>Otras escuelas</h2>
              <div class="row">
                <div class="col-sm-4 col-xs-12">
                  <div class="relatedItem">
                    <img src="ccss/star-1-3/Static%20HTML/img/packages/package-related-01.jpg" alt="related image">
                    <div class="maskingInfo">
                      <h4>maldives tour</h4>
                      <p>Lorem Ipsum</p>
                      <a href="#" class="btn buttonTransparent">view more</a>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="relatedItem">
                    <img src="ccss/star-1-3/Static%20HTML/img/packages/package-related-02.jpg" alt="related image">
                    <div class="maskingInfo">
                      <h4>maldives tour</h4>
                      <p>Lorem Ipsum</p>
                      <a href="#" class="btn buttonTransparent">view more</a>
                    </div>
                  </div>
                </div>
                <div class="col-sm-4 col-xs-12">
                  <div class="relatedItem">
                    <img src="ccss/star-1-3/Static%20HTML/img/packages/package-related-03.jpg" alt="related image">
                    <div class="maskingInfo">
                      <h4>maldives tour</h4>
                      <p>Lorem Ipsum</p>
                      <a href="#" class="btn buttonTransparent">view more</a>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

</asp:Content>
