<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registrarse.aspx.cs" Inherits="SurfTribeSystem1._0.registrarse" %>

<%@ MasterType VirtualPath="~/Site1.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- PAGE TITLE -->
    <section class="pageTitle" style="background-image: url(ccss/star-1-3/Static HTML/img/pages/page-title-bg5.jpg);">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="titleTable">
                        <div class="titleTableInner">
                            <div class="pageTitleInfo">
                                <br />
                                <br />
                                <br />
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

         <form  method="POST"  role="form" class="form" id="form1" >

        <center><font size="14"><b FACE="arial" size="30%">Registrese</b></font></center>
        <br />
             <center>
                 <asp:Label ID="errorLabel" class="alert alert-danger alert-dismissible" runat="server" Visible="false"></asp:Label>  
                 <asp:Label ID="confirmaLabel" class="alert alert-success alert-dismissible" runat="server" Visible="false"></asp:Label>  

             </center>
             <br />
             <br />
       
        <div class="container">

            <div class="row">
                <center>
          
            
            <div class="bookingForm">
             <form  method="POST" role="form" class="form">
                <div class="row">
                  <div class="form-group" style=" width: 350px;">
                   
                      
                    <asp:TextBox class="form-control  bg-ash"  TextMode="Email" id="correoText" runat="server" placeholder="Correo electrónico" /><br />
                 
                   
                    <asp:TextBox class="form-control bg-ashh" TextMode="Password" id="contrasenaText" runat="server" placeholder="Contraseña"/><br />
                
                   
                    <asp:TextBox class="form-control bg-ashh" TextMode="Password" id="confirmaContrasenaText" runat="server" placeholder="Confirme su contraseña"/><br />
                  
                   
                    <asp:TextBox class="form-control bg-ashh" id="nombreText" runat="server" placeholder="Nombre"/><br />


                    <asp:TextBox class="form-control bg-ashh" id="apellidosText" runat="server" placeholder="Apellidos"/><br />
                
                    <asp:TextBox runat="server" type="number" class="form-control bg-ashh" placeholder="Teléfono" ID="telefonoText" ></asp:TextBox><br />


                    <asp:DropDownList ID="paisesList" runat="server" class="form-control bg-ash">
                        <asp:listitem value ="Afganistán">Afganistán</asp:listitem>
                        <asp:listitem value ="Alemania">Albania</asp:listitem >
                        <asp:listitem value ="Andorra">Andorra</asp:listitem >
                        <asp:listitem value ="Angola">Angola</asp:listitem >
                        <asp:listitem value ="Antigua y Barbuda">Antigua y Barbuda</asp:listitem >
                        <asp:listitem value ="Arabia Saudita">Arabia Saudita</asp:listitem >
                        <asp:listitem value ="Argentina">Argentina</asp:listitem >
                        <asp:listitem value ="Armenia">Armenia</asp:listitem>
                        <asp:listitem value ="Austria">Austria</asp:listitem >
                        <asp:listitem value ="Azerbaiyán">Azerbaiyán</asp:listitem >
                        <asp:listitem value ="Bahamas">Bahamas</asp:listitem >
                        <asp:listitem value ="Bangladés">Bangladés</asp:listitem >
                        <asp:listitem value ="Barbados">Barbados</asp:listitem >
                        <asp:listitem value ="Baréin">Baréin</asp:listitem >

                        <asp:listitem value ="Bélgica">Bélgica</asp:listitem>
                        <asp:listitem value ="Belice">Belice</asp:listitem >
                        <asp:listitem value ="Bielorrusia">Bielorrusia</asp:listitem >
                        <asp:listitem value ="Birmania">Birmania</asp:listitem >
                        <asp:listitem value ="Bolivia">Bolivia</asp:listitem >
                        <asp:listitem value ="Bosnia-Herzegovina">Bosnia-Herzegovina</asp:listitem >
                        <asp:listitem value ="Brasil">Brasil</asp:listitem>
                        <asp:listitem value ="Bulgaria">Bulgaria</asp:listitem >
                        <asp:listitem value ="Cabo Verde">Cabo Verde</asp:listitem >
                        <asp:listitem value ="Camboya">Camboya</asp:listitem >
                        <asp:listitem value ="Camerún">Camerún</asp:listitem >
                        <asp:listitem value ="Canadá">Canadá</asp:listitem >

                         
                        <asp:listitem value ="Catar">Catar</asp:listitem >
                        <asp:listitem value ="Chile">Chile</asp:listitem >
                        <asp:listitem value ="China">China</asp:listitem >
                        <asp:listitem value ="Chipre">Chipre</asp:listitem >
                        <asp:listitem value ="Colombia">Colombia</asp:listitem >
                        <asp:listitem value ="Congo">Congo</asp:listitem >
                        <asp:listitem value ="Corea del Norte">Corea del Norte</asp:listitem>
                        <asp:listitem value ="Corea del Sur">Corea del Sur</asp:listitem >
                        <asp:listitem value ="Costa de Marfil">Costa de Marfil</asp:listitem >
                        <asp:listitem value ="Costa Rica">Costa Rica</asp:listitem >
                        <asp:listitem value ="Croacia">Croacia</asp:listitem >
                        <asp:listitem value ="Cuba">Cuba</asp:listitem >
                        <asp:listitem value ="Dinamarca">Dinamarca</asp:listitem >

                        <asp:listitem value ="Dominica">Dominica</asp:listitem >
                        <asp:listitem value ="Ecuador">Ecuador</asp:listitem >
                        <asp:listitem value ="Egipto">Egipto</asp:listitem >
                        <asp:listitem value ="El Salvador">El Salvador</asp:listitem >
                        <asp:listitem value ="Emiratos Árabes Unidos">Emiratos Árabes Unidos</asp:listitem >
                        <asp:listitem value ="Eslovaquia">Eslovaquia</asp:listitem >
                        <asp:listitem value ="Eslovenia">Eslovenia</asp:listitem>
                        <asp:listitem value ="España">España</asp:listitem >
                        <asp:listitem value ="Estados Unidos">Estados Unidos</asp:listitem >
                        <asp:listitem value ="Estonia">Estonia</asp:listitem >
                        <asp:listitem value ="Etiopía">Etiopía</asp:listitem >
                        <asp:listitem value ="Filipinas">Filipinas</asp:listitem >
                        <asp:listitem value ="Finlandia">Finlandia</asp:listitem >

                        <asp:listitem value ="Fiyi">Fiyi</asp:listitem >
                        <asp:listitem value ="Francia">Francia</asp:listitem >
                        <asp:listitem value ="Gabón">Gabón</asp:listitem >
                        <asp:listitem value ="Gambia">Gambia</asp:listitem >
                        <asp:listitem value ="Georgia">Georgia</asp:listitem >
                        <asp:listitem value ="Ghana">Ghana</asp:listitem >
                        <asp:listitem value ="Granada">Granada</asp:listitem>
                        <asp:listitem value ="Grecia">Grecia</asp:listitem >
                        <asp:listitem value ="Guatemala">Guatemala</asp:listitem >
                        <asp:listitem value ="Guinea">Guinea</asp:listitem >
                        <asp:listitem value ="Guyana">Guyana</asp:listitem >
                        <asp:listitem value ="Haití">Haití</asp:listitem >
                        <asp:listitem value ="Honduras">Honduras</asp:listitem >

                        <asp:listitem value ="Hungría">Hungría</asp:listitem >
                        <asp:listitem value ="India">India</asp:listitem >
                        <asp:listitem value ="Indonesia">Indonesia</asp:listitem >
                        <asp:listitem value ="Irak">Irak</asp:listitem >
                        <asp:listitem value ="Irán">Irán</asp:listitem >
                        <asp:listitem value ="Irlanda">Irlanda</asp:listitem >
                        <asp:listitem value ="Islandia">Islandia</asp:listitem>
                        <asp:listitem value ="Islas Marshall">Islas Marshall</asp:listitem >
                        <asp:listitem value ="Islas Salomón">Islas Salomón</asp:listitem >
                        <asp:listitem value ="Israel">Israel</asp:listitem >
                        <asp:listitem value ="Italia">Italia</asp:listitem >
                        <asp:listitem value ="Jamaica">Jamaica</asp:listitem >
                        <asp:listitem value ="Japón">Japón</asp:listitem >

                        <asp:listitem value ="Jordania">Jordania</asp:listitem >
                        <asp:listitem value ="Kazajistán">Kazajistán</asp:listitem >
                        <asp:listitem value ="Kenia">Kenia</asp:listitem >
                        <asp:listitem value ="Kosovo">Kosovo</asp:listitem >
                        <asp:listitem value ="Kuwait">Kuwait</asp:listitem >
                        <asp:listitem value ="Laos">Laos</asp:listitem >
                        <asp:listitem value ="Letonia">Letonia</asp:listitem>
                        <asp:listitem value ="Líbano">Líbano</asp:listitem >
                        <asp:listitem value ="Liberia">Liberia</asp:listitem >
                        <asp:listitem value ="Libia">Libia</asp:listitem >
                        <asp:listitem value ="Lituania">Lituania</asp:listitem >
                        <asp:listitem value ="Luxemburgo">Luxemburgo</asp:listitem >
                        <asp:listitem value ="Macedonia">Macedonia</asp:listitem >

                         <asp:listitem value ="Madagascar">Madagascar</asp:listitem >
                        <asp:listitem value ="Malasia">Malasia</asp:listitem >
                        <asp:listitem value ="Maldivas">Maldivas</asp:listitem >
                        <asp:listitem value ="Malí">Malí</asp:listitem >
                        <asp:listitem value ="Malta">Malta</asp:listitem >
                        <asp:listitem value ="Marruecos">Marruecos</asp:listitem >
                        <asp:listitem value ="México">México</asp:listitem>
                        <asp:listitem value ="Mónaco">Mónaco</asp:listitem >
                        <asp:listitem value ="Mongolia">Mongolia</asp:listitem >
                        <asp:listitem value ="Montenegro">Montenegro</asp:listitem >
                        <asp:listitem value ="Mozambique">Mozambique</asp:listitem >
                        <asp:listitem value ="Nepal">Nepal</asp:listitem >
                        <asp:listitem value ="Nicaragua">Nicaragua</asp:listitem >

                          <asp:listitem value ="Nigeria">Nigeria</asp:listitem >
                        <asp:listitem value ="Noruega">Noruega</asp:listitem >
                        <asp:listitem value ="Nueva Zelanda">Nueva Zelanda</asp:listitem >
                        <asp:listitem value ="Países Bajos">Países Bajos</asp:listitem >
                        <asp:listitem value ="Pakistán">Pakistán</asp:listitem >
                        <asp:listitem value ="Palestina	">Palestina	</asp:listitem >
                        <asp:listitem value ="Panamá">Panamá</asp:listitem>
                        <asp:listitem value ="Papúa Nueva Guinea">Papúa Nueva Guinea</asp:listitem >
                        <asp:listitem value ="Paraguay">Paraguay</asp:listitem >
                        <asp:listitem value ="Perú">Perú</asp:listitem >
                        <asp:listitem value ="Polonia">Polonia</asp:listitem >
                        <asp:listitem value ="Portugal">Portugal</asp:listitem >
                        <asp:listitem value ="Reino Unido">Reino Unido</asp:listitem >

                        <asp:listitem value ="República Centroafricana">República Centroafricana</asp:listitem >
                        <asp:listitem value ="República Checa">República Checa</asp:listitem >
                        <asp:listitem value ="República Democrática del Congo">República Democrática del Congo</asp:listitem >
                        <asp:listitem value ="República Dominicana">República Dominicana</asp:listitem >
                        <asp:listitem value ="Ruanda">Ruanda</asp:listitem >
                        <asp:listitem value ="Rumania">Rumania</asp:listitem >
                        <asp:listitem value ="Rusia">Rusia</asp:listitem>
                        <asp:listitem value ="San Cristóbal y Nieves">San Cristóbal y Nieves</asp:listitem >
                        <asp:listitem value ="San Marino">San Marino</asp:listitem >
                        <asp:listitem value ="San Vicente y las Granadinas">San Vicente y las Granadinas</asp:listitem >
                        <asp:listitem value ="Santa Lucía">Santa Lucía</asp:listitem >
                        <asp:listitem value ="Portugal">Portugal</asp:listitem >
                        <asp:listitem value ="Santo Tomé y Príncipe">Santo Tomé y Príncipe</asp:listitem >

                        <asp:listitem value ="Senegal">Senegal</asp:listitem >
                        <asp:listitem value ="Serbia">Serbia</asp:listitem >
                        <asp:listitem value ="Sierra Leona">Sierra Leona</asp:listitem >
                        <asp:listitem value ="Singapur">Singapur</asp:listitem >
                        <asp:listitem value ="Siria">Siria</asp:listitem >
                        <asp:listitem value ="Somalia">Somalia</asp:listitem >
                        <asp:listitem value ="Sudáfrica">Sudáfrica</asp:listitem>
                        <asp:listitem value ="Sudán">Sudán</asp:listitem >
                        <asp:listitem value ="Suecia">Suecia</asp:listitem >
                        <asp:listitem value ="Suiza">Suiza</asp:listitem >
                        <asp:listitem value ="Surinam">Surinam</asp:listitem >
                        <asp:listitem value ="Tailandia">Tailandial</asp:listitem >
                        <asp:listitem value ="Taiwán">Taiwán</asp:listitem >

                         <asp:listitem value ="Tanzania">Tanzania</asp:listitem >
                        <asp:listitem value ="Togo">Togo</asp:listitem >
                        <asp:listitem value ="Trinidad y Tobago">Trinidad y Tobago</asp:listitem >
                        <asp:listitem value ="Túnez">Túnez</asp:listitem >
                        <asp:listitem value ="Turquía">Turquía</asp:listitem >
                        <asp:listitem value ="Ucrania">Ucrania</asp:listitem >
                        <asp:listitem value ="Uganda">Uganda</asp:listitem>
                        <asp:listitem value ="Uruguay">Uruguay</asp:listitem >
                        <asp:listitem value ="Venezuela">Venezuela</asp:listitem >
                        <asp:listitem value ="Vietnam">Vietnam</asp:listitem >
                        <asp:listitem value ="Zambia">Zambia</asp:listitem >
                       

                    </asp:DropDownList>

                  </div>
                 
                  
                
                    <label>
                      <input type="checkbox"> He leído y aceptado los <a href="#">términos y condiciones.</a>  
                    </label>
                  
                  <div >
                      <br />
                     <asp:button class="btn btn-default" OnClick="registrar_Click" runat="server" style=" background-color:darkorange; color:white;  font-family:Arial; text-transform: none; font-size:large;" Text=" Crear Cuenta " ></asp:button>
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
                        <asp:Button ID="ingresarButton" type="submit" class="btn btn-default" runat="server" Text="Ingresar" OnClick="ingresarButton_Click" />
                       
                       
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
              </form></center>
           

    </section>
    


</asp:Content>
