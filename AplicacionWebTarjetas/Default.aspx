<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplicacionWebTarjetas._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ejemplo WCF</h1>
        <p class="lead">WCF es una tecnologia muy utilizada actualmente</p>
    </div>

    <div class="container">
           <h1>Consulta de emisores</h1>

    </div>
    <asp:TextBox ID="txtBusqueda" Placeholder="Buscar por descripcion"
        runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btn btn-primary " OnClick="btnConsultar_Click" />
    <asp:GridView ID="gvEmisores" runat="server" CssClass="table table-sm" HeaderStyle-BackColor="LightBlue"
        AlternatingRowStyle-BackColor="AliceBlue" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Codigo" DataField="EMI_CODIGO" />
            <asp:BoundField HeaderText="Descripcion" DataField="EMI_DESCRIPCION" />
            <asp:BoundField HeaderText="Prefijo" DataField="EMI_PREFIJO" />
            <asp:BoundField HeaderText="Cantidad Max Digitos" DataField="EMI_NUMERO_MAX_DIGITOS" ItemStyle-HorizontalAlign="Right" />
        </Columns>
    </asp:GridView>
</asp:Content>
