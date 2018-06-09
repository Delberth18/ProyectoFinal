<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reservaEscuelas.aspx.cs" Inherits="SurfTribeSystem1._0.reservaEscuelas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <section class="bookingTypeSection">
  <div class="container">
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
                            <center><font size="5"><b FACE="arial">Seleccione su escuela</b></font></center><br />
                        
                    </div>
                </div>
                <div class="row">

                    <asp:Repeater ID="repeater1" runat="server">
                        <ItemTemplate>
                        <div class="de2 col-xs-12">
                        <div class="thumbnail deals">
                            <img src="ccss/star-1-3/Static HTML/img/home/deal/deal-02.jpg" alt="deal-image">
                            <a href="ccss/star-1-3/Static HTML/single-package-right-sidebar.html" class="pageLink"></a>
                            <div class="discountInfo">
                                
                                
                                <ul class="list-inline duration">
                                    
                                    
                                </ul>
                            </div>
                            <div class="caption">
                                
                                
                                <center><font size="4"><b FACE="arial"><asp:Label runat="server" ID="nombre" Text=<%#Eval("NOMBRE")%>></asp:Label></b></font></center><br />
                                <p><b>Playa:</b> <asp:Label runat="server" ID="playa" Text=<%#Eval("PLAYA_CONCURRIDA")%>></asp:Label></p>
                                <div class="detailsInfo">
                                    
                                    <ul class="list-inline detailsBtn">
                                        <li><a href='ccss/star-1-3/Static HTML/booking-1.html' class="btn buttonTransparent">Ir a escuelas</a></li>
                                    </ul>
                                </div>
                               
                            </div>
                        </div>
                    </div>



                            </ItemTemplate>

                    </asp:Repeater>

                    
                 
                   
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
