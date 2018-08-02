<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="registroSesion.aspx.cs" Inherits="SurfTribeSystem1._0.reservaSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
      

                <br />
                <div class="row">
                    <div class="col-xs-12">
                        <div class="sectionTitle">
                            <h2>
                                <asp:Label runat="server" ID="tituloLabel" Text="Registro de Sesiones" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                        </div>

                    </div>
                </div>
                <br />
                <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 11px;">
                              <div class="row" style="background-color: rgba(108, 161, 121, 0.5); border: solid 0.40px #009510; border-radius: 8px; margin: 0.3%; padding: 0.3%;" >
                        <div class="col-xs-12 col-sm-4" >
                            <ul>
                                <li>
                                    <div class="col-xs-12 col-sm-10">
                                    <label style="color: saddlebrown; font-size: x-large">Fecha de la Reserva:</label>
                                        </div>
                                </li>
                                <li>
                                     <div class="col-xs-12 col-sm-10">
                                    <asp:DropDownList ID="ddlfecha" runat="server" CssClass="bg-ashh" Width="100%" style="color:black; font-size:large;" AutoPostBack="true" DataTextField=""
                                        DataValueField="" >
                                    </asp:DropDownList>
                                         </div>


                                </li>
                            </ul>

                        </div>
                        <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li><div class="col-xs-12 col-sm-10">
                                    <label style="color: saddlebrown; font-size: x-large">Instructor a Cargo:</label>
                                    </div>
                                </li>
                                <li>
                                      <div class="col-xs-12 col-sm-10">
                                    <asp:DropDownList ID="ddlIns" runat="server" CssClass="bg-ashh" Width="100%" style="color:black; font-size:large;" AutoPostBack="true" DataTextField=""
                                        DataValueField="" >
                                    </asp:DropDownList>
                                          </div>
                                </li>
                            </ul>
                        </div>

                        <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li><div class="col-xs-12 col-sm-10">
                                    <label style="color: saddlebrown; font-size: x-large">Dificultad:</label>
                                    </div>
                                </li>
                                <li>
                                      <div class="col-xs-12 col-sm-10">
                                    <asp:DropDownList ID="ddlDificultad" runat="server" CssClass="bg-ashh" Width="100%" style="color:black; font-size:large;" AutoPostBack="true" DataTextField=""
                                        DataValueField="" >
                                    </asp:DropDownList>
                                          </div>

                                </li>
                            </ul>

                        </div>
                                    <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li><br /><br />
                                    <div class="col-xs-12 col-sm-10">
                                    <label style="color: saddlebrown; font-size: x-large">Hora Inicio:</label>
                                        </div>
                                </li>
                                <li>
                                    <div class="col-xs-12 col-sm-10">
                                    <asp:DropDownList ID="ddlHi" runat="server" CssClass="bg-ashh" Width="100%" style="color:black; font-size:large;" AutoPostBack="true" DataTextField=""
                                        DataValueField="" >
                                    </asp:DropDownList>
                                        </div>

                                </li>

                            </ul>

                        </div>
                                  
                        <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li><br /><br />
                                    <div class="col-xs-12 col-sm-10">
                                    <label style="color: saddlebrown; font-size: x-large">Hora Final:</label>
                                        </div>
                                </li>
                                <li>
                                    <div class="col-xs-12 col-sm-10">
                                    <asp:DropDownList ID="ddlHf" runat="server" CssClass="bg-ashh" Width="100%" style="color:black; font-size:large;" AutoPostBack="true" DataTextField=""
                                        DataValueField="" >
                                    </asp:DropDownList>
                                        </div>

                                </li>

                            </ul>

                        </div>
                                     <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li><br /><br />
                                    <div class="col-xs-12 col-sm-10">
                                    <label style="color: saddlebrown; font-size: x-large">Cupos Disponibles:</label>
                                        </div>
                                </li>
                                <li>
                                    <div class="col-xs-12 col-sm-10">
                                        <asp:textbox runat="server" id="txtCupos" style="width: 99%; height: 45px;" TextMode="number"></asp:textbox>
                                        </div>

                                </li>

                            </ul>

                        </div>
                                  <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li>
                                    <br /><br /><br />
                                    <center>
                                    <div class="col-xs-12 col-sm-10">
            <asp:Button ID="btnGenerar" class="btn btn-default btn-circle-2 " BackColor="SaddleBrown" ForeColor="White"
                                        runat="server" Text="Crear Sesion" Width="200px"  />
                                        </div>
                                        </center>


                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            
    </section>
</asp:Content>
