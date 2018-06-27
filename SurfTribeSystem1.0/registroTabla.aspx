<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="registroTabla.aspx.cs" Inherits="SurfTribeSystem1._0.registroTabla" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- PAGE TITLE -->
    <section class="pageTitle" style="background-image: url(Imagenes/IMG-20170915-WA0002-01.jpeg); margin-top: 96px;">
        <div class="container">
            <div class="row">
                <div class="col-xs-12">
                    <div class="titleTable">
                        <div class="titleTableInner">
                            <div class="pageTitleInfo">
                                <br />
                                <br />
                                <br />
                                <h1>Registro de Tablas</h1>
                                <div class="under-border"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>


    <section class="mainContentSection packagesSection" style="background-color: white">
        <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">
            <div class="row">
                <div class="col-xs-12">

                    <h4>
                        <asp:Label runat="server" ID="info1" Text="En este apartado puede realizar el ingreso de las tablas de surf para las diferentes escuelas"></asp:Label></h4>

                </div>
            </div>

            <div>
                <div class="col-xs-12 col-sm-4">
                    <ul>
                        <li>
                            <label style="color: darkorange; font-size: x-large">Marca:</label>

                            <asp:TextBox ID="txtMarca" runat="server" class="form-control  bg-ashh" ></asp:TextBox>
                        </li>
                        <li>
                            <label style="color: darkorange; font-size: x-large">Tipo:</label>

                            <asp:TextBox ID="txtTipo" runat="server" class="form-control  bg-ashh" ></asp:TextBox>
                        </li>
                        <li>
                            <label style="color: darkorange; font-size: x-large">Tamaño:</label>
                             <div class="row">
                    <div class="col-xs-12 col-sm-4">
                    <ul>
                        <li>
                            <asp:TextBox ID="txtPies" Text="1" ToolTip="Ingrese el número de pies"  runat="server" class="form-control  bg-ashh " TextMode="Number" min="4" max="47"></asp:TextBox>
                            </li></ul></div>
                    <div class="col-xs-12 col-sm-4">
                    <ul>
                        <li>
                            <asp:TextBox ID="txtPulgadas" Text="1" ToolTip="Ingrese el número de pulgadas" runat="server" class="form-control  bg-ashh" TextMode="Number" min="1" max="11" ></asp:TextBox>
                            </li>
                        </ul>
                    </div>
                                 </div>
                        </li>
                    </ul>

                </div>
                <div class="col-xs-12 col-sm-4">
                    <ul>
                        <li>
                            <label style="color: darkorange; font-size: x-large">Estado:</label>
                        </li>
                        <li>
                            <asp:DropDownList ID="estado" runat="server" CssClass="bg-ashh" Width="100%">

                            </asp:DropDownList>
                        </li>
                        <li>
                            <label style="color: darkorange; font-size: x-large">Escuela:</label>
                        </li>
                        <li>
                            <asp:DropDownList ID="escuela" runat="server" CssClass="bg-ashh" Width="100%">

                            </asp:DropDownList>
                        </li>
                        
                    </ul>
                </div>
                <div class="col-xs-12 col-sm-4">
                    <ul>
                         <li>
                            <label style="color: darkorange; font-size: x-large">Dificultad:</label>
                        </li>
                        <li>
                            <asp:DropDownList ID="dificultad" runat="server" CssClass="bg-ashh" Width="100%">
                                <asp:ListItem Value="PRINCIPIANTE">PRINCIPIANTE</asp:ListItem>
                                <asp:ListItem Value="INTERMEDIO">INTERMEDIO</asp:ListItem>
                                <asp:ListItem Value="AVANZADO">AVANZADO</asp:ListItem>
                            </asp:DropDownList>
                        </li>
                        <li>
                            <label style="color: darkorange; font-size: x-large">Imagen:</label>

                            <asp:FileUpload ID="FileUpload" runat="server" class="form-control  bg-ashh" Text="aaa"/>
                        </li>
                        <li>
                            <br />
                            <asp:Button ID="btnGuardar" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Width="150px" />
                        </li>
                    </ul>

                </div>
            </div>




            <div class="col-sm-9 col-xs-12" style="width: 100%" >
                <div class="row">
                    <br />


                    <asp:Repeater ID="imagenesList" runat="server" >
                        <ItemTemplate>
                            <div class="item col-md-3" >
                                <div class="thumbnail deals packagesPage isotopeSelector">
                                    <img src='data:image/jpg;base64,<%# Eval("Imagen") %>' alt="deal-image"/>
                                    
                    
                                    <h4><%# Eval("Marca") %></h4>
                                    <h5>Escuela: <%# Eval("NombreEscuela") %></h5>
                                        
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
            </div>
        </div>
    </section>





</asp:Content>

