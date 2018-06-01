<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FAQRegistro.aspx.cs" Inherits="SurfTribeSystem1._0.FAQRegistro" %>

<%@ MasterType VirtualPath="~/Site1.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- PAGE TITLE -->
    <section class="pageTitle" style="background-image: url(ccss/star-1-3/Static%20HTML/img/pages/page-title-bg7.jpg);">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="titleTable">
                        <div class="titleTableInner">
                            <div class="pageTitleInfo">
                                <br />
                                <br />
                                <br />
                                <h1>Resgistro de preguntas</h1>
                                <div class="under-border"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- WHITE SECTION FILTER-->

    <section class="mainContentSection" style="background-color:#f5f5f5;" >

         <form  method="POST"  role="form" class="form" id="form1"  >

        <center><font size="14"><b FACE="arial" size="30%">Preguntas frecuentes</b></font></center>
        <br />
             <center >
                 <asp:Label ID="errorLabel" class="alert alert-danger alert-dismissible" runat="server" Visible="false" ></asp:Label>  
                 <asp:Label ID="confirmaLabel" class="alert alert-success alert-dismissible" runat="server" Visible="false"></asp:Label>  

             </center>
             <br />
             <br />
       
        <div class="container">

            <div class="row">
                <center>
          
            
            <div class="bookingForm">
             <form  method="POST" role="form" class="form">
                <div class="row"">
                  <div class="form-group" style=" 
                            border: solid 1px #000000;
                            border-top-left-radius:27px;
                            border-top-right-radius:27px;
                            border-bottom-left-radius:27px;
                            border-bottom-right-radius:28px;  padding:15px 15px 15px 15px; width: 100%; background-color:white" >
                   
                      
                    <asp:TextBox class="form-control  bg-ashh"  id="preguntaText" runat="server" placeholder="Escriba la pregunta" /><br />
                 
                   
                    <asp:TextBox Rows="14" class="form-control bg-ashh" TextMode="MultiLine" id="respuestaText" runat="server" placeholder="Escriba la respuesta"/><br />

                  </div>
                 
                  
                  <div >
                      <br />
                     <asp:button class="btn btn-default" OnClick="Guardar_Click" runat="server" style="padding:15px; background-color:darkorange; color:white;  font-family:Arial; text-transform: none; font-size:large;" Text=" Guardar pregunta " ></asp:button>
                  </div>
                </div>
                     <div class="modal fade signupLoging" id="login" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content modalContentCustom">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabel">INICIO DE SESIÓN</h4>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <asp:TextBox TextMode="Email" ID="correoText1" runat="server" class="form-control bg-ash" placeholder="Correo" />
                        </div>
                        <div class="form-group">
                            <asp:TextBox TextMode="Password" ID="claveText" runat="server" class="form-control bg-ash" placeholder="Clave" />
                        </div>
                        <div class="checkbox">
                            
                            <a class="forgotPass clerfix">Olvido su contraseña?</a><br />
                        </div>
                        <asp:Button ID="ingresarButton" type="submit" class="btn btn-default" runat="server" Text="Ingresar"  />
                       
                       
                    </div>

                    <div class="modal-footer">
                        <div class="dontHaveAccount">
                            <p>Olvido su contraseña?<a href="registrarse.aspx"> Registrese</a></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>


             </form> </div></div>
        </div>
              </form>
           

    </section>
    


</asp:Content>
