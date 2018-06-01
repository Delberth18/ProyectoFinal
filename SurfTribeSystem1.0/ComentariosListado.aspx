<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ComentariosListado.aspx.cs" Inherits="SurfTribeSystem1._0.ComentariosListado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- PAGE TITLE -->
    <section class="pageTitle" style="background-image: url(ccss/star-1-3/Static%20HTML/img/pages/page-title-bg6.jpg);">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="titleTable">
                        <div class="titleTableInner">
                            <div class="pageTitleInfo">
                                <h1>Comentarios</h1>
                                <div class="under-border"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- PAGE CONTENT -->

    <!--principal-->
    <section class="mainContentSection" style="background-color:#f5f5f5;">
        <div class="container">
            
            <div class="row" style="margin: 4px 4px 4px 4px; border: solid 1px #000000; border-top-left-radius: 27px; border-top-right-radius: 27px; border-bottom-left-radius: 27px; border-bottom-right-radius: 28px;">

                <div class="col-sm-6 col-xs-12 accordionsTransparent" style="width: 100%">

                    <div class="review-aria">
                        <div class="sectionTitle2">
                            <h2>
                            <asp:Label runat="server" ID="Label1" Text="En este apartado se muestran todos las opiniones de nuestros diferentes usuarios"></asp:Label></h2>
                        </div>
                        <div class="reviewContent" style="margin: 8px 8px 8px 8px;">
                            <h3 class="reviewTitle" >Opiniones <asp:Label ForeColor="#333333" runat="server" ID="cantidadLabel" ></asp:Label>
                     <%--   <span>
                            <i class="fa fa-star" aria-hidden="true"></i>
                            <i class="fa fa-star" aria-hidden="true"></i>
                            <i class="fa fa-star" aria-hidden="true"></i>
                            <i class="fa fa-star" aria-hidden="true"></i>
                            <i class="fa fa-star-o" aria-hidden="true"></i>
                        </span>--%>
                            </h3>

                            <asp:ListView runat="server" ID="preguntasLst">
                                <ItemTemplate>

                                    <div class="reviewMedia">
                                        <ul class="media-list">
                                            <li class="media">
                                                <div class="media-body">
                                                    <h4 class="media-heading"><asp:Label runat="server" ID="preguntaLabel" Text='<%# Eval("Nombre") %>'></asp:Label></h4>
                                                   <%-- <span>
                                                        <i class="fa fa-star" aria-hidden="true"></i>
                                                        <i class="fa fa-star" aria-hidden="true"></i>
                                                        <i class="fa fa-star" aria-hidden="true"></i>
                                                        <i class="fa fa-star" aria-hidden="true"></i>
                                                        <i class="fa fa-star" aria-hidden="true"></i>
                                                    </span>--%>
                                                    <p><asp:Label ForeColor="#333333" runat="server" ID="Label2" Text='<%# Eval("Comentariol") %>'></asp:Label></p>
                                                </div>
                                            </li>

                                        </ul>
                                    </div>
                                    <br />

                                </ItemTemplate>
                            </asp:ListView>
                            
                            <h3 class="reviewTitle">Brindenos su opinión</h3>
                            <%--<p>
                                Want to Rate it? <span>
                                    <i class="fa fa-star" aria-hidden="true"></i>
                                    <i class="fa fa-star" aria-hidden="true"></i>
                                    <i class="fa fa-star-o" aria-hidden="true"></i>
                                    <i class="fa fa-star-o" aria-hidden="true"></i>
                                    <i class="fa fa-star-o" aria-hidden="true"></i>
                                </span>
                            </p>--%>
                            <div class="row">
                                <div class="col-xs-12">
                                    <div class="form-group">
                                        <asp:TextBox TextMode="MultiLine" runat="server" ID="comentarioText" Class="form-control" Rows="5"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <asp:Button OnClick="Unnamed_Click" class="btn btn-default" runat="server" Style="padding: 15px; background-color: darkorange; color: white; font-family: Arial; text-transform: none; font-size: large;" Text=" Guardar pregunta "></asp:Button>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        </div>

        </div>
        </div>
    </section>


</asp:Content>





