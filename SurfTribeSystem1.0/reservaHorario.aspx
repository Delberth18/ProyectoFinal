<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reservaHorario.aspx.cs" Inherits="SurfTribeSystem1._0.reservaHorario" %>
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
  <center>
  
    <div style="width: 430px;" class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse1">Martes 12 de junio 2018</a>
        </h4>
      </div>
      <div id="collapse1" class="panel-collapse collapse in">
        <div class="panel-body">Lorem ipsum dolor sit amet, consectetur adipisicing elit,
        sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
        quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</div>
      </div>
    </div>
    
    <div style="width: 430px;" class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#collapse3">Collapsible Group 3</a>
        </h4>
      </div>
      <div id="collapse3" class="panel-collapse collapse">
        <div class="panel-body">Lorem ipsum dolor sit amet, consectetur adipisicing elit,
        sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
        quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</div>
      </div>
    </div>
 </center>
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
