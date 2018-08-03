<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="mantEscuelas.aspx.cs" Inherits="SurfTribeSystem1._0.mantEscuelas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <br />
          <div class="row">
                <div class="col-xs-12">
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="tituloLabel" Text="mantenimiento de escuelas" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                    </div>
                    
                </div>
            </div>
                                <br />
                <div class="container">
                        <div class="col-xs-12">
                                
                                <div style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; margin-top: 3%">
                                    <div class="tab-content">
                                        <div id="Lugar" class="tab-pane fade in active">
                                            <section class="recentActivitySection">
                                                <div class="container">
                                                    <div class="de">
                                                        <div class="col-xs-12 ">

                                                            <div class="row" style="margin: 5px 9px 5px 9px">
                                                                <div class="col-sm-12">
                                                                    <ul>
                                                                        <li>
                                                                            <br />
                                                                            <center>
                                                                            <asp:DropDownList ID="ddlEscuelas" AutoPostBack="True" runat="server" OnSelectedIndexChanged="Seleccionar" 
                                                                                CssClass="bg-ashh" Style="width: 30%"  ForeColor="Black" style="font-size:large">
                                                                            </asp:DropDownList>
                                                                            <br />
                                                                             </center>
                                                                            <br />
                                                                            <div class="col-sm-3">
                                                                                <a aria-label="NuevaPreguntado" href="registroEscuela.aspx">
                                                                                    <span aria-hidden="true" style="margin: 2px 2px 2px 2px;color:saddlebrown; font-size: x-large;"><b>Nueva Escuela>></b></span>
                                                                                </a>
                                                                            </div>
                                                                            <br />
                                                                        </li>
                                                                    </ul>
                                                                </div>



                                                                <div class="col-sm-12">
                                                                    <ul>
                                                                        <li>
                                                                            <asp:GridView ID="grvEstado" Width="100%" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" BackColor="White" BorderColor="#CCCCCC"
                                                                                BorderStyle="None" CellPadding="3" CssClass="gv1"
                                                                                SelectedIndex="0"
                                                                                OnSelectedIndexChanged="grvEstado_SelectedIndexChanged"
                                                                                OnRowDataBound="grvEstado_RowDataBound">
                                                                                <Columns>

                                                                                    <asp:BoundField DataField="NOMBRE" HeaderText="Nombre"></asp:BoundField>
                                                                                    <asp:BoundField DataField="UBICACION" HeaderText="Ubicación"></asp:BoundField>
                                                                                    <asp:BoundField DataField="TELEFONO" HeaderText="Telefono1"></asp:BoundField>
                                                                                    <asp:BoundField DataField="TELEFONO2" HeaderText="Telefono2"></asp:BoundField>
                                                                                    <asp:BoundField DataField="ANIO_FUNDACION" HeaderText="Fundada"></asp:BoundField>
                                                                                    <asp:BoundField DataField="PLAYA_CONCURRIDA" HeaderText="Playa"></asp:BoundField>
                                                                                    <asp:BoundField DataField="CORREO" HeaderText="Correo"></asp:BoundField>
                                                                                    <asp:BoundField DataField="ZONA" HeaderText="Zona"></asp:BoundField>
                                                                                    <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripcion" ItemStyle-Width="30%"></asp:BoundField>
                                                                                </Columns>


                                                                                <FooterStyle BackColor="White" ForeColor="#000066"></FooterStyle>

                                                                                <HeaderStyle BackColor="DarkOrange" Font-Bold="True" ForeColor="White" CssClass="celdas-titulos"></HeaderStyle>
                                                                                <PagerStyle HorizontalAlign="Left" BackColor="White" ForeColor="#000066"></PagerStyle>

                                                                                <RowStyle ForeColor="#669999"></RowStyle>

                                                                                <SelectedRowStyle BackColor="#262a2e" Font-Bold="True" ForeColor="White"></SelectedRowStyle>

                                                                                <SortedAscendingCellStyle BackColor="#F1F1F1"></SortedAscendingCellStyle>

                                                                                <SortedAscendingHeaderStyle BackColor="#007DBB"></SortedAscendingHeaderStyle>

                                                                                <SortedDescendingCellStyle BackColor="#CAC9C9"></SortedDescendingCellStyle>

                                                                                <SortedDescendingHeaderStyle BackColor="#00547E"></SortedDescendingHeaderStyle>
                                                                            </asp:GridView>
                                                                        </li>
                                                                        <li>
                                                                            <br />
                                                                            <asp:Button ID="idEditar" Text="Editar Escuela" class="btn btn-default btn-circle-2 " Width="35%" BackColor="DarkOrange" ForeColor="White" runat="server" OnClick="idEditar_Click" Visible="false" />
                                                                        </li>
                                                                    </ul>

                                                                </div>
                                                            </div>

                                                        </div>
                                                    </div>
                                                </div>
                                            </section>
                                        </div>
                                    
                                </div>
                            </div>
                        
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="grvEstado" EventName="" />
                <asp:AsyncPostBackTrigger ControlID="ddlEscuelas" EventName="SelectedIndexChanged" />
            </Triggers>
        </asp:UpdatePanel>
    </section>

</asp:Content>
