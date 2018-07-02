<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="editarEscuela.aspx.cs" Inherits="SurfTribeSystem1._0.editarEscuela" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="bookingTypeSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">

        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <center>
                    <div class="bookingType bg-ashs" style="width: 80%;">
                        
                        <br />
                        <br />

                        <center class="titulo" >
                                                                             <center>
                                                                                 <font size="7">
                                                                                     <b style="  color: black; border-radius: 484px; opacity: 0.8;" FACE="arial">Edición Escuelas</b>
                                                                                 </font>

                                                                             </center>

                                                                      </center>
                        
                        <br />

                        <div style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; 
                            -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75);
                            box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px;">

                            <div class="tab-content">
                                <div id="Lugar" class="tab-pane fade in active">
                                    <asp:UpdatePanel runat="server">
                                        <ContentTemplate>
                                    <section class="recentActivitySection">
                                        <div class="container">
                                            <div class="de">
                                                <div class="col-xs-12 ">
                                                    <div class="recentActivityContent bg-ashs">

                                                        <div class="container">

                                                            <div class="row">
                                                                <asp:Table ID="tabGeneral" runat="server" class="container col-sm-12">
                                                                    <asp:TableRow>
                                                                        <asp:TableCell>
                                                                            <div class="form-group" style="color: black; font-size: 20px;">
                                                                                <br />
                                                                                <label class="col-lg-3 control-label" for="focusedInput">Nombre</label>
                                                                                <div class="col-lg-5 txtnormal">
                                                                                    <asp:TextBox ID="txtNombre" runat="server"  class="form-control"></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />
                                                                            <div class="form-group" style="color: black; font-size: 20px;">
                                                                                <label class="col-lg-3 control-label" for="focusedInput">Ubicación</label>
                                                                                <div class="col-lg-5 txtnormal">
                                                                                    <asp:TextBox ID="txtUbicacion" runat="server"  class="form-control"></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />
                                                                            <div class="form-group" style="color: black; font-size: 20px; ">
                                                                                <label class="col-lg-3 control-label" for="focusedInput">Teléfono-1</label>
                                                                                <div class="col-lg-5 txtnormal">
                                                                                    <asp:TextBox ID="txtTelefono1" runat="server" class="form-control"></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />


                                                                            <div class="form-group" style="color: black; font-size: 20px; ">
                                                                                <label class="col-lg-3 control-label" for="inputEmail">Teléfono-2</label>
                                                                                <div class=" col-lg-5 txtnormal">
                                                                                    <asp:TextBox ID="txtTelefono2" runat="server" class="form-control" ></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />
                                                                            <div class="form-group" style="color: black; font-size: 20px; ">
                                                                                <label class="col-lg-3 control-label" for="focusedInput">Playa Concurrida</label>
                                                                                <div class="col-lg-5 txtPequeño">
                                                                                    <asp:TextBox ID="txtPlaya" runat="server" class="form-control" ></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />

                                                                            <div class="form-group" style="color: black; font-size: 20px; ">
                                                                                <label class="col-lg-3 control-label" for="focusedInput">Año de fundación</label>
                                                                                
                                                                                <div class="col-lg-5 txtPequeño">  
                                                                                    <asp:DropDownList ID="ddlZona" runat="server" CssClass="form-control"  >
                                                                                        <asp:ListItem Value="LIMON">LIMON</asp:ListItem>
                                                                                        <asp:ListItem Value="GUANACASTE">GUANACASTE</asp:ListItem>
                                                                                        <asp:ListItem Value="PUNTARENAS">PUNTARENAS</asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />


                                                                            <div class="form-group" style="color: black; font-size: 20px; ">
                                                                                <label class="col-lg-3 control-label" for="focusedInput">Correo</label>
                                                                                <div class="col-lg-5 txtPequeño">
                                                                                    <asp:TextBox ID="txtCorreo" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />

                                                                            <div class="form-group" style="color: black; font-size: 20px; ">
                                                                                <label class="col-lg-3 control-label" for="focusedInput">Descripción</label>
                                                                                <div class="col-lg-5 txtPequeño">
                                                                                    <asp:TextBox ID="txtDescripcion" runat="server" class="form-control"  TextMode="MultiLine"></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br /><br />

                                                                            <div class="form-group" style="color: black; font-size: 20px;">
                                                                                <label class="col-lg-3 control-label" for="focusedInput">Año de fundación</label>
                                                                                <div class="col-lg-5 txtPequeño">
                                                                                    <asp:TextBox ID="txtAnio" runat="server" class="form-control" ></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />

                                                                            <div class="form-group" style="color: black; font-size: 20px;">
                                                                                <label class="col-lg-3 control-label" for="focusedInput">Se encuentra activa?</label>
                                                                                <div class="col-lg-1 txtPequeño">
                                                                                    <asp:DropDownList ID="ddlActiva" runat="server" CssClass="form-control">
                                                                                        <asp:ListItem Value="true">Si</asp:ListItem>
                                                                                        <asp:ListItem Value="false">No</asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />

                                                                            <br />




                                                                        </asp:TableCell>
                                                                    </asp:TableRow>

                                                                </asp:Table>
                                                                <div >
                                                                    <asp:Button ID="idGuardar" Style="margin-left: 257px;" Text="Guardar" class="btn btn-success btn-lg" BackColor="SaddleBrown" OnClick="idGuardar_Click" CausesValidation="false" runat="server" />&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-primary" BackColor="Red" OnClick="btnCancelar_Click" CausesValidation="false" />

                                                                </div>


                                                            </div>

                                                        </div>

                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        </ContentTemplate>

            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="idGuardar" EventName="" />
            </Triggers>
        </asp:UpdatePanel>
                                    </section>

                                </div>


                            </div>

                        </div>
                            
                    </div>
                    </center>
                </div>
            </div>
        </div>

    </section>

</asp:Content>
