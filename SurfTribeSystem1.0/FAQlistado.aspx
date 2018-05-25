<%@ Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FAQlistado.aspx.cs" Inherits="SurfTribeSystem1._0.FAQlistado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        $(function () {

        })
    </script>

     <!-- PAGE TITLE -->
<section class="pageTitle" style="background-image:url(ccss/star-1-3/Static%20HTML/img/pages/page-title-bg6.jpg);">
      <div class="container">
        <div class="row">
          <div class="col-xs-12">
            <div class="titleTable">
              <div class="titleTableInner">
                <div class="pageTitleInfo">
                  <h1>Preguntas frecuentes</h1>
                  <div class="under-border"></div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- PAGE CONTENT -->
  

     <section class="mainContentSection">
      <div class="container">
        <div class="row">
          <div class="col-xs-12">
            <div class="sectionTitle">
              <h2><span>Accordions</span></h2>

            </div> <h4>Nuestros usuarios nos comentan a veces sobre sus inquietudes, por esto la existencia de este apartado.</h4>
              <p>Esperamos poder aclarar todas su dudas, aqui les mostramos las incognitas mas comunes de nuestros usuarios.</p>
          </div>
        </div>
        <div class="row">
          <div class="col-sm-6 col-xs-12 accordionsTransparent">
            <div class="accordionWrappar">
              <div class="panel-group" id="accordionIcons">
                <div class="panel panel-default">
                  <a class="panel-heading accordion-toggle active" data-toggle="collapse" data-parent="#accordionIcons" href="#collapseOne">
                    <span>How can I manage Instant Book settings?</span>
                    <i class="indicator fa fa-minus  pull-right"></i>
                  </a>
                  <div id="collapseOne" class="panel-collapse collapse in active">
                    <div class="panel-body">
                      <div class="media">
                        <a class="media-left" href="#">
                          <img class="media-object" src="img/toggle/toggle-01.jpg" alt="Image">
                        </a>
                        <div class="media-body">
                          <h4 class="media-heading">Story &amp; History</h4>
                          <p>Lorem ipsum dolor sit amet, consectetur adipis icing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet.</p>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="panel panel-default">
                  <a class="panel-heading accordion-toggle" data-toggle="collapse" data-parent="#accordionIcons" href="#collapseTwo">
                    <span>How do I list multiple rooms?</span>
                    <i class="indicator fa fa-plus  pull-right"></i>
                  </a>
                  <div id="collapseTwo" class="panel-collapse collapse">
                    <div class="panel-body">
                      <div class="media">
                        <a class="media-left" href="#">
                          <img class="media-object" src="img/toggle/toggle-01.jpg" alt="Image">
                        </a>
                        <div class="media-body">
                          <h4 class="media-heading">Story &amp; History</h4>
                          <p>Lorem ipsum dolor sit amet, consectetur adipis icing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet.</p>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="panel panel-default">
                  <a class="panel-heading accordion-toggle" data-toggle="collapse" data-parent="#accordionIcons" href="#collapseThree">
                    <span>How do I use my calendar?</span>
                    <i class="indicator fa fa-plus  pull-right"></i>
                  </a>
                  <div id="collapseThree" class="panel-collapse collapse">
                    <div class="panel-body">
                     <div class="media">
                        <a class="media-left" href="#">
                          <img class="media-object" src="img/toggle/toggle-01.jpg" alt="Image">
                        </a>
                        <div class="media-body">
                          <h4 class="media-heading">Story &amp; History</h4>
                          <p>Lorem ipsum dolor sit amet, consectetur adipis icing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet.</p>
                        </div>
                      </div>
                   </div>
                  </div>
                </div>
                <div class="panel panel-default">
                  <a class="panel-heading accordion-toggle" data-toggle="collapse" data-parent="#accordionIcons" href="#collapseFour">
                    <span>How do I make reservation?</span>
                    <i class="indicator fa fa-plus  pull-right"></i>
                  </a>
                  <div id="collapseFour" class="panel-collapse collapse">
                    <div class="panel-body">
                     <div class="media">
                        <a class="media-left" href="#">
                          <img class="media-object" src="img/toggle/toggle-01.jpg" alt="Image">
                        </a>
                        <div class="media-body">
                          <h4 class="media-heading">Story &amp; History</h4>
                          <p>Lorem ipsum dolor sit amet, consectetur adipis icing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet.</p>
                        </div>
                      </div>
                   </div>
                  </div>
                </div>
                <div class="panel panel-default">
                  <a class="panel-heading accordion-toggle" data-toggle="collapse" data-parent="#accordionIcons" href="#collapseFive">
                    <span>How do I make reservation?</span>
                    <i class="indicator fa fa-plus  pull-right"></i>
                  </a>
                  <div id="collapseFive" class="panel-collapse collapse">
                    <div class="panel-body">
                     <div class="media">
                        <a class="media-left" href="#">
                          <img class="media-object" src="img/toggle/toggle-01.jpg" alt="Image">
                        </a>
                        <div class="media-body">
                          <h4 class="media-heading">Story &amp; History</h4>
                          <p>Lorem ipsum dolor sit amet, consectetur adipis icing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet.</p>
                        </div>
                      </div>
                   </div>
                  </div>
                </div>
                <div class="panel panel-default">
                  <a class="panel-heading accordion-toggle hideBorder" data-toggle="collapse" data-parent="#accordionIcons" href="#collapseSix">
                    <span>How do I make reservation?</span>
                    <i class="indicator fa fa-plus  pull-right"></i>
                  </a>
                  <div id="collapseSix" class="panel-collapse collapse">
                    <div class="panel-body">
                     <div class="media">
                        <a class="media-left" href="#">
                          <img class="media-object" src="img/toggle/toggle-01.jpg" alt="Image">
                        </a>
                        <div class="media-body">
                          <h4 class="media-heading">Story &amp; History</h4>
                          <p>Lorem ipsum dolor sit amet, consectetur adipis icing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet.</p>
                        </div>
                      </div>
                   </div>
                  </div>
                </div>
             </div>
            </div>
          </div>
          <div class="col-sm-6 col-xs-12 accordionsTransparent">
            <div class="solidBgTitle">
              <div class="panel-group" id="accordionSolid">
                <div class="panel panel-default">
                  <a class="panel-heading accordion-toggle" data-toggle="collapse" data-parent="#accordionSolid" href="#collapse-aa">
                    <span>How can I manage Instant Book settings?</span>
                    <i class="indicator fa fa-minus  pull-right"></i>
                  </a>
                  <div id="collapse-aa" class="panel-collapse collapse in">
                    <div class="panel-body">
                      <div class="media">
                        <a class="media-left" href="#">
                          <img class="media-object" src="img/toggle/toggle-02.jpg" alt="Image">
                        </a>
                        <div class="media-body">
                          <h4 class="media-heading">Story &amp; History</h4>
                          <p>Lorem ipsum dolor sit amet, consectetur adipis icing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet.</p>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="panel panel-default">
                  <a class="panel-heading accordion-toggle" data-toggle="collapse" data-parent="#accordionSolid" href="#collapse-bb">
                    <span>How do I list multiple rooms?</span>
                    <i class="indicator fa fa-plus  pull-right"></i>
                  </a>
                  <div id="collapse-bb" class="panel-collapse collapse">
                    <div class="panel-body">
                      <div class="media">
                        <a class="media-left" href="#">
                          <img class="media-object" src="img/toggle/toggle-02.jpg" alt="Image">
                        </a>
                        <div class="media-body">
                          <h4 class="media-heading">Story &amp; History</h4>
                          <p>Lorem ipsum dolor sit amet, consectetur adipis icing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet.</p>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="panel panel-default">
                  <a class="panel-heading accordion-toggle" data-toggle="collapse" data-parent="#accordionSolid" href="#collapse-cc">
                    <span>How do I use my calendar?</span>
                    <i class="indicator fa fa-plus  pull-right"></i>
                  </a>
                  <div id="collapse-cc" class="panel-collapse collapse">
                    <div class="panel-body">
                     <div class="media">
                        <a class="media-left" href="#">
                          <img class="media-object" src="img/toggle/toggle-02.jpg" alt="Image">
                        </a>
                        <div class="media-body">
                          <h4 class="media-heading">Story &amp; History</h4>
                          <p>Lorem ipsum dolor sit amet, consectetur adipis icing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet.</p>
                        </div>
                      </div>
                   </div>
                  </div>
                </div>
                <div class="panel panel-default">
                  <a class="panel-heading accordion-toggle" data-toggle="collapse" data-parent="#accordionSolid" href="#collapse-dd">
                    <span>How do I make reservation?</span>
                    <i class="indicator fa fa-plus  pull-right"></i>
                  </a>
                  <div id="collapse-dd" class="panel-collapse collapse">
                    <div class="panel-body">
                     <div class="media">
                        <a class="media-left" href="#">
                          <img class="media-object" src="img/toggle/toggle-02.jpg" alt="Image">
                        </a>
                        <div class="media-body">
                          <h4 class="media-heading">Story &amp; History</h4>
                          <p>Lorem ipsum dolor sit amet, consectetur adipis icing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet.</p>
                        </div>
                      </div>
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