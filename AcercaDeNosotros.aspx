<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="AcercaDeNosotros.aspx.cs" Inherits="Baberia.AcercaDeNosotros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Correo" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:BoundField DataField="Correo" HeaderText="Correo" ReadOnly="True" SortExpression="Correo" />
        <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
        <asp:BoundField DataField="Nombre1" HeaderText="Nombre1" SortExpression="Nombre1" />
        <asp:BoundField DataField="Nombre2" HeaderText="Nombre2" SortExpression="Nombre2" />
        <asp:BoundField DataField="Apellido1" HeaderText="Apellido1" SortExpression="Apellido1" />
        <asp:BoundField DataField="Apellido2" HeaderText="Apellido2" SortExpression="Apellido2" />
        <asp:BoundField DataField="Rol" HeaderText="Rol" SortExpression="Rol" />
        <asp:BoundField DataField="Edad" HeaderText="Edad" SortExpression="Edad" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:barberiaConnectionString %>" ProviderName="<%$ ConnectionStrings:barberiaConnectionString.ProviderName %>" SelectCommand="SELECT Correo, Password, Nombre1, Nombre2, Apellido1, Apellido2, Rol, Edad FROM usuario"></asp:SqlDataSource>
</asp:Content>
