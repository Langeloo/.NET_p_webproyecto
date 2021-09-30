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
								<img src="uploads/mustache.png" alt=""/>
							</div>
							
							<div class="title--heading">
								<h1>Contact</h1>
							</div>
							<div class="clearfix"></div>
							
							<ol class="breadcrumb">
								<li>Bienvenido</li>
								<li class="active" id="NombreUser" runat="server"></li>
							</ol>
						</div>
						<!-- .title end -->
					</div>
				</div>
			</div>
		</div>
    <asp:Button ID="Button1" runat="server" Text="Button" />


	

	

	

</asp:Content>
