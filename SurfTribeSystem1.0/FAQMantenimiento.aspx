<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FAQMantenimiento.aspx.cs" Inherits="SurfTribeSystem1._0.FAQMantenimiento" %>

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
                                <h1>Preguntas frecuentes</h1>
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
            <div class="row">
                <div class="col-xs-12">
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="tituloLabel" Text="Mantenimiento" style="background-color:#f5f5f5;"></asp:Label></h2>

                    </div>
                    <h4>
                        <asp:Label runat="server" ID="info1" Text="Todos nos han hecho llegar sus dudas, aquí les mostramos las más comunes"></asp:Label></h4>
                    <p>
                        <asp:Label runat="server" ID="info2" Text="Esperamos haber aclarado estas dudas. Si tienen alguna otra no la pueden hacer llegar por medio de la página de consultas, al correo o cuando nos visiten."></asp:Label>
                    </p>
                </div>
            </div>

            <div class="row" style="margin: 4px 4px 4px 4px; border: solid 1px #000000; border-top-left-radius: 27px; border-top-right-radius: 27px; border-bottom-left-radius: 27px; border-bottom-right-radius: 28px;">

                <div class="col-sm-6 col-xs-12 accordionsTransparent" style="width: 100%">
                    <div class="solidBgTitle">
                        <div class="panel-group" id="accordionSolid">

                            <asp:ListView runat="server" ID="preguntasLst">
                                <ItemTemplate>

                                    <div class="panel panel-default" style="margin: 10px 10px 10px 10px">
                                        <a class="panel-heading accordion-toggle" data-toggle="collapse"
                                            data-parent="#accordionSolid" href='<%# "#"+ Eval("Pregunta").ToString().Replace(' ','_') %>'>

                                            <span>¿<asp:Label runat="server" ID="preguntaLabel" Text='<%# Eval("Pregunta") %>'></asp:Label>?</span>

                                            <i class="indicator fa fa-plus  pull-right"></i>

                                        </a>
                                        <div id='<%# Eval("Pregunta").ToString().Replace(' ','_') %>' class="panel-collapse collapse">
                                            <div class="panel-body">
                                                <div class="media" style="overflow-wrap: break-word">

                                                    <p><%# Eval("Respuesta").ToString() %></p>
                                                    <!--No puedo hacer que se vean varias lineas-->
                                                    <a  aria-label="Editar" >
                                                        <span aria-hidden="true">Editar</span>
                                                    </a>
                                                    <a  aria-label="Borrar" style="margin-left:15px">
                                                        <span aria-hidden="true">Borrar</span>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>


                                </ItemTemplate>
                            </asp:ListView>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>


</asp:Content>

