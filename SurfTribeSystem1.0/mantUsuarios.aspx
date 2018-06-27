<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="mantUsuarios.aspx.cs" Inherits="SurfTribeSystem1._0.mantUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
     <section class="bookingTypeSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat:no-repeat; background-size:cover">
          <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
  <div class="container" >
    <div class="row">
      <div class="col-xs-12">
        <div class="bookingType bg-ashs"><br /><br /><br />



            <div style=" background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position:relative; z-index:1;
          -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px;">

            <div class="tab-content" >
            <div id="Lugar" class="tab-pane fade in active">

                <section class="recentActivitySection">
  <div class="container">
		<div class="de">
			<div class="col-xs-12 ">
        <div class="recentActivityContent bg-ashs">
            
            <div class="container">
               
                <div class="row">

               
                      
   
                    <center class="titulo" style="    width: 1100px;
    background: darkorange;
    margin-left: -10px;">
                            
                        <center><font size="7"><b style="    background-color: darkorange; color: black; border-radius: 484px;  margin-left: 37px;  opacity: 0.8;" FACE="arial">Mantenimiento Usuarios</b></font></center>
                      </center>
    <br /><br /> 
    
   <center>
       <div class="form-group txtPequeño">
       
            <asp:TextBox ID="txtCed" runat="server" Style="width: 400px; margin-left:-50px"  class="form-control" min="0"  ToolTip="El valor debe ser mayor de 0" Text="" placeholder="Buscar Usuario"></asp:TextBox>
          
        </div>
            
  
     <asp:Button ID="idBuscar" Text="  Buscar  " class="btn btn-primary"  style="margin-left:-50px" runat="server" OnClick="idBuscar_Click"  ></asp:Button>
       <br /><br />
   </center>
    <br />  <div class="Alineado eti"  style="margin-left: -40px; color: black;"> <asp:Label ID="lblexito" runat="server" Text=""  Font-Size="Medium" Font-Bold="true"></asp:Label></div>
                    <div style="margin-left: 260px;">
    <asp:GridView  ID="grvEstado" runat="server"  AutoGenerateColumns="False" HorizontalAlign="Center" BackColor="White" BorderColor="#CCCCCC" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" 
         SelectedIndex="0"
        onselectedindexchanged="grvEstado_SelectedIndexChanged" 
        OnRowDataBound="grvEstado_RowDataBound" >
        <Columns>


            <asp:BoundField DataField="NOMBRE" HeaderText="Nombre" HeaderStyle-Width="20%"></asp:BoundField>
            <asp:BoundField DataField="APELLIDOS" HeaderText="Apellidos" ReadOnly="True" HeaderStyle-Width="40%"></asp:BoundField>
            <asp:BoundField DataField="CORREO" HeaderText="Correo"></asp:BoundField>
        </Columns>


        <FooterStyle BackColor="White" ForeColor="#000066"></FooterStyle>

        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" CssClass="celdas-titulos"></HeaderStyle>
        <PagerStyle HorizontalAlign="Left" BackColor="White" ForeColor="#000066"></PagerStyle>

        <RowStyle ForeColor="#000066"></RowStyle>

        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White"></SelectedRowStyle>

        <SortedAscendingCellStyle BackColor="#F1F1F1"></SortedAscendingCellStyle>

        <SortedAscendingHeaderStyle BackColor="#007DBB"></SortedAscendingHeaderStyle>

        <SortedDescendingCellStyle BackColor="#CAC9C9"></SortedDescendingCellStyle>

        <SortedDescendingHeaderStyle BackColor="#00547E"></SortedDescendingHeaderStyle>
    </asp:GridView>
 <asp:Button ID="idEditar"  Style=" margin-top: -69px; margin-left: 120px;" Text="Editar Usuario" class="btn btn-success btn-lg" runat="server" OnClick="idEditar_Click" visible="false" />

                    </div>

    <br /><br />
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

           
                </div></div>

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
