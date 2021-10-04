<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="citasCliente.aspx.cs" Inherits="Baberia.citasCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="all-page-bar">
			<div class="container">
				<div class="row">
					<div class="col-xs-12 col-sm-12 col-md-12">
						<div class="title title-1 text-center">
							<div class="much">
								<img src="images/logooo.png" alt=""/>
							</div>
							
							<div class="title--heading">
								<h1>AGENDAR CITA</h1>
							</div>
							<div class="clearfix"></div>
							
							<ol class="breadcrumb">
								<li>Bienvenid@</li>
								<li class="active" id="NombreUser" runat="server"></li>
							</ol>
						</div>
						<!-- .title end -->
					</div>
				</div>
			</div>
		</div>

	<!-- Page Content -->
	<div id="page-content-wrapper">
		<div id="appointment" class="section wb">
			<div class="container">
				<div class="section-title row text-center">
					<div class="col-md-8 offset-md-2">
						<small>RECUERDA LOS HORARIOS DE ATENCIÓN DE 11AM - 8PM</small>
						<h3>AGENDAR CITA</h3>
					</div>
				</div><!-- end title -->

				<div class="row">
					<div class="col-lg-12">
						<div class="contact_form">
							<div id="message"></div>
							
								<fieldset class="row row-fluid">
									<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">

										<asp:TextBox ID="TextBox1" runat="server" class="form-control" text="Seleccione por favor el barbero con el que desea la cita" ReadOnly="True"></asp:TextBox>
										
									</div>
									<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12"> 
									<asp:DropDownList ID="DropDownListBarberos" runat="server" class="form-control" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Nombres" DataValueField="CorreoB"></asp:DropDownList>
									    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BarberiaConnectionString2 %>" SelectCommand="SELECT [Nombres], [Apellidos], [CorreoB] FROM [Barberos]"></asp:SqlDataSource>
									</div>
									<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">


										<asp:TextBox ID="TextBox2" runat="server" class="form-control" text="Seleccione la fecha de la cita" ReadOnly="True"></asp:TextBox>
									</div>
									<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
										<asp:TextBox ID="TextBoxFecha" runat="server" TextMode="Date" class="form-control" required="true"></asp:TextBox>
									</div>
									<div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
										<asp:DropDownList ID="DropDownListHora" runat="server" class="form-control">
                                            <asp:ListItem Value="11:00:00">11 am</asp:ListItem>
                                            <asp:ListItem Value="12:00:00">12 mm</asp:ListItem>
                                            <asp:ListItem Value="13:00:00">1 pm</asp:ListItem>
                                            <asp:ListItem Value="14:00:00">2 pm</asp:ListItem>
                                            <asp:ListItem Value="15:00:00">3 pm</asp:ListItem>
                                            <asp:ListItem Value="16:00:00">4 pm</asp:ListItem>
                                            <asp:ListItem Value="17:00:00">5 pm</asp:ListItem>
                                            <asp:ListItem Value="18:00:00">6 pm</asp:ListItem>
                                            <asp:ListItem Value="19:00:00">7 pm</asp:ListItem>
                                            <asp:ListItem Value="20:00:00">8 pm</asp:ListItem>
                                        </asp:DropDownList>
									</div>
									<div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
									
									<div class="form-btn text-center">
										
										<asp:Button ID="ButtonCita" runat="server" class="btn btn-light btn-radius btn-brd grd1 btn-block subt" Text="AGENDAR CITA" OnClick="ButtonCita_Click" />
									</div>
								    </div>
								</fieldset>
							
						</div>

					


					</div><!-- end col -->
				</div><!-- end row -->
			</div><!-- end container -->
		</div><!-- end section -->
		</div>
	<div class="contact_form" id="TABLA">
							
							
								<fieldset class="row row-fluid">

									<div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
									
									<div class="form-btn text-center">
										
										<asp:Button ID="ButtonVer" runat="server" class="btn btn-light btn-radius btn-brd grd1 btn-block subt" Text="VER MIS CITAS" OnClick="ButtonVerCitas_Click" />
									</div>
								    </div>
									<div class="col-lg-12 col-md-12 col-sm-12 col-xs-12" id="Ver" runat ="server">
                                        <asp:GridView ID="GridViewCita" runat="server"></asp:GridView>
									</div>
									
								</fieldset>
							
						</div>

</asp:Content>
