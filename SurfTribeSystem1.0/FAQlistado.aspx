<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FAQlistado.aspx.cs" Inherits="SurfTribeSystem1._0.FAQlistado" %>

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
                            <asp:Label runat="server" ID="tituloLabel" Font-Size="xX-Large" Text="Preguntas frecuentes"></asp:Label></h2>

                    </div>
                    <h4>
                        <asp:Label runat="server" ID="info1" Text="Todos nos han hecho llegar sus dudas, aquí les mostramos las más comunes"></asp:Label></h4>
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
