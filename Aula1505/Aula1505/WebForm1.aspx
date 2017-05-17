<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Aula1505.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
    <asp:Label ID="lblQuantidadeCliques" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <asp:Button ID="btnEnviarCliques" runat="server" Text="Enviar" OnClick="btnEnviarCliques_Click" />
       
</asp:Content>
