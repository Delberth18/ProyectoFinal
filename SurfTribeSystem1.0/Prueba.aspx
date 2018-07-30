<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="SurfTribeSystem1._0.Prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="ccss/star-1-3/SCSS/js/jquery-2.1.4.min.js"></script>
    <script src="ccss/star-1-3/SCSS/js/jspdf.debug.js"></script>
</head>

    
<body>
  
     <form id="form1" runat="server">
    

<div id="Reporte" class="row">

    <img src="ccss/star-1-3/Static%20HTML/img/logo-dark.png" style="    width: 20%;" />
       <table style=" margin-left: 35%; border: dotted;" border="0" >
                         

                         <tr> 
                            <td>
                            <b FACE="arial">
                          <asp:Label ID="Label2"  runat="server" Text="Alumno(a): "  style="font-size: 18px; " ></asp:Label></b>
                            </td>
                            <td>
                               &nbsp; <asp:Label ID="lblAlumno" runat="server" Text=" Emmanuel Gonzalez Molina"  Style="font-size: 18px;"></asp:Label>
                   
                            </td>
                           
                        </tr>
                        <tr> 
                            <td>
                            <b FACE="arial">
                          <asp:Label ID="Label1"  runat="server" Text="Escuela: "  style="font-size: 18px; " ></asp:Label></b>
                            </td>
                            <td>
                               &nbsp; <asp:Label ID="lblEscuela" runat="server" Text="Totem"  Style="font-size: 18px;"></asp:Label>
                   
                            </td>
                           
                        </tr>
                        
                          <tr>
                              <td>
                                  <b face="arial">
                                      <asp:Label ID="Label3" runat="server" Text="Nivel: " Style="font-size: 18px;"></asp:Label></b>

                              </td>
                              <td>
                                  <asp:Label ID="lblNivel" runat="server" Text="Experto"  Style="font-size: 18px;"></asp:Label>
                              </td>

                          </tr>   
                       
                        <tr>
                            <td>
                                  <b FACE="arial">
                                <asp:Label ID="lblDia" runat="server" Text="Dia de las clases: "  style="font-size: 18px; " ></asp:Label></b>
                            </td>
                            <td>
                                 <asp:Label ID="lblFecha" runat="server" Text="12 de Junio 2018"  Style="font-size: 18px;"></asp:Label>
                    
                            </td>
                        </tr>
                        <tr>
                            <td>
                                  <b FACE="arial">
                          <asp:Label ID="Label5" runat="server" Text="Hora: "  style="font-size: 18px;" ></asp:Label> </b> 
                            </td>
                            <td>
                                 <asp:Label ID="lblHora" runat="server" Text="9:00 am"  Style="font-size: 18px;"></asp:Label>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                 <b FACE="arial">
                          <asp:Label ID="Label7" runat="server" Text="Instructor: "  style="font-size: 18px;  " ></asp:Label></b>
                            </td>
                            <td>
                                 <asp:Label ID="lblInstructor" runat="server" Text="Pedro Alejandro Gómez Alvarado"  Style="font-size: 18px;"></asp:Label>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                   <b FACE="arial">
                          <asp:Label ID="Label9" runat="server" Text="Indumentaria: "  style="font-size: 18px;" ></asp:Label></b>
                            </td>
                            <td>
                                 <asp:Label ID="lblAlquilerDeta" runat="server" Text="No alquilada"  Style="font-size: 18px;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                 <b FACE="arial">
                          <asp:Label ID="Label11" runat="server" Text="Ubicación: "  style="font-size: 18px;" ></asp:Label></b>            

                            </td>
                            <td>

                    <asp:Label ID="lblUbicación" runat="server" Text="Guanacaste"  Style="font-size: 18px;"></asp:Label>
                  
                            </td>
                        </tr>


                    </table>
        

    <input type="button" onclick="DescargarPDF('Reporte','ReporteASP')" value="Decargar Reporte"/>

</div>


    </form>
     <script>
        function DescargarPDF(ContenidoID, nombre) {
            var pdf = new jsPDF('p', 'pt', 'letter');
            html = $('#' + ContenidoID).html();
            specialElementHandlers = {};
            margins = { top: 10, bottom: 20, left: 20, width: 522 };
            pdf.fromHTML(html, margins.left, margins.top, { 'width': margins.width }, function (dispose) { pdf.save(nombre + '.pdf'); }, margins);
        }
    </script>
       
</body>
        
</html>
