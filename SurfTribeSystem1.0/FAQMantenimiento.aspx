<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="FAQMantenimiento.aspx.cs" Inherits="SurfTribeSystem1._0.FAQMantenimiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!--principal-->
    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <br />
                            <div class="sectionTitle">
                                <h2>
                                    <asp:Label runat="server" ID="Label1" Font-Size="xX-Large" Text="Mantenimiento de preguntas frecuentes"></asp:Label></h2>

                            </div>
                        </div>
                    </div>
                    <div class="row">


                        <div class="col-xs-12">

                            <a aria-label="NuevaPreguntado" href="FAQRegistro.aspx">
                                <span aria-hidden="true" style="margin: 2px 2px 2px 2px; font-size: x-large; color: saddlebrown">Nueva pregunta>></span>
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
                                                                <asp:LinkButton ID="editarBtn" CommandName='<%# Eval("Pregunta") %>' Text="Editar" runat="server" aria-hidden="true" Style="margin: 2px 2px 2px 2px" OnClick="editarBtn_Click" />
                                                            </a>
                                                            <a aria-label="Borrar" style="margin-left: 15px; border: solid; border-color: #ff891e; border-radius: 8px; border-width: thin">
                                                                <asp:LinkButton ID="borrarBtn" CommandName='<%# Eval("Pregunta") %>' Text="Borrar" runat="server" aria-hidden="true" Style="margin: 2px 2px 2px 2px" OnClick="borrarBtn_Click" />
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
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="preguntasLst" EventName="" />
            </Triggers>
        </asp:UpdatePanel>
    </section>


</asp:Content>

