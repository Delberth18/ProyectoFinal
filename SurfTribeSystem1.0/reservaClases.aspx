<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reservaClases.aspx.cs" Inherits="SurfTribeSystem1._0.reservaClases" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="bookingTypeSection">
  <div class="container">
    <div class="row">
      <div class="col-xs-12">
        <div class="bookingType bg-ashs">
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
        <div class="recentActivityContent bg-ashs">
            
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <br />
                            <center><font size="5"><b FACE="arial">Seleccione su destino</b></font></center><br />
                        
                    </div>
                </div>
                <div class="row">
                  
                   
  
 
                 <img src="ccss/star-1-3/Static%20HTML/img/mapaCR.gif"  usemap="#image-map"  >

<map name="image-map">
   
    <li class="li" > 
        <a class="link"> <u></u></a>
  <a class="link" >
    
    <area target=""  alt="Puntarenas" title="Puntarenas" href="" coords="498,526,497,518,497,510,496,502,492,494,487,487,479,483,473,478,479,475,485,470,490,464,496,463,502,462,506,456,509,448,508,440,508,431,504,424,499,417,496,410,499,404,499,396,505,391,511,390,518,389,522,384,523,377,518,370,510,366,502,361,495,356,486,353,480,346,472,342,468,333,464,327,457,322,452,316,445,317,438,314,429,309,425,313,417,316,409,313,406,320,401,326,400,333,403,339,403,346,402,353,397,358,389,355,382,349,375,345,371,337,364,332,356,333,347,327,344,320,340,313,336,305,328,305,321,298,314,291,307,285,304,277,296,273,288,269,280,267,272,265,262,265,257,270,251,276,242,277,231,272,229,263,226,256,225,247,232,246,230,238,226,231,218,229,212,222,217,215,224,213,231,207,223,202,218,194,213,187,212,180,213,172,212,163,205,162,197,161,193,153,186,153,179,158,181,164,179,170,179,176,174,180,172,187,165,182,156,180,148,181,150,187,158,189,164,194,168,199,174,203,179,207,186,208,187,214,200,213,204,218,209,229,210,235,216,240,217,246,217,252,212,257,212,264,216,270,223,278,230,280,234,285,247,284,253,286,260,289,267,289,274,291,281,294,288,296,292,301,295,308,302,309,309,311,317,315,324,318,330,322,335,326,344,335,350,336,356,341,358,347,364,349,368,354,371,360,377,362,380,367,382,373,381,384,383,390,384,397,377,400,380,405,387,405,378,411,376,417,371,422,365,427,363,434,365,440,370,443,375,448,380,453,384,457,389,462,396,460,403,461,411,462,418,467,425,469,432,472,437,463,434,453,432,445,425,438,416,437,411,430,406,422,412,416,426,415,428,422,433,427,440,428,448,430,456,429,459,435,452,437,458,441,462,446,462,453,463,460,458,466,457,473,463,477,469,484,479,491,485,494" shape="poly">
    
    <area target="" alt="Puntarenas 2" title="Puntarenas" href="" coords="142,278,143,276,149,264,155,259,159,254,164,251,168,246,173,242,178,237,172,233,170,226,169,217,162,217,155,214,148,211,141,209,131,208,125,210,120,212,113,212,111,218,122,220,127,224,130,230,130,236,128,243,124,248,125,254,128,259,132,264,136,269,136,274" shape="poly">
    <area target="" alt="Puntarenas3" title="Puntarenas" href="" coords="133,185,140,189,143,197,129,190,134,195,129,190" shape="poly">
   </a>
             
             
             
</li>

         <li class="li" > 
                
  <a class="link"> <i></i></a>
  <a class="link" >
     <area target="" alt="Guanacaste"  title="Guanacaste" href="" coords="185,150,194,143,197,134,193,127,186,120,178,115,169,111,162,105,159,95,152,89,143,88,136,82,127,80,120,82,113,76,107,69,97,66,91,61,94,54,98,49,105,45,111,43,116,37,122,35,117,28,110,24,103,22,94,22,85,18,77,16,72,9,63,6,58,11,56,18,52,24,48,30,53,35,48,39,41,39,46,45,48,51,39,54,32,58,27,51,21,55,13,58,18,63,24,67,29,68,34,73,39,75,47,74,52,80,53,87,54,93,51,101,50,107,58,102,58,108,51,113,44,118,35,118,32,123,34,130,33,136,26,140,22,146,25,152,24,159,24,166,25,172,29,178,32,184,33,191,38,196,43,204,47,208,51,213,53,219,58,222,64,225,71,227,79,227,84,231,91,229,97,232,104,233,109,238,115,240,118,245,126,247,128,234,127,227,118,221,110,219,113,210,120,210,127,210,130,203,126,195,121,188,117,180,116,171,116,162,123,170,126,176,133,178,135,178,146,180,154,177,161,178,165,180,171,185,177,176,178,169,179,165,180,155,185,150,161,178,185,150,193,151,195,133" shape="poly">
            
      
  </a>
             
             
             
</li>
    <li class="li" > 
                
  <a class="link"> <s></s></a>
  <a class="link" >
    <area target="" alt="Limón" title="Limón" href="" coords="406,308,403,298,401,290,396,283,397,274,401,267,406,261,411,253,414,246,420,241,425,234,424,225,422,216,427,210,418,207,411,208,401,209,392,208,384,208,375,203,365,199,357,196,349,194,342,188,332,184,331,177,335,170,341,164,343,156,342,147,339,140,343,132,346,124,344,115,345,108,346,100,352,95,359,94,365,93,359,85,362,77,368,76,373,69,371,57,377,58,382,64,384,74,386,80,381,86,387,88,389,95,393,102,396,109,399,117,402,124,405,131,408,134,412,139,416,145,420,151,422,156,427,161,432,168,440,178,446,183,450,189,456,196,459,202,465,206,476,208,477,213,481,220,488,226,491,232,495,239,501,244,507,251,510,255,517,263,527,265,535,267,543,272,549,279,542,285,535,286,527,282,520,273,509,269,499,272,504,286,496,289,489,295,490,303,489,317,491,337,489,353,472,340,470,330,460,322,454,315,441,314,428,305,421,312,413,310" shape="poly">
</a>
             
             
             
</li>
</map>
                   
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
