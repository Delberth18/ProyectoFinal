<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="FAQRegistro.aspx.cs" Inherits="SurfTribeSystem1._0.FAQRegistro" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <section class="mainContentSection packagesSection" style="background-image: url(Imagenes/IMG-20150830-WA0006.jpg); background-repeat: no-repeat; background-size: cover">
          <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
        <br />
                    <div class="sectionTitle">
                        <h2>
                            <asp:Label runat="server" ID="Label1" Font-Size="xX-Large" Text="Registro de preguntas frecuentes"></asp:Label></h2>

                    </div>
        <br />
        <div class="container">
       
        <a aria-label="NuevaPreguntado" href="FAQMantenimiento.aspx" >
                        <span aria-hidden="true" style="margin: 2px 2px 2px 2px; font-size:x-large;color:saddlebrown" ><<-Listado y Mantenimiento</span>
                    </a>
                 
        <asp:button class="btn btn-default" ID="btnGuardar" OnClick="Guardar_Click" runat="server" style="padding:15px; background-color:darkorange; color:white;  font-family:Arial; text-transform: none; font-size:large; margin-left:52%" Text=" Guardar pregunta " ></asp:button>

             <br />
              <br />
            
       
        

            <div class="row">
          
                  <div class="form-group" style=" 
                            border: solid 0.4px #000000;
                            border-top-left-radius:27px;
                            border-top-right-radius:27px;
                            border-bottom-left-radius:27px;
                            border-bottom-right-radius:28px;  padding:15px 15px 15px 15px; width: 100%; background-color:white" >
                   
                      
                    <asp:TextBox class="form-control  bg-ashh"  id="preguntaText" runat="server" placeholder="Escriba la pregunta" /><br />
                 
                   
                    <asp:TextBox Rows="7" class="form-control bg-ashh" TextMode="MultiLine" id="respuestaText" runat="server" placeholder="Escriba la respuesta"/><br />

                  </div>
                 
                  
                  <div >
                      <br />
                  </div>
                </div>
                    
        </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnGuardar" EventName="" />
            </Triggers>
        </asp:UpdatePanel>
    </section>
    


</asp:Content>
