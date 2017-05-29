<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProdutosaspx.aspx.cs" Inherits="Aula2405_EF_MF_MODELFIRST.VIEWS.Produtos.ListaProdutosaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Produtos  </h1>
    <asp:GridView ID="gvwProduto" runat="server"></asp:GridView>

     <h1>Produtos Excluidos</h1>
    <asp:GridView ID="gvwProdutosExcluidas" runat="server"></asp:GridView>


</asp:Content>
