﻿<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site4.Master" AutoEventWireup="true" CodeBehind="reservaHorario.aspx.cs" Inherits="SurfTribeSystem1._0.reservaHorario " MaintainScrollPositionOnPostback = "true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="ccss/star-1-3/SCSS/js/contador.js" type="text/javascript"></script>

    <style type="text/css">
        .form_input {
            font-family: Verdana;
            font-size: 12;
            background-color: white;
            border-width: 0;
            text-align: right;
        }
    </style>
         
   
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
            <a style="cursor: auto; background-color: #6E81AD !important; color: white !important;"
                class="btn btn-blue-grey btn-circle-2 waves-effect mr-0" title="Horario"><i class="fa fa-calendar-check-o"></i></a>
        </div>
         <div class="steps-step-2">
            <a  style="cursor: auto;"  class="btn btn-blue-grey btn-circle-2 waves-effect"  title="indumentaria"><i class="fa fa-suitcase" ></i></a>
        </div>
         <div class="steps-step-2">
            <a  style="cursor: auto;"  class="btn btn-blue-grey btn-circle-2 waves-effect mr-0"  title="Confirmar"><i class="fa fa-check" ></i></a>
        </div>
    </div>
</div>

             <body onload="countDown();">
                        <form name="form2">

                            <font size="4"><b FACE="arial" style="margin-left: 75%; margin-top: -80%;" >Tiempo Restante: </b></font>

                            <input type="text" size="5" class="form_input" name="hour" disabled visible="false" style="visibility: hidden; width: 1%;">

                            <input type="text" size="10" class="form_input" name="minute" disabled style="width: 2%; font-size: xx-large;">
                            <asp:Label runat="server" Text=":" style="width: 2%; font-size: xx-large;" ></asp:Label>
	                        <input type="text" size="8" class="form_input" name="second" disabled style="width: 4%; font-size: xx-large;">
                        </form>

                    </body>
         
          

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
                        <asp:Label runat="server" ID="Ubicacion" Text="Guanacaste"></asp:Label>
                        <font size="4" style="margin-left: 120px;"><b FACE="arial">2. <u>Escuela:</u>&nbsp;&nbsp;</b></font>
                        <asp:Label runat="server" ID="nombreEscuela" Text="Caribean'ss"></asp:Label>
                        <font size="4" style="margin-left: 120px;"><b FACE="arial">3. <u>Nivel:</u>&nbsp;&nbsp;</b></font>
                        <asp:Label runat="server" ID="nivel" Text="Experto"></asp:Label>

                        <br />
                    </div>

                </div>  <br /><br />
                 <div class="row"><br />
               

              
               
               <div class="de1 col-xs-12" >
                       
                   <div class="container">
                       <div class="row">
                           

                        <asp:Repeater  OnItemDataBound="repeater1_ItemDataBound" OnItemCommand="repeater1_ItemCommand"  ID="repeater1" runat="server" >
                             <ItemTemplate>
                                 <div class="de5 col-xs-12">
  <center>
  
    <div style=" width: 290px; height: 270px; -webkit-box-shadow: 14px 28px 38px -16px rgba(0,0,0,0.75);
-moz-box-shadow: 14px 28px 38px -16px rgba(0,0,0,0.75);
box-shadow: 14px 28px 38px -16px rgba(0,0,0,0.75); background: url('ccss/star-1-3/Static%20HTML/img/reservaCalendario.png') no-repeat ; background-size: 100%; 
     border-color: transparent; margin-left: 50px; " class="panel panel-default"  >

      <div  style="height: 90px; background:  transparent; border-color: transparent;"  class="panel-heading">
        <h4 style="margin-top: 45px; color: beige;" class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion"  href="#<%#Eval("ID")%>"><asp:Label runat="server" ID="fecha" Text="Detalles"></asp:Label></a>
        </h4>
          <asp:Image ID="ss" runat="server" CommandArgument='<%#Eval("ID")%>'  style="margin-left: 223px;  margin-top: 40px;"  Visible="false" ImageUrl="ccss/star-1-3/Static%20HTML/img/booking/alert-check.png" ></asp:Image>
      </div>
       
       
        
     
      <div id="<%#Eval("ID")%>" style="    position: absolute;
    width: 288px;" class="panel-collapse collapse">
        <div class="panel-body" style=" background-color: lightgoldenrodyellow;"><br />
            <font size="3" text-align="left"><b>Hora de Inicio:</b></font>&nbsp;&nbsp;<asp:Label ID="hInicio" runat="server" Text='<%#Eval("HRAINICIO1")%>'></asp:Label><br />
            <font size="3"><b>Hora de Finalización:</b></font>&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text='<%#Eval("HRAFINAL1")%>'></asp:Label><br />
             <font size="3"><b>Instructor:</b></font>&nbsp;&nbsp;<asp:Label ID="lblNombre" runat="server" Text='<%#Eval("NOMBRE")%>'></asp:Label>&nbsp;
            <asp:Label ID="lblApellidos" runat="server" Text='<%#Eval("APELLIDOS")%>'></asp:Label>
            <br />
             <font size="3"><b>Precio:</b></font>&nbsp;₡<asp:Label ID="lblPrecio" runat="server" Text='<%#Eval("PRECIO")%>'></asp:Label>
            <br /><br />

        <!--<asp:Button runat="server"  CommandArgument='<%#Eval("ID")%>' style="border-radius: 12px; background: #008CBA; color: white;"  ID="btnRegistrar" Text="  Reservar  "  Visible="true" OnClick="btnRegistrar_Click"/>-->
             <asp:Button runat="server" style="border-radius: 12px; background: #008CBA;  color: white;" CommandName='<%#Eval("ID")%>' CommandArgument='<%#Eval("ID")%>'  ID="btnDesselecionar" Text="  Reservar  "  Visible="false" />

        </div>
      </div><br /><br />
        
         <asp:Label style="margin-top: 80px; color: black;" runat="server" ID="lblDia" Font-Size="60px" Text='<%#Eval("DIA")%>'></asp:Label><br /><br />
         <asp:Label style="margin-top: 80px; color: black;" runat="server" ID="lblMes" Font-Size="40px" Text='<%#Eval("MES")%>'></asp:Label>
    </div>
    
    
 </center>
                                 </div>
                                 <asp:Label ID="lblfecha" runat="server" Text='<%#Eval("FECHA")%>' Visible="false"></asp:Label>
                             </ItemTemplate>

                        </asp:Repeater> 

                                   

                       </div><br />
                       <asp:Button ID="btnContinuar" runat="server" OnClick="btnRegistrar_Click" Style="margin-right: -600px;  text-decoration: none; padding: 10px 24px; font-family: arial; font-weight: 300; font-size: 25px; font-style: italic; color: white; background-color: #ff891e; border-radius: 1px; border: 3px double white; box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75);"
                           Text="Continuar"  Visible="false" />

                   </div>
               </div>

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
