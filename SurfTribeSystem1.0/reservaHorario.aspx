<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reservaHorario.aspx.cs" Inherits="SurfTribeSystem1._0.reservaHorario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   
    <section class="bookingTypeSection">
  <div class="container" style="margin-top: 8%">
    <div class="row">
      <div class="col-xs-12">
        <div class="bookingType bg-ash">
          <ul class="bookingList bg-ashhh">
            <li><a class="active reserva progress-wizard-dot"  href="#Lugar"  data-toggle="tab">Lugar</a></li>
            <li><a class="reserva  progress-wizard-dot" href="#Nivel"  data-toggle="tab">Escuela</a></li>
            <li><a class="reserva  progress-wizard-dot" href="#Nivel"  data-toggle="tab">Nivel</a></li>
            <li><a href="" class="reserva">Indumentaria</a></li>
            <li><a href="" class="reserva">Horario</a></li>
            <li><a href="" class="reserva"">Confirmar</a></li>
          </ul>
            <div class="tab-content" >
           <div id="Lugar" class="tab-pane fade in active">

                <section class="recentActivitySection">
  <div class="container">
		<div class="de">
			<div class="col-xs-12 ">
        <div class="recentActivityContent bg-ash">
            
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <br />
                            <font size="5"><b FACE="arial">Seleccione el horario</b></font><br />
                        <br /> 
                    </div>
                </div>  
                <asp:label runat="server" text="Escuela: "></asp:label><br /><br />
                 <asp:label runat="server" text="Nivel: "></asp:label><br /><br />
               <div class="de1 col-xs-12" >
                        <div class="reservadatos deals" style=" background-image: url(ccss/star-1-3/Static%20HTML/img/bgbg.jpg);">
                            
                           
                            
                            <div style="padding:9px;" class="caption">
                                
                                
                                <b class="blanco">Fecha:</b><asp:Label ID="Fecha" runat="server" ForeColor="White"  Text=" 12 Junio 2018" ></asp:Label><br /><br />
                              <b class="blanco">Hora de inicio:</b><asp:Label ID="Label1" runat="server" ForeColor="White" Text=" 9:00 am"></asp:Label><br /><br />
                                <b class="blanco">Hora de finalización:</b><asp:Label ID="Label3" runat="server" ForeColor="White" Text=" 11:00 am"></asp:Label><br /><br />
                               <b class="blanco">Instructor(es):</b><asp:Label ID="Label2"  ForeColor="White" runat="server" Text="  Felix Lee Pan, Delberth Valverde Rojas" ></asp:Label><br />
                             
                                
                                   <asp:ImageButton ID="ImageButton1" runat="server"    BackColor="Moccasin"  BorderStyle="NotSet"   ImageAlign="Right" ImageUrl="ccss/star-1-3/Static%20HTML/img/bgSeleccionar.jpg"  BorderWidth="1"  style="border-radius: 9px"  BorderColor="White" />
                            </div>
                           
                         
                        </div>
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
  </div>
</section>

</asp:Content>
