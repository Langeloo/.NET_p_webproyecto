<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="AcercaDeNosotros.aspx.cs" Inherits="Baberia.AcercaDeNosotros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="nombre1" HeaderText="nombre1" SortExpression="nombre1" />
        <asp:BoundField DataField="nombre2" HeaderText="nombre2" SortExpression="nombre2" />
        <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
        <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
        <asp:BoundField DataField="n_identificacion" HeaderText="n_identificacion" SortExpression="n_identificacion" />
        <asp:BoundField DataField="correo" HeaderText="correo" SortExpression="correo" />
        <asp:BoundField DataField="clave" HeaderText="clave" SortExpression="clave" />
        <asp:BoundField DataField="sexo" HeaderText="sexo" SortExpression="sexo" />
        <asp:BoundField DataField="fecha_nac" HeaderText="fecha_nac" SortExpression="fecha_nac" />
        <asp:CheckBoxField DataField="estado" HeaderText="estado" SortExpression="estado" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bd_tallerjavawebConnectionString %>" ProviderName="<%$ ConnectionStrings:bd_tallerjavawebConnectionString.ProviderName %>" SelectCommand="select * from tb_usuario"></asp:SqlDataSource>
</asp:Content>
