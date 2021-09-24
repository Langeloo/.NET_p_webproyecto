<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Baberia.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>EleganceBarberShop</title>
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon" />
    <link rel="apple-touch-icon" href="images/apple-touch-icon.png"/>
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
    <link rel="stylesheet" href="style.css"/>
    <link rel="stylesheet" href="css/versions.css"/>
    <link rel="stylesheet" href="css/responsive.css"/>
    <link rel="stylesheet" href="css/custom.css"/>
    <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
    <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
 <section class="vh-100">
     <br />
  <div class="container-fluid">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-md-9 col-lg-6 col-xl-5">
        <img src="/uploads/barber_service_06.jpg" class="img-fluid"
          alt="Sample image"/>
      </div>
     
      <div class="col-md-8 col-lg-6 col-xl-4 offset-xl-1">
          <h2 class="display-4">REGISTRATE EN NUESTRA WEB</h2>
          <div class="d-flex flex-row align-items-center justify-content-center justify-content-lg-start">
            <p class="lead fw-normal mb-0 me-3"><br /> 
                <label class="form-label" for="form3Example3">Por favor ingresa tus datos personales!</label>
                <br /></p>
          </div>

          <!-- Email input -->
          <div class="form-outline mb-4">
              <asp:TextBox ID="TextRBoxCorreo" runat="server" class="form-control form-control-lg"
              placeholder="Ingrese un correo válido @" TextMode="Email" required="true" CausesValidation="True"></asp:TextBox>
            <label class="form-label" for="form3Example3">Email </label>
&nbsp;      </div>

          <!-- Password input -->
          <div class="form-outline mb-3">
            <asp:TextBox runat="server" type="password" id="TextBoxRPassword" class="form-control form-control-lg"
              placeholder="Ingrese su contraseña" required="true" TextMode="Password"></asp:TextBox>
            <label class="form-label" for="form3Example4">Contraseña</label>
          </div>

          <div class="form-outline mb-3">


              <asp:TextBox ID="TextBoxNom1" runat="server" class="form-control form-control-lg"
              placeholder="Ingrese su primer Nombre" required="true"></asp:TextBox>
              <label class="form-label" for="form3Example4">Primer Nombre</label>
          </div>
          <div class="form-outline mb-3">
               <asp:TextBox ID="TextBoxNom2" runat="server" class="form-control form-control-lg"
              placeholder="Ingrese su segundo Nombre"></asp:TextBox>
              <label class="form-label" for="form3Example4">Segundo Nombre</label>

          </div>
          <div class="form-outline mb-3">


              <asp:TextBox ID="TextBoxApellido1" runat="server" class="form-control form-control-lg"
              placeholder="Ingrese su primer Nombre" required="true"></asp:TextBox>
              <label class="form-label" for="form3Example4">Primer Apellido</label>
        </div>
          <div class="form-outline mb-3">
               <asp:TextBox ID="TextBoxApellido2" runat="server" class="form-control form-control-lg"
              placeholder="Ingrese su segundo Nombre" required="true"></asp:TextBox>
              <label class="form-label" for="form3Example4">Segundo Apellido</label>

          </div>
     <div class="container">
              <div class="row">
                <div class="col">
                  <label class="form-label" for="form3Example4">Rol</label>
                      <div class="form-outline mb-3">
                          <div class="btn-group mb-3">
                           <asp:DropDownList ID="DropDownListRol" runat="server" AutoPostBack="True" class="btn btn-danger dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false">
                              <asp:ListItem >Usuario</asp:ListItem>
                              <asp:ListItem>Barbero</asp:ListItem>
                          </asp:DropDownList>
                          </div>
                </div>
                </div>
                <div class="col">
                  <div class="form-outline mb-3">
                          <asp:TextBox ID="TextBoxEdad" runat="server" class="form-control form-control-lg"
                          placeholder="Ingrese su Edad" required="true" TextMode="Number"></asp:TextBox>
                          <label class="form-label" for="form3Example4">Edad</label>
                      </div>
                </div>
              </div>
          <!-- Boton entrar -->
          <div class="text-lg-start mt-4 pt-2">
              <asp:Button ID="ButtonRegistrarse" runat="server" Text="Ingresar" class="btn btn-danger btn-lg"
              style="padding-left: 2.5rem; padding-right: 2.5rem;" OnClick="ButtonRegistrarse_Click"/>
          </div>
         <br />
         <br />

              </div>
          </div>
           

      </div>
    </div>
           
           
</section>
    </form>
</body>
</html>
