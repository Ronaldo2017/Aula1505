<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaPrinciapal.aspx.cs" Inherits="PaginaSoma.PaginaPrinciapal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate><br />
            <div class="row">
                <asp:TextBox ID="txtNum1" runat="server" Width="33px" ></asp:TextBox>
                <asp:TextBox ID="txtNum2" runat="server" Width="33px"  ></asp:TextBox>
            </div><br />
            <div class="row">
                <asp:Button ID="btnSoma" runat="server" Text="+" OnClick="btnSoma_Click" />
                <asp:Button ID="btnIgual" runat="server" Text="=" OnClick="btnIgual_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
