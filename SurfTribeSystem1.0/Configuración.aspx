<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Configuración.aspx.cs" Inherits="SurfTribeSystem1._0.Configuración" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br /><br />
    <fielset>
     <section class="pageTitle" >
      <div class="container">
        <div class="row">
          <div class="col-xs-12">
            <div class="titleTable">
              <div class="titleTableInner">
                <div class="pageTitleInfo">
                  <h1>Configuración</h1>
                  <div class="under-border"></div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>



    <section class="settingSection"><center>
  <div class="container">
    <div class="row">
      <div class="col-xs-12">
        <div class="settingContent bg-ash">
           <font size="5" color="#ff891e"><b FACE="arial" size="20%">Cambio de Contraseña</b></font>
          <!-- Change Password -->
          <div class="changePassword">
          
            <div class="row">
             
                   <div class="col-sm-12">
                  <asp:TextBox ID="TextBox3" class="form-control" placeholder="Contraseña Pasada"  runat="server" TextMode="Password"></asp:TextBox>
                </div>
                
                <div class="col-sm-12">
                    <asp:TextBox ID="TextBox1" class="form-control" placeholder="Contraseña Nueva"  runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="col-sm-12">
                   <asp:TextBox ID="TextBox2" class="form-control" placeholder="Confirmar Contraseña Nueva"  runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                <div class="col-sm-12">
                  
                    <asp:Button ID="Button1" runat="server" class="btn buttonTransparent" Text="Actualizar Contraseña"></asp:Button>
                </div>
             
            </div>
          </div>
         
            <br />
         
        </div>
      </div>
    </div>
  </div>
</section></center></fielset>
</asp:Content>
