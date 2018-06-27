<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="editarUsuarios.aspx.cs" Inherits="SurfTribeSystem1._0.editarUsu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
    
 <section class="bookingTypeSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg);     background-size: 1355px;">
        
  <div class="container">
    <div class="row">
      <div class="col-xs-12">
        <div class="bookingType bg-ashs" style="margin-left:170px;  width:750px;"><br /><br /><br />



            <div style=" background-image: url('ccss/star-1-3/Static%20HTML/img/bg-menuReserva.jpg'); position:relative; z-index:1;
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
                    <asp:Label ID="errorLabel" class="alert alert-danger alert-dismissible" runat="server" Visible="false" Style="margin-left: -20px;"></asp:Label>  

  
           <asp:Table ID="tabGeneral" runat="server" class="container" style=" background: orange;
    opacity: 0.9;
    width: 709px;
    margin-left: -10px;" >
                    <asp:TableRow>
                        <asp:TableCell >
                            <div class="form-group" style="color:black; font-size:20px; margin-left:40px; "><br />
                              <label class="col-lg-2 control-label" for="focusedInput">Nombre</label>
                                <div class="col-lg-10 txtnormal">
                                    <asp:TextBox id="txtNombre"  runat="server" style="width:400px;" class="form-control"></asp:TextBox>
                                </div>
                            </div><br /><br />
                            <div class="form-group" style="color:black; font-size:20px; margin-left:40px;">
                              <label class="col-lg-2 control-label" for="focusedInput">Apellidos</label>
                                <div class="col-lg-10 txtnormal">
                                    <asp:TextBox id="txtApellidos"  runat="server" style="width:400px;"  class="form-control"></asp:TextBox>
                                </div>
                            </div><br /><br />
                            <div class="form-group" style="color:black; font-size:20px; margin-left:40px;">
                              <label class="col-lg-2 control-label" for="focusedInput">Correo</label>
                                <div class="col-lg-10 txtnormal">
                                    <asp:TextBox id="txtCorreo"  runat="server" ReadOnly="true" style="width:400px;" class="form-control"></asp:TextBox>
                                </div>
                            </div><br /><br />
                             
                           
                                  <div class="form-group" style="color:black; font-size:20px; margin-left:40px;">
                              <label class="col-lg-2 control-label" for="inputEmail">Teléfono</label>
                                <div class=" col-lg-10 txtnormal">
                                    <asp:TextBox id="txtNumero"  runat="server" class="form-control" style="width:400px;" ></asp:TextBox>
                                </div>
                            </div><br /><br />
                             <div class="form-group" style="color:black; font-size:20px; margin-left:40px;">
                              <label class="col-lg-2 control-label" for="focusedInput">País</label>
                                <div class="col-lg-10 txtPequeño">
                                    <asp:TextBox id="txtPaís"   runat="server" class="form-control" style="width:400px;"></asp:TextBox>
                                </div>
                            </div><br /><br />
                                  
                            <div class="form-group" style="color:black; font-size:20px; margin-left: 135px;">
                             
                                <div class="col-lg-10 txtPequeño">
                                  
                                     <asp:TextBox id="txtUsu" runat="server" Visible="false" ></asp:TextBox>
                                    <asp:TextBox id="txtauxClave" runat="server" Visible="false" ></asp:TextBox>

                                    <div class="container" style="margin-left: 2px; width: 430px;">
                                        <div class="panel-group">
                                            <div class="panel panel-default">
                                                <div class="panel-heading">
                                                    <h4 class="panel-title">
                                                        <a data-toggle="collapse" href="#collapse1">Cambiar Contraseña</a>
                                                    </h4>
                                                </div>
                                                <div id="collapse1" class="panel-collapse collapse">
                                                    <div class="panel-body" ><asp:TextBox id="txtClave" TextMode="Password"   runat="server" class="form-control" style="width:200px;"></asp:TextBox></div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div><br /><br /><br /><br />
                            
                              
                              
                         
                        </asp:TableCell>
                    </asp:TableRow>

             </asp:Table><div  style=" background: orange; opacity: 0.9;
    width: 709px;
    margin-left: -10px;">
     
         <asp:Button ID="btnEliminar" style="margin-left:-35px;" Text="Eliminar" onclientclick="return confirm('¿Desea Eliminar este usuario?');" class="btn btn-danger" CausesValidation="false"  OnClick="btnEliminar_Click" runat="server" />
                                
                                  <asp:Button ID="idGuardar" style="margin-left: 257px;" Text="Guardar" class="btn btn-success btn-lg" CausesValidation="false"  runat="server"  OnClick="idGuardar_Click" />&nbsp;&nbsp;&nbsp;
                                   <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-primary" CausesValidation="false" OnClick="btnCancelar_Click" />
    
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
