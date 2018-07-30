<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="prueba2.aspx.cs" Inherits="SurfTribeSystem1._0.prueba2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    
    <script src="ccss/star-1-3/SCSS/js/jquery-2.1.4.min.js"></script>
    <script src="ccss/star-1-3/SCSS/js/jspdf.debug.js"></script>
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
            <a style="cursor: auto; background-color: #6E81AD !important; color: white !important;"
                class="btn btn-blue-grey btn-circle-2 waves-effect mr-0" title="Confirmar"><i class="fa fa-check"></i></a>
        </div>
    </div>
</div>

          


            <div style=" background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva6.jpg'); position:relative; z-index:1;
          -webkit-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); -moz-box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); border-radius: 12px;">

            <div class="tab-content" >
            <div id="Lugar" class="tab-pane fade in active">

                <section class="recentActivitySection">
  <div class="container">
		<div class="de6">
			<div class="col-xs-12 ">
        <div class="recentActivityContent bg-ashs">
           
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                      <asp:ImageButton ID="ImageButton1" runat="server" Style="margin-left: -980px;  width: 40px;" src="ccss/star-1-3/Static%20HTML/img/atras.png" />
                        <br /><br />
                            <center><font size="5"><b FACE="arial" style="margin-left: -10px;" >Detalles de Reserva</b></font></center><br />
                        
                    </div>
                </div><br /><br />
             
               
                <div class="row">
                     <div id="Reporte" >
            

                    
                         

                         
                          <asp:Label ID="Label2"  runat="server" Text="Alumno(a):" ></asp:Label>
                           
                              <asp:Label ID="lblAlumno" runat="server" Text="Carlos Fernandez" ></asp:Label>
                   
                         
                            <b FACE="arial">
                          <asp:Label ID="Label1"  runat="server" Text="Escuela: "  style="font-size: 18px; " ></asp:Label></b>
                           <asp:Label ID="lblEscuela" runat="server" Text="Totem"  Style="font-size: 18px;"></asp:Label>
                   
                       
                                  <b face="arial">
                                      <asp:Label ID="Label3" runat="server" Text="Nivel: " Style="font-size: 18px;"></asp:Label></b>

                           
                                  <asp:Label ID="lblNivel" runat="server" Text="Experto"  Style="font-size: 18px;"></asp:Label>
                         
                       
                       
                                  <b FACE="arial">
                                <asp:Label ID="lblDia" runat="server" Text="Dia de las clases: "  style="font-size: 18px; " ></asp:Label></b>
                        
                                 <asp:Label ID="lblFecha" runat="server" Text="12 de Junio 2018"  Style="font-size: 18px;"></asp:Label>
                    
                       
                                  <b FACE="arial">
                          <asp:Label ID="Label5" runat="server" Text="Hora: "  style="font-size: 18px;" ></asp:Label> </b> 
                          
                                 <asp:Label ID="lblHora" runat="server" Text="9:00 am"  Style="font-size: 18px;"></asp:Label>
                       
                 
                                 <b FACE="arial">
                          <asp:Label ID="Label7" runat="server" Text="Instructor: "  style="font-size: 18px;  " ></asp:Label></b>
                   
                                 <asp:Label ID="lblInstructor" runat="server" Text="Pedro Alejandro Gómez Alvarado"  Style="font-size: 18px;"></asp:Label>
                        
                                   <b FACE="arial">
                          <asp:Label ID="Label9" runat="server" Text="Indumentaria: "  style="font-size: 18px;" ></asp:Label></b>
                          
                                 <asp:Label ID="lblAlquilerDeta" runat="server" Text="No alquilada"  Style="font-size: 18px;"></asp:Label>
                        
                                 <b FACE="arial">
                          <asp:Label ID="Label11" runat="server" Text="Ubicación: "  style="font-size: 18px;" ></asp:Label></b>            

                           

                    <asp:Label ID="lblUbicación" runat="server" Text="Guanacaste"  Style="font-size: 18px;"></asp:Label>
                  
                       


                    
                 
                    
                 
                    <hr style="margin-left: 18.5%; border-top: 1px solid black; width: 60.5%;" />


                    <table  style="margin-left: 62%;">
                        <tr>
                           <td>
                               <b FACE="arial">
                          <asp:Label ID="Label15" runat="server" Text="Lecciones: "  style="font-size: 16px;" ></asp:Label></b>&nbsp;
                           </td>
                            <td style="text-align: left;">
  
                             &nbsp;  <asp:Label ID="lblPrecioLec" runat="server" Text="₡ 10.000"  Style="font-size: 16px;"></asp:Label>
                            </td>
                        </tr>
                         <tr>
                           <td>
                               <b FACE="arial">
                          <asp:Label ID="lblHeaderAlquiler" runat="server" Text="Alquiler: "  style="font-size: 16px;" ></asp:Label></b>&nbsp;
                           </td>
                            <td style="text-align: left;">
  
                             &nbsp;  <asp:Label ID="lblPrecioAlquiler" runat="server" Text="₡ 0"  Style="font-size: 16px;"></asp:Label>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                 <b FACE="arial">
                          <asp:Label ID="Label19" runat="server" Text="Impuesto: "  style="font-size: 16px;" ></asp:Label></b>&nbsp;
                            </td>
                            <td style="text-align: left;">
                               &nbsp;   <asp:Label ID="lblImpuestos" runat="server" Text="₡ 1.000"  Style="font-size: 16px;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                 <b FACE="arial">
                         <asp:Label ID="Label17" runat="server" Text="Total: "  style="font-size: 16px;" ></asp:Label></b>&nbsp; 
                            </td>
                            <td style="text-align: left;">&nbsp;
                         <u><asp:Label ID="lblTotal" runat="server" Text="₡ 11.000"  Style="font-size: 16px;"></asp:Label></u> 
                            </td>
                        </tr>


                    </table>

                    <br /> 

                    <asp:Label ID="Label21" runat="server" Font-Size="Small" Style="    margin-left: -40px;" Text="Al aceptar los términos usted ha leído y esta de acuerdo con el uso de esta aplicación"></asp:Label>
                    <a href="TérminosCondiciones.aspx" target="_blank">Términos  y Condiciones</a><br />
                    <asp:Label ID="Label22" runat="server" Font-Size="Small" Style="margin-left: -40px;" Text="Al reservar el administrador en un rango de 24 horas se pondrá en contacto contigo para darle las instrucciones"></asp:Label><br />
                      <asp:Label ID="Label23" runat="server" Font-Size="Small" Style="    margin-left: -67px;" Text="sobre el deposito de reserva, con el fin de que quede en pie la reserva."></asp:Label><br />
                    <br />
                    <asp:CheckBox ID="ChkTerminosYCon" runat="server"/>&nbsp;<asp:Label ID="label24" Font-Bold="true" runat="server" Text="He leído y acepto los términos y condiciones de uso."></asp:Label>
                </div><br /><br />
                <asp:Button ID="btnOmitir" runat="server"  OnClick="btnOmitir_Click"  Style="margin-right: -480px; text-decoration: none; padding: 10px 24px; font-family: arial; font-weight: 300; font-size: 25px; font-style: italic; color: white; background-color: #ff891e; border-radius: 1px; border: 3px double white; box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75);"
                    Text="Confirmar" /><br /><br /><br />
               
            </div>
               <input type="button" onclick="pdfToHTML('Reporte','ReporteASP')" value="Decargar Reporte"/>

</div>

        
        </div>
			</div>
		</div>
	</div>


            </div>

           
                </div></div>

        </div>
      </div>
    </div>

</section>


     






</asp:Content>
