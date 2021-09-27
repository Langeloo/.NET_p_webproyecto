<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="administracion.aspx.cs" Inherits="Baberia.administracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="Correo" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="Correo" HeaderText="Correo" ReadOnly="True" SortExpression="Correo" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="Nombre1" HeaderText="Nombre1" SortExpression="Nombre1" />
                <asp:BoundField DataField="Nombre2" HeaderText="Nombre2" SortExpression="Nombre2" />
                <asp:BoundField DataField="Apellido1" HeaderText="Apellido1" SortExpression="Apellido1" />
                <asp:BoundField DataField="Apellido2" HeaderText="Apellido2" SortExpression="Apellido2" />
                <asp:BoundField DataField="Rol" HeaderText="Rol" SortExpression="Rol" />
                <asp:BoundField DataField="Edad" HeaderText="Edad" SortExpression="Edad" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:barberiaConnectionString %>" DeleteCommand="DELETE FROM usuario" InsertCommand="INSERT INTO usuario(Correo, Password, Nombre1, Nombre2, Apellido1, Apellido2, Rol, Edad) VALUES (Correo, Password, Nombre1, Nombre2, Apellido1, Apellido2, Rol, Edad)" ProviderName="<%$ ConnectionStrings:barberiaConnectionString.ProviderName %>" SelectCommand="SELECT Correo, Password, Nombre1, Nombre2, Apellido1, Apellido2, Rol, Edad FROM usuario" UpdateCommand="UPDATE usuario SET Correo =, Password =, Nombre1 =, Nombre2 =, Apellido1 =, Apellido2 =, Rol =, Edad ="></asp:SqlDataSource>
    </p>
</asp:Content>
