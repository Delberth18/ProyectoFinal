<%@ Page Language="C#" MasterPageFile="~/Site4.Master" AutoEventWireup="true" CodeBehind="ususcribe.aspx.cs" Inherits="SurfTribeSystem1._0.ususcribe" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <br />
        <br />

        <div class="row" style="align-content: center; margin-left: 8%; margin-right: 8%">
            <div class=" col-xs-12 col-sm-12">
                <ul>
                    <li>
                        <h2 style="text-align: center">
                            <asp:Label runat="server" ID="tituloLabel" Text="Comentenos el motivo de su decisión de dejar nuestra página:" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>
                        <asp:TextBox ID="comentarioText" Text="Sin ninguna razón." runat="server" class="form-control  bg-ashh" TextMode="MultiLine" Style="font-size: large"
                            Height="50%" Rows="6"></asp:TextBox>
                    </li>
                    <li>
                        <br />
                        <asp:Button runat="server" Text="Desinscribirme" class="btn btn-default" BackColor="DarkOrange"
                            ForeColor="White" Style="padding: 8px;" OnClick="Unnamed_Click" />

                        <asp:Button runat="server" Text="Salir" class="btn btn-default" BackColor="SaddleBrown"
                            ForeColor="White" Style="padding: 8px;" OnClick="Unnamed_Click1" />
                    </li>
                </ul>

            </div>
        </div>
    </section>

</asp:Content>
