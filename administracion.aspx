<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="administracion.aspx.cs" Inherits="Baberia.administracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:DetailsView ID="DetailsView1" runat="server" DataSourceID="SqlDataSource1" Height="50px" Width="125px" AllowPaging="True">
            <Fields>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:barberiaConnectionString3 %>" DeleteCommand="DELETE FROM usuario WHERE Correo = ?" InsertCommand="INSERT INTO usuario (Correo, Password, Nombre1, Nombre2, Apellido1, Apellido2, Rol, Edad) VALUES (?, ?, ?, ?, ?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" ProviderName="<%$ ConnectionStrings:barberiaConnectionString3.ProviderName %>" SelectCommand="SELECT * FROM usuario" UpdateCommand="UPDATE usuario SET Password = ?, Nombre1 = ?, Nombre2 = ?, Apellido1 = ?, Apellido2 = ?, Rol = ?, Edad = ? WHERE Correo = ?">          
            <DeleteParameters>
                <asp:Parameter Name="original_Correo" Type="String" />
                <asp:Parameter Name="original_Password" Type="String" />
                <asp:Parameter Name="original_Nombre1" Type="String" />
                <asp:Parameter Name="original_Nombre2" Type="String" />
                <asp:Parameter Name="original_Apellido1" Type="String" />
                <asp:Parameter Name="original_Apellido2" Type="String" />
                <asp:Parameter Name="original_Rol" Type="String" />
                <asp:Parameter Name="original_Edad" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Correo" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="Nombre1" Type="String" />
                <asp:Parameter Name="Nombre2" Type="String" />
                <asp:Parameter Name="Apellido1" Type="String" />
                <asp:Parameter Name="Apellido2" Type="String" />
                <asp:Parameter Name="Rol" Type="String" />
                <asp:Parameter Name="Edad" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="Nombre1" Type="String" />
                <asp:Parameter Name="Nombre2" Type="String" />
                <asp:Parameter Name="Apellido1" Type="String" />
                <asp:Parameter Name="Apellido2" Type="String" />
                <asp:Parameter Name="Rol" Type="String" />
                <asp:Parameter Name="Edad" Type="Int32" />
                <asp:Parameter Name="original_Correo" Type="String" />
                <asp:Parameter Name="original_Password" Type="String" />
                <asp:Parameter Name="original_Nombre1" Type="String" />
                <asp:Parameter Name="original_Nombre2" Type="String" />
                <asp:Parameter Name="original_Apellido1" Type="String" />
                <asp:Parameter Name="original_Apellido2" Type="String" />
                <asp:Parameter Name="original_Rol" Type="String" />
                <asp:Parameter Name="original_Edad" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
