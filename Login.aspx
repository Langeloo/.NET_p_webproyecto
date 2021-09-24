<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Baberia.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>Iniciar Sesión</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

   
 <div>


<section class="vh-100">
  <div class="container-fluid">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-md-9 col-lg-6 col-xl-5">
        <img src="/uploads/barber_service_02.jpg" class="img-fluid"
          alt="Sample image">
      </div>
      <div class="col-md-8 col-lg-6 col-xl-4 offset-xl-1">
          <h2 class="display-4">BIENVENIDO</h2>
          <div class="d-flex flex-row align-items-center justify-content-center justify-content-lg-start">
            <p class="lead fw-normal mb-0 me-3"><br /> Por favor Ingrese sus datos<br /></p>
          </div>

          <!-- Email input -->
          <div class="form-outline mb-4">
              <asp:TextBox ID="TextBoxCorreo" runat="server" class="form-control form-control-lg"
              placeholder="Ingrese un correo válido @" TextMode="Email" required="true" CausesValidation="True"></asp:TextBox>
            
            <label class="form-label" for="form3Example3">Ingrese un Correo Electronico Válido</label>
          </div>

          <!-- Password input -->
          <div class="form-outline mb-3">

              
            <asp:TextBox runat="server" type="password" id="TextBoxPassword" class="form-control form-control-lg"
              placeholder="Ingrese su contraseña" required="true" ></asp:TextBox>
            
            <label class="form-label" for="form3Example4">Contraseña</label>
          </div>

          <div class="d-flex justify-content-between align-items-center">
            <!-- Checkbox -->
            <div class="form-check mb-0">
              <a href="Registrarse.aspx" class="link-danger">¿No tiene cuenta? Registrese aquí</a>
            </div>
              &nbsp;</div>
            <!-- Boton entrar -->
          <div class="text-lg-start mt-4 pt-2">

              <asp:Button ID="ButtonIniciarSesion" runat="server" Text="Ingresar" class="btn btn-danger btn-lg"
              style="padding-left: 2.5rem; padding-right: 2.5rem;" OnClick="ButtonIniciarSesion_Click"/>

          </div>
      </div>
    </div>
  </div>

    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <!-- Right -->
   
</section>

 </div>
   
</asp:Content>
