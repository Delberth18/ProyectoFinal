<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registrarse.aspx.cs" Inherits="SurfTribeSystem1._0.registrarse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <!-- PAGE TITLE -->
    <section class="pageTitle" style="background-image:url(ccss/star-1-3/Static HTML/img/pages/page-title-bg5.jpg);">
      <div class="container">
        <div class="row">
          <div class="col-xs-12">
            <div class="titleTable">
              <div class="titleTableInner">
                <div class="pageTitleInfo">
                  <h1>Bienvenido</h1>
                  <div class="under-border"></div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- WHITE SECTION FILTER-->
    <section class="mainContentSection">
        <center><font size="14"><b FACE="arial" size="30%">Registrese</b></font></center><br />
      <div class="container">
     
        <div class="row">
          <center>
          
            
            <div class="bookingForm">
              <form  method="POST"  role="form" class="form" id="form1" runat="server">
                <div class="row">
                  <div class="form-group" style=" width: 300px;">
                   
                      
                    <input type="text" runat="server" class="form-control" id="correo" name="correo" placeholder="Correo electrónico"><br />
                 
                   
                    <input type="text" class="form-control" id="" placeholder="Contraseña"><br />
                
                   
                    <input type="text" class="form-control" id="" placeholder="Confirmar Contraseña"><br />
                  
                   
                    <input type="text" class="form-control" id="" placeholder="Nombre"><br />


                    <input type="text" class="form-control" id="" placeholder="Apellidos"><br />
                
                    <asp:TextBox runat="server" type="number" class="form-control" placeholder="Telefono" ID="tele" ></asp:TextBox><br />

                    <asp:RadioButton ID="RadioButton1" GroupName="genero" runat="server" Text="Masculino" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

		            <asp:RadioButton ID="RadioButton2" GroupName="genero" runat="server" Text="Femenino" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

		            <asp:RadioButton ID="RadioButton3" GroupName="genero" runat="server" Text="Otro" />

                    <asp:CheckBoxList  ></asp:CheckBoxList>

                  </div>
                 
                  
                
                    <label>
                      <input type="checkbox"> He leído y aceptado los <a href="#">términos y condiciones.</a>  
                    </label>
                  
                  <div >
                      <br />
                     <button class="btn btn-default" href="#" style=" background-color:darkorange; color:white;  font-family:Arial; text-transform: none; font-size:large;" ><b>&nbsp;&nbsp;Crear Cuenta&nbsp;&nbsp;</b></button>
                  </div>
                </div>
              </form></center>
            </div>
          </div>
      
    </section>
<!-- FOOTER -->
<footer>
  <div class="footer clearfix">
    <div class="container">
      <div class="row">
        <div class="col-sm-3 col-xs-12">
          <div class="footerContent">
            <a href="index.html" class="footer-logo"><img src="img/logo-color-sm.png" alt="footer-logo"></a>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute </p>
          </div>
        </div>
        <div class="col-sm-3 col-xs-12">
          <div class="footerContent">
            <h5>contact us</h5>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit sed do eiusmod.</p>
            <ul class="list-unstyled">
              <li><i class="fa fa-home" aria-hidden="true"></i>61 Park Street, Fifth Avenue, NY</li>
              <li><i class="fa fa-phone" aria-hidden="true"></i>[88] 657 524 332</li>
              <li><i class="fa fa-envelope-o" aria-hidden="true"></i><a href="mailTo:info@star-travel.com">info@star-travel.com</a></li>
            </ul>
          </div>
        </div>
        <div class="col-sm-3 col-xs-12">
          <div class="footerContent imgGallery">
            <h5>Gallery</h5>
            <div class="row">
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-1.jpg"><img src="img/home/gallery/thumb-gallery-1.jpg" alt="image"></a>
              </div>
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-2.jpg"><img src="img/home/gallery/thumb-gallery-2.jpg" alt="image"></a>
              </div>
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-3.jpg"><img src="img/home/gallery/thumb-gallery-3.jpg" alt="image"></a>
              </div>
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-4.jpg"><img src="img/home/gallery/thumb-gallery-4.jpg" alt="image"></a>
              </div>
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-5.jpg"><img src="img/home/gallery/thumb-gallery-5.jpg" alt="image"></a>
              </div>
              <div class="col-xs-4">
                <a class="fancybox-pop" href="img/home/gallery/gallery-6.jpg"><img src="img/home/gallery/thumb-gallery-6.jpg" alt="image"></a>
              </div>
            </div>
          </div>
        </div>
        <div class="col-sm-3 col-xs-12">
          <div class="footerContent">
            <h5>newsletter</h5>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit sed do. </p>
            <div class="input-group">
              <input type="text" class="form-control" placeholder="Enter your email" aria-describedby="basic-addon21">
              <span class="input-group-addon" id="basic-addon21"><i class="fa fa-long-arrow-right" aria-hidden="true"></i></span>
            </div>
            <ul class="list-inline">
              <li><a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
              <li><a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
              <li><a href="#"><i class="fa fa-google-plus" aria-hidden="true"></i></a></li>
              <li><a href="#"><i class="fa fa-pinterest-p" aria-hidden="true"></i></a></li>
              <li><a href="#"><i class="fa fa-vimeo" aria-hidden="true"></i></a></li>
            </ul>
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class="copyRight clearfix">
    <div class="container">
      <div class="row">
        <div class="col-sm-6 col-sm-push-6 col-xs-12">
          <ul class="list-inline">
            <li><a href="#">Privacy Policy</a></li>
            <li><a href="#">About Us</a></li>
            <li><a href="#">Support</a></li>
            <li><a href="#">Blog</a></li>
          </ul>
        </div>
        <div class="col-sm-6 col-sm-pull-6 col-xs-12">
          <div class="copyRightText">
            <p>Copyright © 2016. All Rights Reserved by <a target="_blank" href="http://www.iamabdus.com/">Abdus</a>.</p>
          </div>
        </div>
      </div>
    </div>
  </div>
</footer>
</div>



<!-- Login Modal -->


</asp:Content>
