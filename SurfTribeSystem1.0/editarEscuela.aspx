<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="editarEscuela.aspx.cs" Inherits="SurfTribeSystem1._0.editarEscuela" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">

        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <center>
                    <div class="bookingType bg-ashs" style="width: 80%;">
                        
                        <br />
                        <br />
          <div class="row">
                <div class="col-xs-12">
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="tituloLabel" Text="Edición Escuelas" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                    </div>
                    
                </div>
            </div>
                        
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
                                            
                                                   

                                                            <div class="row">
                                                                <asp:Table ID="tabGeneral" runat="server" CssClass="col-xs-12 col-sm-12" >
                                                                    <asp:TableRow>
                                                                        <asp:TableCell>
                                                                            <div class="form-group" style="color: saddlebrown; font-size: x-large;">
                                                                                <br />
                                                                                <label class="col-lg-4 control-label" for="focusedInput">Nombre</label>
                                                                                <div class="col-lg-5 ">
                                                                                    <asp:TextBox ID="txtNombre" runat="server"  class="form-control"></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />
                                                                            <div class="form-group" style="color: saddlebrown; font-size: x-large;">
                                                                                <label class="col-lg-4 control-label" for="focusedInput">Ubicación</label>
                                                                                <div class="col-lg-5 ">
                                                                                    <asp:TextBox ID="txtUbicacion" runat="server"  class="form-control"></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />
                                                                            <div class="form-group" style="color: saddlebrown; font-size: x-large; ">
                                                                                <label class="col-lg-4 control-label" for="focusedInput">Teléfono-1</label>
                                                                                <div class="col-lg-5 ">
                                                                                    <asp:TextBox ID="txtTelefono1" runat="server" class="form-control"></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />


                                                                            <div class="form-group" style="color: saddlebrown; font-size: x-large; ">
                                                                                <label class="col-lg-4 control-label" for="inputEmail">Teléfono-2</label>
                                                                                <div class=" col-lg-5 ">
                                                                                    <asp:TextBox ID="txtTelefono2" runat="server" class="form-control" ></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />
                                                                            <div class="form-group" style="color: saddlebrown; font-size: x-large; ">
                                                                                <label class="col-lg-4 control-label" for="focusedInput">Playa Concurrida</label>
                                                                                <div class="col-lg-5 ">
                                                                                    <asp:TextBox ID="txtPlaya" runat="server" class="form-control" ></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />

                                                                            <div class="form-group" style="color: saddlebrown; font-size: x-large; ">
                                                                                <label class="col-lg-4 control-label" for="focusedInput">Año de fundación</label>
                                                                                
                                                                                <div class="col-lg-5 ">  
                                                                                    <asp:DropDownList ID="ddlZona" runat="server" CssClass="form-control"  >
                                                                                        <asp:ListItem Value="LIMON">LIMON</asp:ListItem>
                                                                                        <asp:ListItem Value="GUANACASTE">GUANACASTE</asp:ListItem>
                                                                                        <asp:ListItem Value="PUNTARENAS">PUNTARENAS</asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />


                                                                            <div class="form-group" style="color: saddlebrown; font-size: x-large; ">
                                                                                <label class="col-lg-4 control-label" for="focusedInput">Correo</label>
                                                                                <div class="col-lg-5 ">
                                                                                    <asp:TextBox ID="txtCorreo" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />

                                                                            <div class="form-group" style="color: saddlebrown; font-size: x-large; ">
                                                                                <label class="col-lg-4 control-label" for="focusedInput">Descripción</label>
                                                                                <div class="col-lg-5 ">
                                                                                    <asp:TextBox ID="txtDescripcion" runat="server" class="form-control"  TextMode="MultiLine"></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br /><br />

                                                                            <div class="form-group" style="color: saddlebrown; font-size: x-large;">
                                                                                <label class="col-lg-4 control-label" for="focusedInput">Año de fundación</label>
                                                                                <div class="col-lg-5 ">
                                                                                    <asp:TextBox ID="txtAnio" runat="server" class="form-control" ></asp:TextBox>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />

                                                                            <div class="form-group" style="color: saddlebrown; font-size: x-large;">
                                                                                <label class="col-lg-4 control-label" for="focusedInput">Se encuentra activa?</label>
                                                                                <div class="col-lg-1 ">
                                                                                    <asp:DropDownList ID="ddlActiva" runat="server" CssClass="form-control">
                                                                                        <asp:ListItem Value="true">Si</asp:ListItem>
                                                                                        <asp:ListItem Value="false">No</asp:ListItem>
                                                                                    </asp:DropDownList>
                                                                                </div>
                                                                            </div>
                                                                            <br />
                                                                            <br />
                                                                        </asp:TableCell>
                                                                    </asp:TableRow>

                                                                </asp:Table>
                                                                <div >
                                                                    <asp:Button ID="idGuardar" Width="25%" Text="Guardar" class="btn btn-circle-2" BackColor="SaddleBrown" ForeColor="White" OnClick="idGuardar_Click" CausesValidation="false" runat="server" />&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="btnCancelar" runat="server"  Width="25%" Text="Cancelar" class="btn btn-circle-2" BackColor="Red" ForeColor="White" OnClick="btnCancelar_Click" CausesValidation="false" />
                                                                    
                                                                </div>

                                                                <br />
                                                            </div>

                                                       
                                               
                                        </div>
                                         </section>
                                        </ContentTemplate>

            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="idGuardar" EventName="" />
            </Triggers>
        </asp:UpdatePanel>
                                   

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
