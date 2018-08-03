<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="mantTablas.aspx.cs" Inherits="SurfTribeSystem1._0.mantTablas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                 <br />
          <div class="row">
                <div class="col-xs-12">
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="tituloLabel" Text="mantenimiento de tablas de surf" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                    </div>
                    
                </div>
            </div>
                <br />
                <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">

                    <div class="col-sm-9 col-xs-12" style="width: 100%">
                        <div class="row">
                            <div class="col-xs-12 ">

                                <div class="row" style="margin: 5px 9px 5px 9px">
                                    <div class="col-sm-12">
                                        <ul>
                                            <li>
                                                <br />
                                                <center>
                                        
                                            <div class="col-sm-3">
                                                <a aria-label="NuevaPreguntado" href="registroTabla.aspx" >
                                                    <span aria-hidden="true" style="margin: 2px 2px 2px 2px; font-size:x-large; color:saddlebrown"><b>Nueva tabla>></b></span>
                                                </a>
                                            </div>
                                        </center>
                                                <br />
                                                <br />
                                            </li>
                                        </ul>
                                    </div>
                                </div>



                                <asp:Repeater ID="imagenesList" runat="server" Visible="false" OnItemDataBound="imagenesList_ItemDataBound">
                                    <ItemTemplate>
                                        <div class="item col-md-3">
                                            <ul>
                                                <li>
                                                    <div class="thumbnail deals packagesPage isotopeSelector">
                                                        <img src='data:image/jpg;base64,<%# Eval("Imagen") %>' alt="deal-image" />


                                                        <h4><%# Eval("Marca") %></h4>
                                                        <h3>Estado:
                                                            <asp:Label runat="server" ID="est"><%# Eval("Estado") %></asp:Label></h3>
                                                        <asp:Label runat="server" ID="idTable" Text='<%# Eval("Id") %>' Visible="false"></asp:Label>
                                                    </div>
                                                </li>
                                                <li>
                                                    <div class="panel-group">
                                                        <div class="panel panel-default">
                                                            <div class="panel-heading">
                                                                <h4 class="panel-title">
                                                                    <a data-toggle="collapse" href="#collapse1">Cambiar Estado</a>
                                                                </h4>
                                                            </div>
                                                            <div id="collapse1" class="panel-collapse collapse">
                                                                <div class="panel-body">
                                                                    <asp:DropDownList ID="estadoList" runat="server" OnSelectedIndexChanged="estadoList_SelectedIndexChanged"
                                                                        AutoPostBack="True" CssClass="bg-ashh" Width="100%"  ForeColor="Black" style="font-size:large">
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </li>
                                            </ul>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>

                            </div>
                        </div>
                    </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="imagenesList" />
            </Triggers>
        </asp:UpdatePanel>
    </section>

</asp:Content>
