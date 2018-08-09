<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="mantReservas.aspx.cs" Inherits="SurfTribeSystem1._0.mantReservas" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!--principal-->
    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">

        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <br />
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="Label1" Font-Size="xX-Large" Text="Mantenimiento de reservas"></asp:Label></h2>

                    </div>
                    <h4>
                        <asp:Label runat="server" ID="info1" Text="Reservas faltantes de revisión"></asp:Label></h4>
                </div>
            </div>

            <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">
                <div class="row" style="margin: 4px 4px 4px 4px;">

                    <div class="col-sm-6 col-xs-12 accordionsTransparent" style="width: 100%">

                        <div class="review-aria">

                            <div class="reviewContent" style="margin: 8px 8px 8px 8px;">
                                
                                <asp:ListView runat="server" ID="reservasLst">
                                    <ItemTemplate>

                                        <div class="reviewMedia">
                                            <ul class="media-list">
                                                <li class="media">
                                                    <div class="media-body">
                                                       <div class="row" style="border:solid;border-color:white">
                                                            <div class=" col-sm-3">
                                                                <ul>
                                                                    <li>
                                                                        <label style="color: SaddleBrown; font-size: x-large">FECHA:</label>
                                                                        <br />
                                                                        <asp:Label ID="txtFecha" Text='<%# Eval("Fecha") %>' runat="server" Style="color:black;font-weight:bold"></asp:Label>
                                                                    </li>
                                                                    <li>
                                                                        <br />
                                                                    </li>

                                                                </ul>

                                                            </div>

                                                            <div class="col-sm-3">
                                                                <ul>
                                                                    <li>
                                                                        <label style="color: SaddleBrown; font-size: x-large">INSTRUCTOR:</label>
                                                                        <br />
                                                                        <asp:Label ID="txtInstructor" Text='<%# Eval("NombreIns") %>' runat="server" Style="color:black;font-weight:bold"></asp:Label>
                                                                    </li>
                                                                    <li>
                                                                        <br />
                                                                    </li>
                                                                </ul>
                                                            </div>

                                                            <div class="col-sm-3">
                                                                <ul>
                                                                    <li>
                                                                        <label style="color: SaddleBrown; font-size: x-large">PRECIO:</label>
                                                                        <br />
                                                                        <asp:Label ID="txtprecio" Text='<%# Eval("Precio") %>' runat="server" Style="color:black;font-weight:bold"></asp:Label>
                                                                    </li>
                                                                    <li>
                                                                        <br />
                                                                    </li>

                                                                </ul>

                                                            </div>
                                                           <div class="col-sm-3">
                                                                <ul>
                                                                    <li>
                                                                        <label style="color: SaddleBrown; font-size: x-large">CLIENTE:</label>
                                                                        <br />
                                                                        <asp:Label ID="txtCliente" Text='<%# Eval("NombreUsu")%>' runat="server" Style="color:black;font-weight:bold"></asp:Label>
                                                                    </li>
                                                                    <li>
                                                                        <br />
                                                                    </li>

                                                                </ul>

                                                            </div>
                                                        </div>
                                                                                            <a aria-label="Editar" style="border: solid; border-color: #ff891e; border-radius: 8px; border-width: thin">
                                                            <asp:LinkButton ID="noConfirmarBtn" CommandName=<%# String.Format("{0}/{1}", Eval("IdSesion"), Eval("IdUsuario")) %> Text="Deshacer" runat="server" 
                                                              OnClick="noConfirmarBtn_Click"  aria-hidden="true" Style="margin: 2px 2px 2px 2px;color:darkred; font-weight:bold;font-size:medium" />
                                                        </a>
                                                        <a aria-label="Borrar" style="margin-left: 15px; border: solid; border-color: #ff891e; border-radius: 8px; border-width: thin">
                                                            <asp:LinkButton ID="confirmarBtn" CommandName=<%# String.Format("{0}/{1}", Eval("IdSesion"), Eval("IdUsuario")) %> Text="Confirmar" runat="server" 
                                                               OnClick="confirmarBtn_Click" aria-hidden="true" Style="margin: 2px 2px 2px 2px;color:forestgreen; font-weight:bold;font-size:medium" />
                                                        </a>
                                                        
                                                            

                                                    </div>

                                                </li>

                                            </ul>
                                        </div>
                                        <br />

                                    </ItemTemplate>
                                </asp:ListView>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

        </div>
    </section>


</asp:Content>