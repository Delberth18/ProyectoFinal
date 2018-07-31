<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reporteTabla.aspx.cs" Inherits="SurfTribeSystem1._0.reporteTabla" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <br />
        <div class="row">
            <div class="col-xs-12">
                <div class="sectionTitle">
                    <h2>
                        <asp:Label runat="server" ID="tituloLabel" Text="Reporte de tablas de Surf" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

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
                                    <label style="color: saddlebrown; font-size: x-large">Marca:</label>
                                </li>
                                <li>
                                    <asp:DropDownList ID="marcaLst" runat="server" CssClass="bg-ashh" Width="100%" AutoPostBack="true" DataTextField=""
                                        DataValueField="" OnSelectedIndexChanged="reporteTablaSurf">
                                    </asp:DropDownList>


                                </li>
                            </ul>

                        </div>
                        <div class="col-xs-12 col-sm-3">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Tipo:</label>
                                </li>
                                <li>
                                    <asp:DropDownList ID="tipoLst" runat="server" CssClass="bg-ashh" Width="100%" AutoPostBack="true" DataTextField=""
                                        DataValueField="" OnSelectedIndexChanged="reporteTablaSurf">
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
                                        DataValueField="" OnSelectedIndexChanged="reporteTablaSurf">
                                    </asp:DropDownList>

                                </li>
                            </ul>

                        </div>
                        <div class="col-xs-12 col-sm-3">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Dificultad:</label>
                                </li>
                                <li>

                                    <asp:DropDownList ID="dificultadLst" runat="server" CssClass="bg-ashh" Width="100%" AutoPostBack="true" DataTextField=""
                                        DataValueField="" OnSelectedIndexChanged="reporteTablaSurf">
                                    </asp:DropDownList>

                                </li>

                            </ul>

                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 col-sm-6">
                            <ul>
                                <li>
                                    <br />
                                    <asp:Button ID="btnRefrescar" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White"
                                        runat="server" Text="Refrescar" Width="150px" OnClick="reporteTablaSurf" />


                                </li>
                            </ul>
                        </div>
                        <div class="col-xs-12 col-sm-6">
                            <ul>
                                <li>
                                    <br />

                                    <asp:Button ID="btnGenerar" class="btn btn-default btn-circle-2 " BackColor="SaddleBrown" ForeColor="White"
                                        runat="server" Text="Generar Reporte" Width="200px" OnClick="btnOmitir_Click" />

                                </li>
                            </ul>
                        </div>

                    </div>




                    <div class="col-sm-9 col-xs-12" style="width: 100%">
                        <div class="row">
                            <br />


                            <asp:Repeater ID="imagenesList" runat="server">
                                <ItemTemplate>
                                    <div class="col-md-3">
                                        <div class="thumbnail deals packagesPage isotopeSelector" style="background: none">
                                            <img src='data:image/jpg;base64,<%# Eval("Imagen") %>' alt="deal-image" />
                                        </div>
                                    </div>
                                    <div class="col-md-3">
                                        <ul>
                                            <li style="color: black; font-weight: bold; font-size: large">Marca: <%# Eval("Marca") %>
                                            </li>
                                            <li style="color: black; font-weight: bold; font-size: large">Tamaño: <%# Eval("Tamanio") %>
                                            </li>
                                            <li style="color: black; font-weight: bold; font-size: large">Tipo: <%# Eval("Tipo") %>
                                            </li>
                                            <li style="color: black; font-weight: bold; font-size: large">Dificultad: <%# Eval("Dificultad") %>
                                            </li>
                                            <li style="color: black; font-weight: bold; font-size: large">Estado: <%# Eval("Estado") %>
                                            </li>
                                            <li style="color: black; font-weight: bold; font-size: large">Costo: <%# Eval("Costo") %> colones
                                            </li>
                                        </ul>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="tipoLst" EventName="" />
                    <asp:AsyncPostBackTrigger ControlID="dificultadLst" EventName="" />
                    <asp:AsyncPostBackTrigger ControlID="estadoLst" EventName="" />
                    <asp:AsyncPostBackTrigger ControlID="marcaLst" EventName="" />
                    <asp:AsyncPostBackTrigger ControlID="btnGenerar" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="btnRefrescar" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>


        </div>
    </section>
</asp:Content>
