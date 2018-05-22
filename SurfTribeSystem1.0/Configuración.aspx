<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Configuración.aspx.cs" Inherits="SurfTribeSystem1._0.Configuración" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
              <form action="" method="post">
                <div class="col-sm-12">
                  <input type="text" class="form-control" id="inputPassword3" placeholder="Old Password">
                </div>
                <div class="col-sm-12">
                  <input type="text" class="form-control" id="inputPassword3" placeholder="New Password">
                </div>
                <div class="col-sm-12">
                  <input type="password" class="form-control" id="inputPassword3" placeholder="Confirm New Password">
                </div>
                <div class="col-sm-12">
                  <button type="submit" class="btn buttonTransparent">Update Password</button>
                </div>
              </form>
            </div>
          </div>
          <hr>
            <br />
          <!-- Change email -->
             <font size="5" color="#ff891e"><b FACE="arial" size="20%">Cambio de Correo Electrónico</b></font>
          <div class="changeEmail">
            <div class="row">
              <form action="" method="post">
                <div class="col-sm-12">
                  <input type="text" class="form-control" id="inputPassword3" placeholder="Old Email">
                    <asp:TextBox runat="server" type="text" class="form-control" id="inputPassword" placeholder="Old Email" ></asp:TextBox>
                </div>
                <div class="col-sm-12">
                  <input type="text" class="form-control" id="inputPassword3" placeholder="New Email">
                </div>
                <div class="col-sm-12">
                  <input type="password" class="form-control" id="inputPassword3" placeholder="Confirm New Email">
                </div>
                <div class="col-sm-12">
                  <button type="submit" class="btn buttonTransparent">Update Email Address</button>
                </div>
              </form>
            </div>
          </div>
          <hr>
            <br />
             <font size="5" color="#ff891e"><b FACE="arial" size="20%">Cambio de Preferencias</b></font>

          <!-- Change Setting  -->
          <div class="changeSetting">
           
            <div class="row">
              <form action="" method="post">
                <div class="form-check col-sm-12">
                	<input id="checkbox-1" class="checkbox-custom form-check-input" name="checkbox-1" type="checkbox"  >
                	<label for="checkbox-1" class="checkbox-custom-label form-check-label">Star Travel has periodic offers and deals on really cool destinations.</label>
                </div>
                <div class="form-check col-sm-12">
                	<input id="checkbox-2" class="checkbox-custom form-check-input" name="checkbox-1" type="checkbox"  >
                	<label for="checkbox-2" class="checkbox-custom-label form-check-label">Star Travel has fun company news, as well as periodic emails.</label>
                </div>
                <div class="form-check col-sm-12">
                	<input id="checkbox-3" class="checkbox-custom form-check-input" name="checkbox-1" type="checkbox" >
                	<label for="checkbox-3" class="checkbox-custom-label form-check-label">I have an upcoming reservation.</label>
                </div>

                <div class="col-sm-12">
                  <button type="submit" class="btn buttonTransparent">Update Email Address</button>
                </div>
              </form>
            </div>
          </div>

        </div>
      </div>
    </div>
  </div>
</section></center></fielset>
</asp:Content>
