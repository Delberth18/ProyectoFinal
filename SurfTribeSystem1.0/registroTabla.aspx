<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="registroTabla.aspx.cs" Inherits="SurfTribeSystem1._0.registroTabla" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


  


    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
         <br />
          <div class="row">
                <div class="col-xs-12">
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="tituloLabel" Text="registro de tablas de surf" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                    </div>
                    
                </div>
            </div>
        <br/>
      <%--  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>--%>
                <div class="container" style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; padding: 12px;">
                    <div class="row">
                        <div class="col-xs-12">

                            <h4>
                                <asp:Label runat="server" ID="info1" Text="En este apartado puede realizar el ingreso de las tablas de surf de su escuela"></asp:Label></h4>

                        </div>
                    </div>

                    <div>
                        <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Marca:</label>

                                    <asp:TextBox ID="txtMarca" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                </li>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Tipo:</label>

                                    <asp:TextBox ID="txtTipo" runat="server" class="form-control  bg-ashh"></asp:TextBox>
                                </li>
                                
                            </ul>

                        </div>
                        <div class="col-xs-12 col-sm-4">
                            <ul>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Estado:</label>
                                </li>
                                <li>
                                    <asp:DropDownList ID="estado" runat="server" CssClass="bg-ashh" Width="100%">
                                    </asp:DropDownList>
                                </li>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Tamaño:</label>
                                    <div class="row">
                                        <div class="col-xs-12 col-sm-3">
                                            <ul>
                                                <li>
                                                    <asp:TextBox ID="txtPies" Text="4" ToolTip="Ingrese el número de pies" runat="server" class="form-control  bg-ashh " TextMode="Number" min="4" max="47"></asp:TextBox><p style="color:red">Pies</p>
                                                </li>
                                            </ul>
                                        </div>
                                        <div class="col-xs-12 col-sm-3">
                                            <ul>
                                                <li>
                                                    <asp:TextBox ID="txtPulgadas" Text="1" ToolTip="Ingrese el número de pulgadas" runat="server" class="form-control  bg-ashh" TextMode="Number" min="1" max="11"></asp:TextBox><p style="color:red">Pulgadas</p>
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
                                    <label style="color: saddlebrown; font-size: x-large">Dificultad:</label>
                                </li>
                                <li>
                                    <asp:DropDownList ID="dificultad" runat="server" CssClass="bg-ashh" Width="100%">
                                        <asp:ListItem Value="PRINCIPIANTE">PRINCIPIANTE</asp:ListItem>
                                        <asp:ListItem Value="INTERMEDIO">INTERMEDIO</asp:ListItem>
                                        <asp:ListItem Value="AVANZADO">AVANZADO</asp:ListItem>
                                    </asp:DropDownList>
                                </li>
                                <li>
                                    <label style="color: saddlebrown; font-size: x-large">Imagen:</label>
                                    <asp:FileUpload ID="FileUpload" runat="server" class="form-control  bg-ashh" ClientIDMode="Static" />
                                </li>
                                <li>
                                    <br />
                                    <asp:Button ID="btnGuardar" class="btn btn-default btn-circle-2 " BackColor="darkorange" ForeColor="White" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Width="150px" />
                                </li>
                            </ul>

                        </div>
                    </div>




                    <div class="col-sm-9 col-xs-12" style="width: 100%">
                        <div class="row">
                            <br />


                            <asp:Repeater ID="imagenesList" runat="server">
                                <ItemTemplate>
                                    <div class="item col-md-3">
                                        <div class="thumbnail deals packagesPage isotopeSelector">
                                            <img src='data:image/jpg;base64,<%# Eval("Imagen") %>' alt="deal-image" />


                                            <h4><%# Eval("Marca") %></h4>

                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                    </div>
                </div>
           <%-- </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnGuardar" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>--%>
    </section>





</asp:Content>

