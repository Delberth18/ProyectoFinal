﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reservaNivel.aspx.cs" Inherits="SurfTribeSystem1._0.reservaNivel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <section class="bookingTypeSection">
  <div class="container">
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


             <div style=" background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva3.jpg'); position:relative; z-index:1;
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
                            <font size="5"><b FACE="arial">Seleccione el nivel</b></font><br />
                        <br /> 
                    </div>
                </div>  <asp:label runat="server" text="Escuela: "></asp:label>
                <div class="row"><br />
                    <div class="de1 col-xs-12">
                        <div style="margin-left: 40px; background: transparent;" class="thumbnail deals">
                            <img src="ccss/star-1-3/Static%20HTML/img/LongBoard.png" style="height: 600px;width: 140px;" alt="deal-image"/>
                            <a href="ccss/star-1-3/Static HTML/single-package-right-sidebar.html"  class="pageLink"></a>
                            <div class="discountInfo">
                                
                                
                                <ul class="list-inline duration">
                                    
                                    
                                </ul>
                            </div>
                            <div style="padding: 9px;  margin-bottom: 39px;">
                                
                                <div class="detailsInfo">
                                    
                                    <ul class="list-inline detailsBtn">
                                        <li style="background:  darkorange;"><a style="color:white;" href='ccss/star-1-3/Static HTML/booking-1.html' class="btn buttonTransparent">Principiante</a></li>
                                        
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div style="margin-left: 40px; " class="de1 col-xs-12">
                        <div style="bottom: -100px; background: transparent;" class="thumbnail deals">
                            <img src="ccss/star-1-3/Static%20HTML/img/FunBoard.png" style="height: 500px; width: 140px;" alt="deal-image">
                            <a href="ccss/star-1-3/Static HTML/single-package-fullwidth.html" style="color:white;" class="pageLink"></a>
                            <div class="discountInfo">
                               
                                
                                <ul class="list-inline duration">
                                    
                                </ul>
                            </div>
                            <div style="padding: 9px;  margin-bottom: 39px;">
                                
                                
                                <div class="detailsInfo">
                                    
                                    <ul class="list-inline detailsBtn">
                                        <li style="background: darkorange;">
                                            <a data-toggle="modal" data-target="#inquiryModal" href="#" style="color:white;" class="btn buttonTransparent">Intermedio</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div style="margin-left: 40px;"class="de1 col-xs-12">
                        <div style="bottom: -200px; background: transparent;" class="thumbnail deals">
                            <img src="ccss/star-1-3/Static%20HTML/img/ShortBoard.png" style="height: 400px;width: 140px;"/>
                            <a href="ccss/star-1-3/Static HTML/single-package-left-sidebar.html" style="color:white;" class="pageLink"></a>
                            <div class="discountInfo">
                                
                               
                                <ul class="list-inline duration">
                                    
                                </ul>
                            </div>
                            <div style="padding: 9px;  margin-bottom: 39px;">
                                 
                                <div class="detailsInfo">
                                   
                                    <ul class="list-inline detailsBtn">
                                        <li style="background: darkorange;"><a style="color:white;" href='#Nivel' data-toggle="tab" class="reserva btn buttonTransparent  progress-wizard-dot">Avanzado</a></li>
                                    </ul>
                                </div>
                            </div>
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

       
                </div></div>

        </div>
      </div>
    </div>
  </div>
</section>





</asp:Content>
