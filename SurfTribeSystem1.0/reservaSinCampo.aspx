<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reservaSinCampo.aspx.cs" Inherits="SurfTribeSystem1._0.reservaSinCampo" %>
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
                       
                   <div class="container" style="background-color: chocolate;
    width: 317%;">
                       
                          

  <!-- PAGE CONTENT -->


  
   <img src="ccss/star-1-3/Static%20HTML/img/not-found/not-found.png"  style="      width: 26%;  margin-top: 3%;
    margin-left: -12%;"/><br /><br />
    <h4 class="col-lg-11" style="
    background-color: chocolate;
    font-size: 20px;
    color:  white;
">En este momento no hay reservas disponibles en esta escuela con el nivel seleccionado.</h4>
   
    <div class="input-group">
    
    </div>
 



                    
                       <br />
                      

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
