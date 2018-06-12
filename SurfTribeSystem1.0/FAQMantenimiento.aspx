<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FAQMantenimiento.aspx.cs" Inherits="SurfTribeSystem1._0.FAQMantenimiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- PAGE TITLE -->
    <section class="pageTitle" style="background-image: url(ccss/star-1-3/Static%20HTML/img/pages/page-title-bg6.jpg);">
        <div class="container" >
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
    <section class="mainContentSection">
        <div class="container  recentActivityContent bg-ash" style="border-radius: 7px">
            <div class="row">


                <div class="col-xs-12">

                    <div class="sectionTitle" style="margin-top: 8px;">
                        <h2>
                            <asp:Label runat="server" ID="tituloLabel" Text="Mantenimiento" Style="background-color: #f5f5f5"></asp:Label></h2>

                    </div>
                 
                    <a aria-label="NuevaPreguntado" href="FAQRegistro.aspx" style="border: solid; border-color: #ff891e; border-radius: 8px; border-width: thin">
                        <span aria-hidden="true" style="margin: 2px 2px 2px 2px">Nueva pregunta</span>
                    </a>
                </div>
            </div>

            <div class="row" style="margin: 4px 4px 4px 4px;">

                <div class="col-sm-6 col-xs-12 accordionsTransparent" style="width: 100%">
                    <div class="solidBgTitle">
                        <div class="panel-group" id="accordionSolid">

                            <asp:ListView runat="server" ID="preguntasLst">
                                <ItemTemplate>

                                    <div class="panel panel-default" style="margin: 10px 10px 10px 10px">
                                        <a class="panel-heading accordion-toggle" data-toggle="collapse"
                                            data-parent="#accordionSolid" href='<%# "#"+ Eval("Pregunta").ToString().Replace(' ','_') %>'>

                                            <span>¿<asp:Label ID="preguntaLabel" Text='<%# Eval("Pregunta") %>' runat="server"></asp:Label>?</span>

                                            <i class="indicator fa fa-plus  pull-right"></i>

                                        </a>
                                        <div id='<%# Eval("Pregunta").ToString().Replace(' ','_') %>' class="panel-collapse collapse">
                                            <div class="panel-body">
                                                <div class="media" style="overflow-wrap: break-word">

                                                    <p><%# Eval("Respuesta").ToString() %></p>
                                                    <a aria-label="Editar" style="border: solid; border-color: #ff891e; border-radius: 8px; border-width: thin">
                                                        <asp:LinkButton id="editarBtn" CommandName='<%# Eval("Pregunta") %>' Text="Editar" runat="server"  aria-hidden="true" style="margin: 2px 2px 2px 2px" OnClick="editarBtn_Click"/>
                                                    </a>
                                                    <a aria-label="Borrar" style="margin-left: 15px; border: solid; border-color: #ff891e; border-radius: 8px; border-width: thin">
                                                        <asp:LinkButton ID="borrarBtn" CommandName='<%# Eval("Pregunta") %>' Text="Borrar" runat="server"  aria-hidden="true" style="margin: 2px 2px 2px 2px" OnClick="borrarBtn_Click"/>
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

