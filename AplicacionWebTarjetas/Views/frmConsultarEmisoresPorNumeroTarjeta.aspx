<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmConsultarEmisoresPorNumeroTarjeta.aspx.cs" Inherits="AplicacionWebTarjetas.Views.frmConsultarEmisoresPorNumeroTarjeta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
    <h1>Consulta de Emisores por Numero de Tarjeta</h1>

    </div>
    <asp:TextBox ID="txtBusqueda" Placeholder="Digite los primeros numeros de su tarjeta"
        runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btn btn-primary " OnClick="btnConsultar_Click" />
    <asp:GridView ID="gvEmisores" runat="server" CssClass="table table-sm" HeaderStyle-BackColor="LightBlue"
        AlternatingRowStyle-BackColor="AliceBlue" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Nombre de Emisor" DataField="EMI_DESCRIPCION" />
            <asp:BoundField HeaderText="Cantidad Max Digitos" DataField="EMI_NUMERO_MAX_DIGITOS" ItemStyle-HorizontalAlign="Right" />
        </Columns>
    </asp:GridView>

</asp:Content>
