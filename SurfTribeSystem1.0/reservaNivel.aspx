﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reservaNivel.aspx.cs" Inherits="SurfTribeSystem1._0.reservaNivel" %>
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
                            <font size="5"><b FACE="arial">Seleccione el nivel</b></font><br />
                        <br /> 
                    </div>
                </div>  <asp:label runat="server" text="Escuela: "></asp:label>
                <div class="row"><br />
                    <div class="de1 col-xs-12">
                        <div class="thumbnail deals">
                            <img src="ccss/star-1-3/Static HTML/img/home/deal/deal-02.jpg" alt="deal-image">
                            <a href="ccss/star-1-3/Static HTML/single-package-right-sidebar.html" class="pageLink"></a>
                            <div class="discountInfo">
                                
                                
                                <ul class="list-inline duration">
                                    
                                    
                                </ul>
                            </div>
                            <div style="padding: 9px;  margin-bottom: 39px;">
                                
                                <div class="detailsInfo">
                                    
                                    <ul class="list-inline detailsBtn">
                                        <li><a href='ccss/star-1-3/Static HTML/booking-1.html' class="btn buttonTransparent">Elegir</a></li>
                                        
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="de1 col-xs-12">
                        <div class="thumbnail deals">
                            <img src="ccss/star-1-3/Static HTML/img/home/deal/deal-02.jpg" alt="deal-image">
                            <a href="ccss/star-1-3/Static HTML/single-package-fullwidth.html" class="pageLink"></a>
                            <div class="discountInfo">
                               
                                
                                <ul class="list-inline duration">
                                    
                                </ul>
                            </div>
                            <div style="padding: 9px;  margin-bottom: 39px;">
                                
                                
                                <div class="detailsInfo">
                                    
                                    <ul class="list-inline detailsBtn">
                                        <li><a data-toggle="modal" data-target="#inquiryModal" href="#" class="btn buttonTransparent">Elegir</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="de1 col-xs-12">
                        <div class="thumbnail deals">
                            <img src="ccss/star-1-3/Static HTML/img/home/deal/deal-02.jpg" alt="deal-image">
                            <a href="ccss/star-1-3/Static HTML/single-package-left-sidebar.html" class="pageLink"></a>
                            <div class="discountInfo">
                                
                               
                                <ul class="list-inline duration">
                                    
                                </ul>
                            </div>
                            <div style="padding: 9px;  margin-bottom: 39px;">
                                 
                                <div class="detailsInfo">
                                   
                                    <ul class="list-inline detailsBtn">
                                        <li><a href='#Nivel' data-toggle="tab" class="reserva btn buttonTransparent  progress-wizard-dot">Elegir</a></li>
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

            <div id="Nivel" class="tab-pane fade">
               
                <section class="recentActivitySection">
  <div class="container">
		<div class="de">
			<div class="col-xs-12 ">
        <div class="recentActivityContent bg-ash">
          <div class="dashboardPageTitle">
  					<h2>All Types22</h2>
  				</div>
          <div class="table-responsive"  data-pattern="priority-columns">
  					<table class="table listingsTable">
  						<tbody>
  							<tr class="rowItem">
                  <td class="dateTd"><div class="date">25 <span>July</span></div></td>
                  <td class="iconTd">
                    <div class="icon br-orange">
                      <i class="fa fa-fort-awesome" aria-hidden="true"></i>
                    </div>
                  </td>
                  <td class="packageTd">
  									<ul class="list-inline listingsInfo">
  										<li>
  											<h4><a href="#">Hilton Hotel & Resorts</a></h4>
                        <p>2 Adults Staying</p>
  										</li>
  									</ul>
  								</td>
                  <td class="priceTd">
  									<ul class="list-inline listingsInfo text-right">
  										<li>
  											<h4>$125</h4>
                        <p>AVG/Person</p>
  										</li>
  									</ul>
  								</td>
  								<td class="bookingTd">
                    <ul class="list-inline listingsInfo text-left">
  										<li>
  											<h4>TRIP ID</h4>
                        <p>5754-8DK8-8EE</p>
                        <h4>BOOKED ON</h4>
                        <p>Tuesday, Jul 25, 2017</p>
  										</li>
  									</ul>
  								</td>
  							</tr>
                <tr class="rowItem">
                  <td class="dateTd"><div class="date">25 <span>July</span></div></td>
                  <td class="iconTd">
                    <div class="icon br-blue">
                      <i class="fa fa-plane" aria-hidden="true"></i>
                    </div>
                  </td>
                  <td class="packageTd">
  									<ul class="list-inline listingsInfo">
  										<li>
  											<h4><a href="#">India to England</a></h4>
                        <p>You are flying</p>
  										</li>
  									</ul>
  								</td>
                  <td class="priceTd">
  									<ul class="list-inline listingsInfo text-right">
  										<li>
  											<h4>$125</h4>
                        <p>AVG/Person</p>
  										</li>
  									</ul>
  								</td>
  								<td class="bookingTd">
                    <ul class="list-inline listingsInfo text-left">
  										<li>
  											<h4>TRIP ID</h4>
                        <p>5754-8DK8-8EE</p>
                        <h4>BOOKED ON</h4>
                        <p>Tuesday, Jul 25, 2017</p>
  										</li>
  									</ul>
  								</td>
  							</tr>
                <tr class="rowItem">
                  <td class="dateTd"><div class="date">25 <span>July</span></div></td>
                  <td class="iconTd">
                    <div class="icon br-green">
                      <i class="fa fa-car" aria-hidden="true"></i>
                    </div>
                  </td>
                  <td class="packageTd">
  									<ul class="list-inline listingsInfo">
  										<li>
  											<h4><a href="#">Economy Car</a></h4>
                        <p>You are driving</p>
  										</li>
  									</ul>
  								</td>
                  <td class="priceTd">
  									<ul class="list-inline listingsInfo text-right">
  										<li>
  											<h4>$125</h4>
                        <p>AVG/Person</p>
  										</li>
  									</ul>
  								</td>
  								<td class="bookingTd">
                    <ul class="list-inline listingsInfo text-left">
  										<li>
  											<h4>TRIP ID</h4>
                        <p>5754-8DK8-8EE</p>
                        <h4>BOOKED ON</h4>
                        <p>Tuesday, Jul 25, 2017</p>
  										</li>
  									</ul>
  								</td>
  							</tr>
                <tr class="rowItem">
                  <td class="dateTd"><div class="date">25 <span>July</span></div></td>
                  <td class="iconTd">
                    <div class="icon br-red">
                      <i class="fa fa-gift" aria-hidden="true"></i>
                    </div>
                  </td>
                  <td class="packageTd">
  									<ul class="list-inline listingsInfo">
  										<li>
  											<h4><a href="#">London Tour Package</a></h4>
                        <p>3 Days 2 nights</p>
  										</li>
  									</ul>
  								</td>
                  <td class="priceTd">
  									<ul class="list-inline listingsInfo text-right">
  										<li>
  											<h4>$125</h4>
                        <p>AVG/Person</p>
  										</li>
  									</ul>
  								</td>
  								<td class="bookingTd">
                    <ul class="list-inline listingsInfo text-left">
  										<li>
  											<h4>TRIP ID</h4>
                        <p>5754-8DK8-8EE</p>
                        <h4>BOOKED ON</h4>
                        <p>Tuesday, Jul 25, 2017</p>
  										</li>
  									</ul>
  								</td>
  							</tr>
                <tr class="rowItem">
                  <td class="dateTd"><div class="date">25 <span>July</span></div></td>
                  <td class="iconTd">
                    <div class="icon br-blue">
                      <i class="fa fa-fort-awesome" aria-hidden="true"></i>
                    </div>
                  </td>
                  <td class="packageTd">
  									<ul class="list-inline listingsInfo">
  										<li>
  											<h4><a href="#">Hilton Hotel & Resorts</a></h4>
                        <p>2 Adults Staying</p>
  										</li>
  									</ul>
  								</td>
                  <td class="priceTd">
  									<ul class="list-inline listingsInfo text-right">
  										<li>
  											<h4>$125</h4>
                        <p>AVG/Person</p>
  										</li>
  									</ul>
  								</td>
  								<td class="bookingTd">
                    <ul class="list-inline listingsInfo text-left">
  										<li>
  											<h4>TRIP ID</h4>
                        <p>5754-8DK8-8EE</p>
                        <h4>BOOKED ON</h4>
                        <p>Tuesday, Jul 25, 2017</p>
  										</li>
  									</ul>
  								</td>
  							</tr>
  						</tbody>
  					</table>
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
