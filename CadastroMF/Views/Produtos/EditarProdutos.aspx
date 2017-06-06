<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarProdutos.aspx.cs" Inherits="CadastroMF.Views.Produtos.EditarProdutos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
        <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" CssClass="btn btn-primary" />
    </div>
</asp:Content>
