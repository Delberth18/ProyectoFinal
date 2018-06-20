<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reservaHorario.aspx.cs" Inherits="SurfTribeSystem1._0.reservaHorario " %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
         
   
    <section class="bookingTypeSection">





  <div class="container" >
    <div class="row">
      <div class="col-xs-12">
      <div class="bookingType bg-ashs"><br /><br /><br />
         
          
                            <!-- Stepper -->
<div style="
    background-image: url(ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg); border-radius: 14px;" class="steps-form-2">
    <div class="steps-row-2 setup-panel-2 d-flex justify-content-between">
        <div class="steps-step-2">
            <a style="cursor: auto;" class="btn btn-amber btn-circle-2 waves-effect ml-0"  title="Destino"><i class="fa fa-map-marker"></i></a>
        </div>
        <div class="steps-step-2">
            <a style="cursor: auto;"   class="btn btn-blue-grey btn-circle-2 waves-effect"  title="Escuela"><i class="fa fa-home" ></i></a>
        </div>
        <div class="steps-step-2">
            <a style="cursor: auto;"   class="btn btn-blue-grey btn-circle-2 waves-effect mr-0"  title="Nivel"><i class="fa fa-star" ></i></a>
        </div>
        <div class="steps-step-2">
            <a style="cursor: auto;"   class="btn btn-blue-grey btn-circle-2 waves-effect mr-0" title="Horario"><i class="fa fa-calendar-check-o" ></i></a>
        </div>
         <div class="steps-step-2">
            <a  style="cursor: auto;"  class="btn btn-blue-grey btn-circle-2 waves-effect"  title="indumentaria"><i class="fa fa-suitcase" ></i></a>
        </div>
         <div class="steps-step-2">
            <a  style="cursor: auto;"  class="btn btn-blue-grey btn-circle-2 waves-effect mr-0"  title="Confirmar"><i class="fa fa-check" ></i></a>
        </div>
    </div>
</div><br /><br />
         
          

             <div style=" background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva4.jpg'); position:relative; z-index:1;
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
                    <div class="col-xs-12">
                        <br />
                            <font size="5" style="margin-left: -60px"><b FACE="arial">Seleccione el horario</b></font><br />
                        <br /> <br />
                        <font size="4" style="margin-left: -100px;"><b FACE="arial">1.<u> Ubicación:</u>&nbsp;&nbsp;</b></font>
                        <asp:Label runat="server" ID="Label2" Text="Guanacaste"></asp:Label>
                        <font size="4" style="margin-left: 120px;"><b FACE="arial">2. <u>Escuela:</u>&nbsp;&nbsp;</b></font>
                        <asp:Label runat="server" ID="nombreEscuela" Text="Caribean'ss"></asp:Label>
                        <font size="4" style="margin-left: 120px;"><b FACE="arial">3. <u>Nivel:</u>&nbsp;&nbsp;</b></font>
                        <asp:Label runat="server" ID="Label1" Text="Experto"></asp:Label>

                        <br />
                    </div>

                </div>  <br /><br /><br />
                 <div class="row"><br />
               

              
               
               <div class="de1 col-xs-12" >
                       
                   <div class="container">
                       <div class="row">

                        <asp:Repeater  OnItemDataBound="repeater1_ItemDataBound" OnItemCommand="repeater1_ItemCommand"  ID="repeater1" runat="server" >
                             <ItemTemplate>
                                 <div class="de5 col-xs-12">
  <center>
  <
    <div style=" width: 290px; height: 270px; -webkit-box-shadow: 14px 28px 38px -16px rgba(0,0,0,0.75);
-moz-box-shadow: 14px 28px 38px -16px rgba(0,0,0,0.75);
box-shadow: 14px 28px 38px -16px rgba(0,0,0,0.75); background: url('ccss/star-1-3/Static%20HTML/img/reservaCalendario.png') no-repeat ; background-size: 100%; 
     border-color: transparent; margin-left: 50px; " class="panel panel-default"  >

      <div  style="height: 90px; background:  transparent; border-color: transparent;"  class="panel-heading">
        <h4 style="margin-top: 45px; color: beige;" class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion"  href="#<%#Eval("NOMBRE")%>"><asp:Label runat="server" ID="fecha" Text="Detalles"></asp:Label></a>
        </h4>
          <asp:Image ID="ss" runat="server" CommandArgument='<%#Eval("NOMBRE")%>'  style="margin-left: 223px;  margin-top: 40px;"  Visible="false" ImageUrl="ccss/star-1-3/Static%20HTML/img/booking/alert-check.png" ></asp:Image>
      </div>
       
       
        
     
      <div id="<%#Eval("NOMBRE")%>" style="    position: absolute;
    width: 288px;" class="panel-collapse collapse">
        <div class="panel-body" style=" background-color: lightgoldenrodyellow;"><br />
            <font size="3" text-align="left"><b>Hora de Inicio:</b></font>&nbsp;&nbsp;<asp:Label ID="hInicio" runat="server" Text="9:00 am"></asp:Label><br />
            <font size="3"><b>Hora de Finalización:</b></font>&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="11:00 am"></asp:Label><br />
             <font size="3"><b>Instructor:</b></font>&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="Carlos Alvarado Sanchez"></asp:Label><br /><br />

        <!--<asp:Button runat="server"  CommandArgument='<%#Eval("NOMBRE")%>' style="border-radius: 12px; background: #008CBA; color: white;"  ID="btnRegistrar" Text="  Reservar  "  Visible="true" OnClick="btnRegistrar_Click"/>-->
             <asp:Button runat="server" style="border-radius: 12px; background: #008CBA;  color: white;" CommandName="btnDesselecionar" CommandArgument='<%#Eval("NOMBRE")%>'  ID="btnDesselecionar" Text="  Reservar  "  Visible="false" />

        </div>
      </div><br /><br />
        
         <asp:Label style="margin-top: 80px; color: black;" runat="server" ID="Label3" Font-Size="60px" Text="25"></asp:Label><br /><br />
         <asp:Label style="margin-top: 80px; color: black;" runat="server" ID="Label4" Font-Size="40px" Text="julio"></asp:Label>
    </div>
    
    
 </center></div>
                                 </ItemTemplate>

                    </asp:Repeater>
</div>

                    </div></div>
               
            </div>
        
        </div>
			</div>
		</div></div>
	</div>
</section>

            </div>
                
   
                </div></div>

        </div>
      </div>
    </div>
  </div>
</section>

</asp:Content>
