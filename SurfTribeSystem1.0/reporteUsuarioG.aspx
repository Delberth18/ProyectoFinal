<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reporteUsuarioG.aspx.cs" Inherits="SurfTribeSystem1._0.reporteUsuarioG" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="ccss/star-1-3/SCSS/js/jquery-2.1.4.min.js"></script>
    <script src="ccss/star-1-3/SCSS/js/jspdf.debug.js"></script>
    <style type="text/css">
        .form_input {
            font-family: Verdana;
            font-size: 12;
            background-color: white;
            border-width: 0;
            text-align: right;
        }
    </style>
    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <br />
        <div class="row">
            <div class="col-xs-12">
                <div class="sectionTitle">
                    <h2>
                        <asp:Label runat="server" ID="tituloLabel" Text="Reporte de usuarios" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                </div>

            </div>
        </div>
        <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div>
                        <div class="col-xs-12 col-sm-3">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Escuela:</label>
                                </li>
                                <li>
                                    <asp:DropDownList ID="escuelaLst" runat="server" CssClass="bg-ashh" Width="100%" AutoPostBack="true" DataTextField=""
                                        DataValueField="" OnSelectedIndexChanged="reporteEscuela" ForeColor="Black" Style="font-size: large">
                                    </asp:DropDownList>
                                </li>
                            </ul>

                        </div>
                        <div class="col-xs-12 col-sm-3">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">País:</label>
                                </li>
                                <li>
                                    <asp:DropDownList ID="paisLst" runat="server" CssClass="bg-ashh" Width="100%" AutoPostBack="true" DataTextField=""
                                        DataValueField="" OnSelectedIndexChanged="reporteEscuela" ForeColor="Black" Style="font-size: large">

                                        <asp:ListItem Selected="True">Seleccione un país</asp:ListItem>
                                        <asp:ListItem Value="Afganistán">Afganistán</asp:ListItem>
                                        <asp:ListItem Value="Alemania">Albania</asp:ListItem>
                                        <asp:ListItem Value="Andorra">Andorra</asp:ListItem>
                                        <asp:ListItem Value="Angola">Angola</asp:ListItem>
                                        <asp:ListItem Value="Antigua y Barbuda">Antigua y Barbuda</asp:ListItem>
                                        <asp:ListItem Value="Arabia Saudita">Arabia Saudita</asp:ListItem>
                                        <asp:ListItem Value="Argentina">Argentina</asp:ListItem>
                                        <asp:ListItem Value="Armenia">Armenia</asp:ListItem>
                                        <asp:ListItem Value="Austria">Austria</asp:ListItem>
                                        <asp:ListItem Value="Azerbaiyán">Azerbaiyán</asp:ListItem>
                                        <asp:ListItem Value="Bahamas">Bahamas</asp:ListItem>
                                        <asp:ListItem Value="Bangladés">Bangladés</asp:ListItem>
                                        <asp:ListItem Value="Barbados">Barbados</asp:ListItem>
                                        <asp:ListItem Value="Baréin">Baréin</asp:ListItem>

                                        <asp:ListItem Value="Bélgica">Bélgica</asp:ListItem>
                                        <asp:ListItem Value="Belice">Belice</asp:ListItem>
                                        <asp:ListItem Value="Bielorrusia">Bielorrusia</asp:ListItem>
                                        <asp:ListItem Value="Birmania">Birmania</asp:ListItem>
                                        <asp:ListItem Value="Bolivia">Bolivia</asp:ListItem>
                                        <asp:ListItem Value="Bosnia-Herzegovina">Bosnia-Herzegovina</asp:ListItem>
                                        <asp:ListItem Value="Brasil">Brasil</asp:ListItem>
                                        <asp:ListItem Value="Bulgaria">Bulgaria</asp:ListItem>
                                        <asp:ListItem Value="Cabo Verde">Cabo Verde</asp:ListItem>
                                        <asp:ListItem Value="Camboya">Camboya</asp:ListItem>
                                        <asp:ListItem Value="Camerún">Camerún</asp:ListItem>
                                        <asp:ListItem Value="Canadá">Canadá</asp:ListItem>


                                        <asp:ListItem Value="Catar">Catar</asp:ListItem>
                                        <asp:ListItem Value="Chile">Chile</asp:ListItem>
                                        <asp:ListItem Value="China">China</asp:ListItem>
                                        <asp:ListItem Value="Chipre">Chipre</asp:ListItem>
                                        <asp:ListItem Value="Colombia">Colombia</asp:ListItem>
                                        <asp:ListItem Value="Congo">Congo</asp:ListItem>
                                        <asp:ListItem Value="Corea del Norte">Corea del Norte</asp:ListItem>
                                        <asp:ListItem Value="Corea del Sur">Corea del Sur</asp:ListItem>
                                        <asp:ListItem Value="Costa de Marfil">Costa de Marfil</asp:ListItem>
                                        <asp:ListItem Value="Costa Rica">Costa Rica</asp:ListItem>
                                        <asp:ListItem Value="Croacia">Croacia</asp:ListItem>
                                        <asp:ListItem Value="Cuba">Cuba</asp:ListItem>
                                        <asp:ListItem Value="Dinamarca">Dinamarca</asp:ListItem>

                                        <asp:ListItem Value="Dominica">Dominica</asp:ListItem>
                                        <asp:ListItem Value="Ecuador">Ecuador</asp:ListItem>
                                        <asp:ListItem Value="Egipto">Egipto</asp:ListItem>
                                        <asp:ListItem Value="El Salvador">El Salvador</asp:ListItem>
                                        <asp:ListItem Value="Emiratos Árabes Unidos">Emiratos Árabes Unidos</asp:ListItem>
                                        <asp:ListItem Value="Eslovaquia">Eslovaquia</asp:ListItem>
                                        <asp:ListItem Value="Eslovenia">Eslovenia</asp:ListItem>
                                        <asp:ListItem Value="España">España</asp:ListItem>
                                        <asp:ListItem Value="Estados Unidos">Estados Unidos</asp:ListItem>
                                        <asp:ListItem Value="Estonia">Estonia</asp:ListItem>
                                        <asp:ListItem Value="Etiopía">Etiopía</asp:ListItem>
                                        <asp:ListItem Value="Filipinas">Filipinas</asp:ListItem>
                                        <asp:ListItem Value="Finlandia">Finlandia</asp:ListItem>

                                        <asp:ListItem Value="Fiyi">Fiyi</asp:ListItem>
                                        <asp:ListItem Value="Francia">Francia</asp:ListItem>
                                        <asp:ListItem Value="Gabón">Gabón</asp:ListItem>
                                        <asp:ListItem Value="Gambia">Gambia</asp:ListItem>
                                        <asp:ListItem Value="Georgia">Georgia</asp:ListItem>
                                        <asp:ListItem Value="Ghana">Ghana</asp:ListItem>
                                        <asp:ListItem Value="Granada">Granada</asp:ListItem>
                                        <asp:ListItem Value="Grecia">Grecia</asp:ListItem>
                                        <asp:ListItem Value="Guatemala">Guatemala</asp:ListItem>
                                        <asp:ListItem Value="Guinea">Guinea</asp:ListItem>
                                        <asp:ListItem Value="Guyana">Guyana</asp:ListItem>
                                        <asp:ListItem Value="Haití">Haití</asp:ListItem>
                                        <asp:ListItem Value="Honduras">Honduras</asp:ListItem>

                                        <asp:ListItem Value="Hungría">Hungría</asp:ListItem>
                                        <asp:ListItem Value="India">India</asp:ListItem>
                                        <asp:ListItem Value="Indonesia">Indonesia</asp:ListItem>
                                        <asp:ListItem Value="Irak">Irak</asp:ListItem>
                                        <asp:ListItem Value="Irán">Irán</asp:ListItem>
                                        <asp:ListItem Value="Irlanda">Irlanda</asp:ListItem>
                                        <asp:ListItem Value="Islandia">Islandia</asp:ListItem>
                                        <asp:ListItem Value="Islas Marshall">Islas Marshall</asp:ListItem>
                                        <asp:ListItem Value="Islas Salomón">Islas Salomón</asp:ListItem>
                                        <asp:ListItem Value="Israel">Israel</asp:ListItem>
                                        <asp:ListItem Value="Italia">Italia</asp:ListItem>
                                        <asp:ListItem Value="Jamaica">Jamaica</asp:ListItem>
                                        <asp:ListItem Value="Japón">Japón</asp:ListItem>

                                        <asp:ListItem Value="Jordania">Jordania</asp:ListItem>
                                        <asp:ListItem Value="Kazajistán">Kazajistán</asp:ListItem>
                                        <asp:ListItem Value="Kenia">Kenia</asp:ListItem>
                                        <asp:ListItem Value="Kosovo">Kosovo</asp:ListItem>
                                        <asp:ListItem Value="Kuwait">Kuwait</asp:ListItem>
                                        <asp:ListItem Value="Laos">Laos</asp:ListItem>
                                        <asp:ListItem Value="Letonia">Letonia</asp:ListItem>
                                        <asp:ListItem Value="Líbano">Líbano</asp:ListItem>
                                        <asp:ListItem Value="Liberia">Liberia</asp:ListItem>
                                        <asp:ListItem Value="Libia">Libia</asp:ListItem>
                                        <asp:ListItem Value="Lituania">Lituania</asp:ListItem>
                                        <asp:ListItem Value="Luxemburgo">Luxemburgo</asp:ListItem>
                                        <asp:ListItem Value="Macedonia">Macedonia</asp:ListItem>

                                        <asp:ListItem Value="Madagascar">Madagascar</asp:ListItem>
                                        <asp:ListItem Value="Malasia">Malasia</asp:ListItem>
                                        <asp:ListItem Value="Maldivas">Maldivas</asp:ListItem>
                                        <asp:ListItem Value="Malí">Malí</asp:ListItem>
                                        <asp:ListItem Value="Malta">Malta</asp:ListItem>
                                        <asp:ListItem Value="Marruecos">Marruecos</asp:ListItem>
                                        <asp:ListItem Value="México">México</asp:ListItem>
                                        <asp:ListItem Value="Mónaco">Mónaco</asp:ListItem>
                                        <asp:ListItem Value="Mongolia">Mongolia</asp:ListItem>
                                        <asp:ListItem Value="Montenegro">Montenegro</asp:ListItem>
                                        <asp:ListItem Value="Mozambique">Mozambique</asp:ListItem>
                                        <asp:ListItem Value="Nepal">Nepal</asp:ListItem>
                                        <asp:ListItem Value="Nicaragua">Nicaragua</asp:ListItem>

                                        <asp:ListItem Value="Nigeria">Nigeria</asp:ListItem>
                                        <asp:ListItem Value="Noruega">Noruega</asp:ListItem>
                                        <asp:ListItem Value="Nueva Zelanda">Nueva Zelanda</asp:ListItem>
                                        <asp:ListItem Value="Países Bajos">Países Bajos</asp:ListItem>
                                        <asp:ListItem Value="Pakistán">Pakistán</asp:ListItem>
                                        <asp:ListItem Value="Palestina	">Palestina	</asp:ListItem>
                                        <asp:ListItem Value="Panamá">Panamá</asp:ListItem>
                                        <asp:ListItem Value="Papúa Nueva Guinea">Papúa Nueva Guinea</asp:ListItem>
                                        <asp:ListItem Value="Paraguay">Paraguay</asp:ListItem>
                                        <asp:ListItem Value="Perú">Perú</asp:ListItem>
                                        <asp:ListItem Value="Polonia">Polonia</asp:ListItem>
                                        <asp:ListItem Value="Portugal">Portugal</asp:ListItem>
                                        <asp:ListItem Value="Reino Unido">Reino Unido</asp:ListItem>

                                        <asp:ListItem Value="República Centroafricana">República Centroafricana</asp:ListItem>
                                        <asp:ListItem Value="República Checa">República Checa</asp:ListItem>
                                        <asp:ListItem Value="República Democrática del Congo">República Democrática del Congo</asp:ListItem>
                                        <asp:ListItem Value="República Dominicana">República Dominicana</asp:ListItem>
                                        <asp:ListItem Value="Ruanda">Ruanda</asp:ListItem>
                                        <asp:ListItem Value="Rumania">Rumania</asp:ListItem>
                                        <asp:ListItem Value="Rusia">Rusia</asp:ListItem>
                                        <asp:ListItem Value="San Cristóbal y Nieves">San Cristóbal y Nieves</asp:ListItem>
                                        <asp:ListItem Value="San Marino">San Marino</asp:ListItem>
                                        <asp:ListItem Value="San Vicente y las Granadinas">San Vicente y las Granadinas</asp:ListItem>
                                        <asp:ListItem Value="Santa Lucía">Santa Lucía</asp:ListItem>
                                        <asp:ListItem Value="Portugal">Portugal</asp:ListItem>
                                        <asp:ListItem Value="Santo Tomé y Príncipe">Santo Tomé y Príncipe</asp:ListItem>

                                        <asp:ListItem Value="Senegal">Senegal</asp:ListItem>
                                        <asp:ListItem Value="Serbia">Serbia</asp:ListItem>
                                        <asp:ListItem Value="Sierra Leona">Sierra Leona</asp:ListItem>
                                        <asp:ListItem Value="Singapur">Singapur</asp:ListItem>
                                        <asp:ListItem Value="Siria">Siria</asp:ListItem>
                                        <asp:ListItem Value="Somalia">Somalia</asp:ListItem>
                                        <asp:ListItem Value="Sudáfrica">Sudáfrica</asp:ListItem>
                                        <asp:ListItem Value="Sudán">Sudán</asp:ListItem>
                                        <asp:ListItem Value="Suecia">Suecia</asp:ListItem>
                                        <asp:ListItem Value="Suiza">Suiza</asp:ListItem>
                                        <asp:ListItem Value="Surinam">Surinam</asp:ListItem>
                                        <asp:ListItem Value="Tailandia">Tailandial</asp:ListItem>
                                        <asp:ListItem Value="Taiwán">Taiwán</asp:ListItem>

                                        <asp:ListItem Value="Tanzania">Tanzania</asp:ListItem>
                                        <asp:ListItem Value="Togo">Togo</asp:ListItem>
                                        <asp:ListItem Value="Trinidad y Tobago">Trinidad y Tobago</asp:ListItem>
                                        <asp:ListItem Value="Túnez">Túnez</asp:ListItem>
                                        <asp:ListItem Value="Turquía">Turquía</asp:ListItem>
                                        <asp:ListItem Value="Ucrania">Ucrania</asp:ListItem>
                                        <asp:ListItem Value="Uganda">Uganda</asp:ListItem>
                                        <asp:ListItem Value="Uruguay">Uruguay</asp:ListItem>
                                        <asp:ListItem Value="Venezuela">Venezuela</asp:ListItem>
                                        <asp:ListItem Value="Vietnam">Vietnam</asp:ListItem>
                                        <asp:ListItem Value="Zambia">Zambia</asp:ListItem>

                                    </asp:DropDownList>
                                </li>
                            </ul>
                        </div>

                        <div class="col-xs-12 col-sm-3">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Estado:</label>
                                </li>
                                <li>

                                    <asp:DropDownList ID="estadoLst" runat="server" CssClass="bg-ashh" Width="100%" AutoPostBack="true" DataTextField=""
                                        DataValueField="" OnSelectedIndexChanged="reporteEscuela" ForeColor="Black" Style="font-size: large">
                                        <asp:ListItem>ACTIVO</asp:ListItem>
                                        <asp:ListItem>BLOQUEADO</asp:ListItem>
                                        <asp:ListItem>INACTIVO</asp:ListItem>
                                        <asp:ListItem Selected="True">Seleccione un estado</asp:ListItem>
                                    </asp:DropDownList>

                                </li>
                            </ul>

                        </div>
                        <div class="col-xs-12 col-sm-3">
                            <ul>
                                <li>
                                    <br />
                                    <asp:Button ID="btnRefrescar" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White"
                                        runat="server" Text="Refrescar" Width="150px" OnClick="reporteEscuela" />
                                </li>

                            </ul>

                        </div>
                    </div>

                    

                        <div class="col-xs-12">
                            <br />
                            <div class="col-md-12">
                                <div class="col-md-1" style="color: saddlebrown; text-align: center; font-size: x-large; font-weight: bold">
                                    Nombre
                                </div>
                                <div class="col-md-2" style="color: saddlebrown; text-align: center; font-size: x-large; font-weight: bold">
                                    Apellidos
                                </div>
                                <div class="col-md-1" style="color: saddlebrown; text-align: center; font-size: x-large; font-weight: bold">
                                    Teléfono
                                </div>
                                <div class="col-md-3" style="color: saddlebrown; text-align: center; font-size: x-large; font-weight: bold">
                                    Correo
                                </div>
                                <div class="col-md-2" style="color: saddlebrown; text-align: center; font-size: x-large; font-weight: bold">
                                    Tipo Usuario
                                </div>
                                <div class="col-md-1" style="color: saddlebrown; text-align: center; font-size: x-large; font-weight: bold">
                                    Estado
                                </div>
                                <div class="col-md-2" style="color: saddlebrown; text-align: center; font-size: x-large; font-weight: bold">
                                    Escuela
                                </div>
                            </div>
                            <asp:Repeater ID="imagenesList" runat="server">

                                <ItemTemplate>
                                    <div class="col-md-12" style="border-bottom: solid; border-color: saddlebrown; border-width: 2px">
                                        <div class="col-md-1" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: center; font-size: medium"><%# Eval("Nombre") %>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-md-2" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: center; font-size: medium"><%# Eval("Apellidos") %>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-md-1" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: center; font-size: medium"><%# Eval("Telefono") %>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-md-3" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: center; font-size: medium"><%# Eval("Correo") %>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-md-2" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: center; font-size: medium"><%# Eval("Tipo_usu_dsc") %>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-md-1" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: center; font-size: medium"><%# Eval("Estado") %> 
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-md-2" >
                                            <ul>
                                                <li style="color: black; font-weight: bold;text-align: center; font-size: medium"><%# Eval("Escuela_dsc") %> 
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <br />
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                        </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="escuelaLst" EventName="" />
                    <asp:AsyncPostBackTrigger ControlID="paisLst" EventName="" />
                    <asp:AsyncPostBackTrigger ControlID="estadoLst" EventName="" />
                </Triggers>
            </asp:UpdatePanel>
                        <div class="col-xs-12">
                            <br />
                            <asp:Button ID="btnGenerar" class="btn btn-default btn-circle-2 " BackColor="SaddleBrown" ForeColor="White"
                                runat="server" Text="Generar Reporte" Width="200px" OnClick="GenerarReporte" />
                        </div>
                    </div>
                

        </div>

    </section>
</asp:Content>

