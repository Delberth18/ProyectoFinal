<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="reservaIndumentaria.aspx.cs" Inherits="SurfTribeSystem1._0.reservaIndumentaria" MaintainScrollPositionOnPostback = "true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <script src="ccss/star-1-3/SCSS/js/contador.js" type="text/javascript"></script>
     <style type="text/css">
.form_input
{
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
            <a style="cursor: auto; background-color: #6E81AD !important; color: white !important;"
                class="btn btn-blue-grey btn-circle-2 waves-effect" title="indumentaria"><i class="fa fa-suitcase"></i></a>
        </div>
         <div class="steps-step-2">
            <a  style="cursor: auto;"  class="btn btn-blue-grey btn-circle-2 waves-effect mr-0"  title="Confirmar"><i class="fa fa-check" ></i></a>
        </div>
    </div>
</div>


             <body onload="countDown();">
                        <form name="form2" method="post">

                            <font size="4"><b FACE="arial" style="margin-left: 75%; margin-top: -80%;" >Tiempo Restante: </b></font>

                            <input type="text" size="5" class="form_input" name="hour" id="hour" disabled visible="false" style="visibility: hidden; width: 1%;">

                            <input type="text" size="10" class="form_input" name="minute" id="minute" disabled style="width: 2%; font-size: xx-large;">
                            <asp:Label runat="server" Text=":" style="width: 2%; font-size: xx-large;" ></asp:Label>
	                        <input type="text" size="8" class="form_input" name="second" disabled style="width: 4%; font-size: xx-large;">
                        </form>

                    </body>


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
                         <asp:ImageButton ID="ImageButton1" OnClick="ImageButton1_Click" runat="server" Style="margin-left: -94%;  width: 40px;" src="ccss/star-1-3/Static%20HTML/img/atras.png" />
                        
                            <center><font size="5"><b FACE="arial" style="margin-left: -70px;" >¿Desea alguna indumentaria?</b></font></center><br />
                        
                    </div>
                </div>
               
                
                
                <br />
                <br /><br /><br /> 
                <div class="row">

                    <asp:Repeater ID="repeater1" runat="server" OnItemDataBound="repeater1_ItemDataBound">
                        <ItemTemplate>
                            <div class="de4 col-xs-12">
                                <div style="box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75); margin-left: 7px;" class="thumbnail deals">

                                    <div class="marco3">
                                        <img src='data:image/jpg;base64,<%#Eval("IMAGEN") %>' width="200" height="150" style="height: 300px;" alt=""/>
                                        <div>

                                            <br>

                                            <p><b>Marca:</b>
                                                <asp:Label runat="server" ID="lblMarca" Text='<%#Eval("MARCA")%>'></asp:Label></p>
                                            <p><b>Tipo:</b>
                                                <asp:Label runat="server" ID="Label3" Text='<%#Eval("TIPO")%>'></asp:Label></p>
                                            <p><b>Tamaño:</b>
                                                <asp:Label runat="server" ID="Label2" Text='<%#Eval("TAMANIO")%>'></asp:Label></p>
                                            
                                             <p><b>Precio:</b>&nbsp;₡
                                                <asp:Label runat="server" ID="lblPrecio" Text='<%#Eval("COSTO")%>'></asp:Label></p>
                                            <asp:Label runat="server" ID="IDTabla" Visible="false" Text='<%#Eval("ID")%>'></asp:Label>
                                        </div>
                                    </div>
                                      <asp:HyperLink ID="hpvReservaConfi" runat="server" class="pageLink"  NavigateUrl="reservaConfirmar.aspx"></asp:HyperLink>


                                </div>
                            </div>



                        </ItemTemplate>

                    </asp:Repeater>

                    
                 
                   
                </div>
                <asp:Button ID="btnOmitir" OnClick="btnOmitir_Click" runat="server" Style="margin-right: -850px; text-decoration: none; padding: 10px 24px; font-family: arial; font-weight: 300; font-size: 25px; font-style: italic; color: white; background-color: #ff891e; border-radius: 1px; border: 3px double white; box-shadow: -11px 9px 45px 2px rgba(0,0,0,0.75);"
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
