<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaPrinciapal.aspx.cs" Inherits="PaginaSoma.PaginaPrinciapal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate><br />
            <h1>
                <asp:Label ID="lblNome" runat="server" Text="Label"></asp:Label>
            </h1>

            <asp:Label ID="lblValor1" runat="server" Text="Valor 1"></asp:Label>
            <asp:TextBox ID="txtValor1" runat="server" width="33px"></asp:TextBox>
            <asp:Label ID="lblValor2" runat="server" Text="Valor 2"></asp:Label>
            <asp:TextBox ID="txtValor2" runat="server" width="33px"></asp:TextBox>
            <asp:Label ID="lblIgual" runat="server" Text="="></asp:Label>
            <asp:TextBox ID="txtResultado" runat="server" width="33px"></asp:TextBox>
            <asp:Button ID="btnMais" CssClass="btn btn-default" runat="server" Text="+" OnClick="btnMais_Click" />
            <asp:Button ID="btnIgual" CssClass="btn btn-primary" runat="server" Text="=" OnClick="btnIgual_Click" />

             
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
