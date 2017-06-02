<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Aula2405_EF_MF_MODELFIRST.VIEWS.Categorias.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
    <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>


    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />

    <%--<h1>Categorias Ativas</h1>
    <asp:GridView ID="gvwCategoria" runat="server"></asp:GridView>

     <h1>Categorias Excluidas</h1>
    <asp:GridView ID="gvCategoriasExcluidas" runat="server"></asp:GridView>--%>

</asp:Content>
