<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="registroPrecios.aspx.cs" Inherits="SurfTribeSystem1._0.registroPrecios" %>

<%@ MasterType VirtualPath="~/Site2.master" %>


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
                                <asp:Label runat="server" ID="tituloLabel" Text="mantenimiento de precios" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                        </div>

                    </div>
                </div>
                <br />
                <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 11px;">

                    <div class="row" style="background-color: rgba(108, 161, 121, 0.5); border: solid 0.40px #009510; border-radius: 8px; margin: 0.3%; padding: 0.3%;">
                        <div class="row" style="margin: 0.3%; padding: 0.3%;">
                            <div class="col-xs-12 col-sm-6">
                                <label style="color: SaddleBrown; font-size: x-large">Sesión para principiantes</label>
                            </div>
                            <div class="col-xs-12 col-sm-6">
                                <label style="color: SaddleBrown; font-size: x-large">Sesión para Intermedios</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-sm-2">
                                <ul>
                                    <li>
                                        <label style="color: SaddleBrown; font-size: large">Valor:</label>

                                        <asp:TextBox ID="txtCostoPrincipiante" TextMode="Number" min="0" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                    </li>
                                    <li>
                                        <br />
                                        <asp:Button ID="btnPrincipiante" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White" runat="server" 
                                            Text="Guardar" OnClick="GuardarPrincipiante" Width="80%" />
                                    </li>
                                </ul>
                            </div>
                            <div class="col-xs-12 col-sm-4">
                                <ul>
                                    <li>
                                        <label style="color: SaddleBrown; font-size: large">Breve descripción:</label>

                                        <asp:TextBox ID="txtDscPrincipiante" TextMode="MultiLine" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                    </li>
                                </ul>
                            </div>
                            <div class="col-xs-12 col-sm-2">
                                <ul>
                                    <li>
                                        <label style="color: SaddleBrown; font-size: large">Valor:</label>

                                        <asp:TextBox ID="txtCostoIntermedio" TextMode="Number" min="0" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                    </li>
                                    <li>
                                        <br />
                                        <asp:Button ID="btnIntermedio" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White" runat="server" 
                                            Text="Guardar" OnClick="GuardarIntermedio" Width="80%" />
                                    </li>
                                </ul>
                            </div>
                            <div class="col-xs-12 col-sm-4">
                                <ul>
                                    <li>
                                        <label style="color: SaddleBrown; font-size: large">Breve descripción:</label>

                                        <asp:TextBox ID="txtDscIntermedio" TextMode="MultiLine" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="row" style="background-color: rgba(108, 161, 121, 0.5); border: solid 0.40px #009510; border-radius: 8px; margin: 0.3%; padding: 0.3%; margin-top: 0.8%">
                        <div class="row" style="margin: 0.3%; padding: 0.3%;">
                            <div class="col-xs-12 col-sm-6">
                                <label style="color: SaddleBrown; font-size: x-large">Sesión para Avanzados</label>
                            </div>
                            <div class="col-xs-12 col-sm-6">
                                <label style="color: SaddleBrown; font-size: x-large">Alquiler ShortBoard</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-sm-2">
                                <ul>
                                    <li>
                                        <label style="color: SaddleBrown; font-size: large">Valor:</label>

                                        <asp:TextBox ID="txtCostoAvanzado" TextMode="Number" min="0" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                    </li>
                                    <li>
                                        <br />
                                        <asp:Button ID="btnAvanzado" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White" runat="server" 
                                            Text="Guardar" OnClick="GuardarAvanzado" Width="80%" />
                                    </li>
                                </ul>
                            </div>
                            <div class="col-xs-12 col-sm-4">
                                <ul>
                                    <li>
                                        <label style="color: SaddleBrown; font-size: large">Breve descripción:</label>

                                        <asp:TextBox ID="txtDscAvanzado" TextMode="MultiLine" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                    </li>
                                </ul>
                            </div>
                            <div class="col-xs-12 col-sm-2">
                                <ul>
                                    <li>
                                        <label style="color: SaddleBrown; font-size: large">Valor:</label>

                                        <asp:TextBox ID="txtCostoShortBoard" TextMode="Number" min="0" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                    </li>
                                    <li>
                                        <br />
                                        <asp:Button ID="btnShort" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White" runat="server"
                                            Text="Guardar" OnClick="GuardarShort" Width="80%" />
                                    </li>
                                </ul>
                            </div>
                            <div class="col-xs-12 col-sm-4">
                                <ul>
                                    <li>
                                        <label style="color: SaddleBrown; font-size: large">Breve descripción:</label>

                                        <asp:TextBox ID="txtDscShortBoard" TextMode="MultiLine" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="row" style="background-color: rgba(108, 161, 121, 0.5); border: solid 0.40px #009510; border-radius: 8px; margin: 0.3%; padding: 0.3%; margin-top: 0.8%">
                        <div class="row" style="margin: 0.3%; padding: 0.3%;">
                            <div class="col-xs-12 col-sm-6">
                                <label style="color: SaddleBrown; font-size: x-large">Alquiler LongBoard</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-sm-2">
                                <ul>
                                    <li>
                                        <label style="color: SaddleBrown; font-size: large">Valor:</label>

                                        <asp:TextBox ID="txtCostoLongBoard" TextMode="Number" min="0" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                    </li>
                                    <li>
                                        <br />
                                        <asp:Button ID="btnLong" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White" runat="server" 
                                            Text="Guardar" OnClick="GuardarLong" Width="80%" />
                                    </li>
                                </ul>
                            </div>
                            <div class="col-xs-12 col-sm-4">
                                <ul>
                                    <li>
                                        <label style="color: SaddleBrown; font-size: large">Breve descripción:</label>

                                        <asp:TextBox ID="txtDscLongBoard" TextMode="MultiLine" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                    </li>
                                </ul>
                            </div>
                            <div class="col-xs-11 col-sm-6">
                                <ul>
                                    <li>
                                        <center>
                                    <img src="ccss/star-1-3/Static%20HTML/img/logo-grande.png" width="50%" />
                                            </center>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnPrincipiante" EventName="" />
                <asp:AsyncPostBackTrigger ControlID="btnIntermedio" EventName="" />
                <asp:AsyncPostBackTrigger ControlID="btnAvanzado" EventName="" />
                <asp:AsyncPostBackTrigger ControlID="btnShort" EventName="" />
                <asp:AsyncPostBackTrigger ControlID="btnLong" EventName="" />
            </Triggers>
        </asp:UpdatePanel>
    </section>

</asp:Content>
