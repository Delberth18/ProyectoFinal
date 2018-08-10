<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="mantUsuarios.aspx.cs" Inherits="SurfTribeSystem1._0.mantUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <br />
          <div class="row">
                <div class="col-xs-12">
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="tituloLabel" Text="mantenimiento de usuarios" BackColor="#f5f5f5" Font-Size="XX-Large"></asp:Label></h2>

                    </div>
                    
                </div>
            </div>
                                <br />
                <div class="container">
                        <div class="col-xs-12">
                                
                                <div style="background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position: relative; z-index: 1; -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px; margin-top: 3%">
                                    <div class="tab-content">
                                        <div id="Lugar" class="tab-pane fade in active">

                                            <section class="recentActivitySection">
                                                <div class="container">
                                                    <div class="de">
                                                        <div class="col-xs-12 ">
                                                            <div class="recentActivityContent bg-ashs">

                                                                <div class="container">

                                                                    <div class="row">

                                                                        <center>
       <div class="form-group txtPequeño">
       
            <asp:TextBox ID="txtCed" runat="server" Style="width: 400px; margin-left:-50px"  class="form-control" min="0"  ToolTip="El valor debe ser mayor de 0" Text="" placeholder="Buscar Usuario"></asp:TextBox>
          
        </div>
            
  
     <asp:Button ID="idBuscar" Text="  Buscar  " class="btn "  style="margin-left:-50px" runat="server" OnClick="idBuscar_Click" BackColor="SaddleBrown" ForeColor="White" ></asp:Button>
       <br /><br />
   </center>
                                                                        <br />
                                                                        <div class="Alineado eti" style="margin-left: -40px; color: black;">
                                                                            <asp:Label ID="lblexito" runat="server" Text="" Font-Size="Medium" Font-Bold="true"></asp:Label>
                                                                        </div>
                                                                        <div style="margin-left: 130px;">
                                                                            <asp:GridView ID="grvEstado" runat="server"  OnRowCommand="grvEstado_RowCommand" AutoGenerateColumns="False" AutoGenerateSelectButton="True"  HorizontalAlign="Center" BackColor="White"  BorderColor="SaddleBrown" 
                                                                                BorderStyle="None" BorderWidth="1px" CellPadding="3"
                                                                                SelectedIndex="0"
                                                                                HeaderStyle-HorizontalAlign="Center" RowHeaderColumn="center" SortedAscendingHeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="40%">
                                                                                <Columns>


                                                                                    <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" HeaderStyle-Width="20%"></asp:BoundField>
                                                                                    <asp:BoundField DataField="APELLIDOS" HeaderText="Apellidos" ReadOnly="True" HeaderStyle-Width="40%"></asp:BoundField>
                                                                                    <asp:BoundField DataField="CORREO" HeaderText="Correo"></asp:BoundField>
                                                                                    
                                                                                    <asp:ButtonField Text="Editar" ButtonType="Button" CommandName="Editar">
                                                                                        <ControlStyle BackColor="#666666" ForeColor="White"></ControlStyle>
                                                                                    </asp:ButtonField>
                                                                                </Columns>


                                                                                <FooterStyle BackColor="White" ForeColor="#000066"></FooterStyle>

                                                                                <HeaderStyle BackColor="DarkOrange" Font-Bold="True" ForeColor="White"   HorizontalAlign="Center" ></HeaderStyle>
                                                                                <PagerStyle HorizontalAlign="Left" BackColor="White" ForeColor="#000066"></PagerStyle>

                                                                                <RowStyle ForeColor="SaddleBrown" Font-Bold="true" ></RowStyle>

                                                                                <SelectedRowStyle BackColor="#262a2e" Font-Bold="True" ForeColor="White"></SelectedRowStyle>

                                                                                <SortedAscendingCellStyle BackColor="#F1F1F1"></SortedAscendingCellStyle>

                                                                                <SortedAscendingHeaderStyle BackColor="#007DBB"></SortedAscendingHeaderStyle>

                                                                                <SortedDescendingCellStyle BackColor="#CAC9C9"></SortedDescendingCellStyle>

                                                                                <SortedDescendingHeaderStyle BackColor="#00547E"></SortedDescendingHeaderStyle>
                                                                            </asp:GridView>
                                                                           

                                                                        </div>

                                                                        <br />
                                                                        <br />
                                                                        <center>
         <asp:Label runat="server" class="col-lg-2 control-label" id="alert" style="color: #FF0000; font-family: 'Microsoft Sans Serif'; font-size: 17px; font-weight: bold"></asp:Label>
        <br />
                                                                    </div>

                                                                </div>

                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </section>

                                        </div>


                                    </div>
                                </div>

                            </div>
                        </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="grvEstado" EventName="" />
                <asp:AsyncPostBackTrigger ControlID="idBuscar" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
    </section>




</asp:Content>
