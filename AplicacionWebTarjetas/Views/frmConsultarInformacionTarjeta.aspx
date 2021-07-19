<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmConsultarInformacionTarjeta.aspx.cs" Inherits="AplicacionWebTarjetas.Views.ConsultarInformacionTarjeta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container">
    <h1>Consultar Informacion de Tarjetas por Numero de Tarjeta</h1>

    </div>
    <asp:TextBox ID="txtBusqueda" Placeholder="Digite su numero tarjeta"
        runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btn btn-primary " OnClick="btnConsultar_Click" />
    <asp:GridView ID="gvEmisores" runat="server" CssClass="table table-sm" HeaderStyle-BackColor="LightBlue"
        AlternatingRowStyle-BackColor="AliceBlue" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Numero de Tarjeta" DataField="TAR_NUMERO" />
            <asp:BoundField HeaderText="Tipo" DataField="TAR_TIPO" />
            <asp:BoundField HeaderText="Saldo" DataField="TAR_SALDO" ItemStyle-HorizontalAlign="Right" />
            <asp:BoundField HeaderText="Fecha de Emision" DataField="TAR_FECHA_EMISION" />
            <asp:BoundField HeaderText="Fecha de Vencimiento" DataField="TAR_FECHA_VENCIMIENTO" />
            <asp:BoundField HeaderText="Nombre del Cliente" DataField="TAR_NOMBRE_CLIENTE" />
        </Columns>
        </asp:GridView>

</asp:Content>
