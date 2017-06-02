<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebMaquinas.aspx.cs" Inherits="CadastroMF.Views.MaquinasEProdutos.ListaMaquinasEProdutos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Máquinas</h1>
    <div class="form-group">

        <asp:Label ID="lblCodigoM" runat="server" Text="Código"></asp:Label>

        <asp:TextBox ID="txtCodigoM" CssClass="form-control" runat="server" Width="95px"></asp:TextBox>

    </div>

    <div class="form-group">

        <asp:Label ID="lblDescricaoM" runat="server" Text="Descrição"></asp:Label>

        <asp:TextBox ID="txtDescricaoM" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>

    </div>

    <div class="form-group">

        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" CssClass="btn btn-primary" />

        
    </div>
</asp:Content>
