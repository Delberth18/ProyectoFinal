<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PreciosListado.aspx.cs" Inherits="SurfTribeSystem1._0.PreciosListado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!--principal-->
    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
       <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="tituloLabel" Text="Precios" BackColor="#f5f5f5"></asp:Label></h2>

                    </div>
                    <h4>
                        <asp:Label runat="server" ID="info1" Text="Les mostramos nuestros diferentes precios para las clases y alquiler de tablas"></asp:Label></h4>
                  
                </div>
            </div>



            <div class="col-sm-9 col-xs-12" style="width:100%">
                <div class="row">



                    <asp:ListView runat="server" ID="preguntasLst">
                        <ItemTemplate>
                            <div class="col-lg-4 col-sm-6 col-xs-12 " >
                                <div class="thumbnail deals packagesPage">
                                    <a  class="pageLink"></a>
                                  
                                    <div class="caption">
                                        <h4><a  class="captionTitle"><%# Eval("Tipo") %></a></h4>
                                        <p><%# Eval("Descripcion") %></p>
                                        <div class="detailsInfo">
                                            <h5>
                                                <span>Por persona</span>
                                                <%# Eval("PrecioD") %> colones - imp incluidos
                                            </h5>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>



                </div>
            </div>
        </div>
    </section>


</asp:Content>



