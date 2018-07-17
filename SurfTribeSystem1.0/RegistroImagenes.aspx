<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="RegistroImagenes.aspx.cs" Inherits="SurfTribeSystem1._0.RegistroImagenes" %>

<%@ MasterType VirtualPath="~/Site2.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <br />
        <div class="row">
            <div class="col-xs-12">
                <div class="sectionTitle">
                    <h2>
                        <asp:Label runat="server" ID="tituloLabel" Text="Registro de Imágenes" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                </div>

            </div>
        </div>
        <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">

            <div>
                <div class="col-xs-12 col-sm-4">
                    <ul>
                        <li>
                            <label style="color: saddlebrown; font-size: x-large">Título:</label>

                            <asp:TextBox ID="txtTitulo" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                        </li>
                        <li>
                            <label style="color: saddlebrown; font-size: x-large">Leyenda:</label>

                            <asp:TextBox ID="txtLeyenda" runat="server" class="form-control  bg-ashh" TextMode="MultiLine"></asp:TextBox>
                        </li>
                    </ul>

                </div>
                <div class="col-xs-12 col-sm-4">
                    <ul>
                        <li>
                            <label style="color: saddlebrown; font-size: x-large">Pertenecia:</label>
                        </li>
                        <li>
                            <asp:UpdatePanel runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="pertenece" runat="server" CssClass="bg-ashh" Width="100%" OnSelectedIndexChanged="pertenece_Click" AutoPostBack="true" DataTextField="" DataValueField="">
                                    </asp:DropDownList>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="pertenece" EventName="" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </li>
                        <li>
                            <label style="color: saddlebrown; font-size: x-large">Dueño:</label>
                        </li>
                        <li>
                            <asp:UpdatePanel runat="server">
                                <ContentTemplate>
                                    <asp:DropDownList ID="duenos" runat="server" CssClass="bg-ashh" Width="100%">
                                    </asp:DropDownList>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="duenos" EventName="" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </li>
                    </ul>
                </div>
                <div class="col-xs-12 col-sm-4">
                    <ul>
                        <li>
                            <label style="color: saddlebrown; font-size: x-large">Imagen:</label>

                            <asp:FileUpload ID="FileUpload" runat="server" class="form-control  bg-ashh" />
                        </li>
                        <li>
                            <br />
                            <asp:UpdatePanel runat="server">
                                <ContentTemplate>
                                    <asp:Button ID="btnGuardar" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Width="150px" />

                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnGuardar" EventName="Click" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </li>
                    </ul>

                </div>
            </div>




            <div class="col-sm-9 col-xs-12" style="width: 100%">
                <div class="row">
                    <br />


                    <asp:Repeater ID="imagenesList" runat="server">
                        <ItemTemplate>
                            <div class="col-md-4">
                                <div class="thumbnail deals packagesPage isotopeSelector" style="height: 250px; background: none">
                                    <img src='data:image/jpg;base64,<%# Eval("Imgs") %>' alt="deal-image" />


                                    <h4><%# Eval("Pertenece") %></h4>

                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
            </div>
        </div>
    </section>





</asp:Content>
