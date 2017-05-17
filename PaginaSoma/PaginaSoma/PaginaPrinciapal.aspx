<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaPrinciapal.aspx.cs" Inherits="PaginaSoma.PaginaPrinciapal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            <div class="row">
            <asp:Button ID="btnSoma" runat="server" Text="+" />
            <asp:Button ID="btnIgual" runat="server" Text="=" />
            </div>



        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
