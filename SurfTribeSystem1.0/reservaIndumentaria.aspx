<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reservaIndumentaria.aspx.cs" Inherits="SurfTribeSystem1._0.reservaIndumentaria" %>
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
                        <br /><br />
                            <center><font size="5"><b FACE="arial" style="margin-left: -70px;" >¿Desea alguna indumentaria?</b></font></center><br />
                        
                    </div>
                </div><br />
                <br /><br /><br /> 
                <div class="row">


                    <asp:Repeater ID="repeater1" runat="server">
                        <ItemTemplate>
                        <div class="de4 col-xs-12">
                        <div  style="box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75);     margin-left: 7px;" class="thumbnail deals">
                            
                            <div  class="marco3"> 
<img src="Imagenes/20180610_135703.jpg" width="200" height="150" style="height: 300px;" alt=""> 
                                <div >
                                    
                                <br>
                              
                                <p><b>Tabla:</b> <asp:Label runat="server" ID="playa" Text=<%#Eval("PLAYA_CONCURRIDA")%>></asp:Label></p>
                                
                               
                            </div>
</div>
                            <a href="ccss/star-1-3/Static HTML/single-package-right-sidebar.html" class="pageLink"></a>
                           
                            
                        </div>
                    </div>



                            </ItemTemplate>

                    </asp:Repeater>

                    
                 
                   
                </div>
                <asp:Button ID="Button1" runat="server" Style="margin-right: -850px; text-decoration: none; padding: 10px 24px; font-family: arial; font-weight: 300; font-size: 25px; font-style: italic; color: white; background-color: #ff891e; border-radius: 1px; border: 3px double white; box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75);"
                    Text="Omitir" />
               
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
