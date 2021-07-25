<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmConsultarTarjetaValidez.aspx.cs" Inherits="AplicacionWebTarjetas.Views.frmConsultarTarjetaValidez" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div class="container">
    <h1>Consultar Válidez de Tarjetas por Numero de Tarjeta</h1>

    </div>
    <asp:TextBox ID="txtBusqueda" Placeholder="Digite su numero tarjeta completo"
        runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btn btn-primary " OnClick="btnConsultar_Click" />
            <br />
            <br />
    <div>

    <asp:Label ID="lblEstado" runat="server" Text="" CssClass="form-control"></asp:Label>

    </div>
</asp:Content>
