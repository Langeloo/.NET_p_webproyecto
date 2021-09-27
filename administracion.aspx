<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="administracion.aspx.cs" Inherits="Baberia.administracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="Correo" DataSourceID="SqlDataSource1" Height="50px" Width="502px">
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:barberiaConnectionString2 %>" DeleteCommand="DELETE FROM [usuario] WHERE [Correo] = ? AND [Password] = ? AND [Nombre1] = ? AND (([Nombre2] = ?) OR ([Nombre2] IS NULL AND ? IS NULL)) AND [Apellido1] = ? AND [Apellido2] = ? AND [Rol] = ? AND [Edad] = ?" InsertCommand="INSERT INTO [usuario] ([Correo], [Password], [Nombre1], [Nombre2], [Apellido1], [Apellido2], [Rol], [Edad]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:barberiaConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [usuario]" UpdateCommand="UPDATE [usuario] SET [Password] = ?, [Nombre1] = ?, [Nombre2] = ?, [Apellido1] = ?, [Apellido2] = ?, [Rol] = ?, [Edad] = ? WHERE [Correo] = ? AND [Password] = ? AND [Nombre1] = ? AND (([Nombre2] = ?) OR ([Nombre2] IS NULL AND ? IS NULL)) AND [Apellido1] = ? AND [Apellido2] = ? AND [Rol] = ? AND [Edad] = ?" ConflictDetection="CompareAllValues" OldValuesParameterFormatString="original_{0}">
            <DeleteParameters>
                <asp:Parameter Name="original_Correo" Type="String" />
                <asp:Parameter Name="original_Password" Type="String" />
                <asp:Parameter Name="original_Nombre1" Type="String" />
                <asp:Parameter Name="original_Nombre2" Type="String" />
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
                <asp:Parameter Name="original_Nombre2" Type="String" />
                <asp:Parameter Name="original_Apellido1" Type="String" />
                <asp:Parameter Name="original_Apellido2" Type="String" />
                <asp:Parameter Name="original_Rol" Type="String" />
                <asp:Parameter Name="original_Edad" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
