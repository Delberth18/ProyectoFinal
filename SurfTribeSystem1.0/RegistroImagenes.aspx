<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistroImagenes.aspx.cs" Inherits="SurfTribeSystem1._0.RegistroImagenes" %>

<%@ MasterType VirtualPath="~/Site1.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- PAGE TITLE -->
    <section class="pageTitle" style="background-image: url(ccss/star-1-3/Static%20HTML/img/pages/page-title-bg7.jpg);">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="titleTable">
                        <div class="titleTableInner">
                            <div class="pageTitleInfo">
                                <br />
                                <br />
                                <br />
                                <h1>Registro de imagenes</h1>
                                <div class="under-border"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>


    <section class="mainContentSection packagesSection" style="background-color: white">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">

                    <h4>
                        <asp:Label runat="server" ID="info1" Text="En este apartado puede realizar la insersion de imagenes para el sistema"></asp:Label></h4>

                </div>
            </div>

            <div>
                <label>Descripción:</label>

                <asp:TextBox ID="txtDescripcion" runat="server" Width="200px" class="form-control  bg-ashh"></asp:TextBox>

                <label>Imagen:</label>

                <asp:FileUpload ID="FileUpload" runat="server" class="form-control  bg-ashh" />

                <br />
                <asp:Button ID="btnGuardar" class="btn btn-default" BackColor="darkorange" ForeColor="White" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Width="150px" />

            </div>

            <br />



            <div class="col-sm-9 col-xs-12" style="width: 100%">
                <div class="row">



                    <asp:Repeater ID="imagenesList" runat="server">
                        <ItemTemplate>
                            <div class="item col-md-4">
                                <div class="thumbnail deals packagesPage isotopeSelector">
                                    <img src='data:image/jpg;base64,<%# Eval("Imgs") %>' alt="deal-image" />


                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
            </div>
        </div>
    </section>





</asp:Content>
