<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SegundaPaginaaspx.aspx.cs" Inherits="PaginaSoma.SegundaPaginaaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="row">
                <asp:TextBox ID="txtSoma1" runat="server" Width="33px"  ></asp:TextBox>
                <asp:Label ID="lblSoma" runat="server" Width="16px" Text="+" style="text-align:center;" ></asp:Label>
                <asp:TextBox ID="txtSoma2" runat="server" Width="33px"></asp:TextBox>
                <asp:Button ID="btnIgualSoma" runat="server" Text="=" />
                <asp:TextBox ID="txtIgualSoma" runat="server" Width="33px"></asp:TextBox>
            </div>
            <div class="row">
                <asp:TextBox ID="txtSub1" runat="server" Width="33px"></asp:TextBox>
                <asp:Label ID="lblSub" runat="server" Width="16px" Text="-" style="text-align:center;" ></asp:Label>
                <asp:TextBox ID="txtSub2" runat="server" Width="33px"></asp:TextBox>
                <asp:Button ID="btnIgualSub" runat="server" Text="=" />
                <asp:TextBox ID="txtIgualSub" runat="server" Width="33px"></asp:TextBox>
            </div>
            <div class="row">
                <asp:TextBox ID="txtDiv1" runat="server" Width="33px"></asp:TextBox>
                <asp:Label ID="lblDiv" runat="server" Width="16px" Text="/" style="text-align:center;" ></asp:Label>
                <asp:TextBox ID="txtDiv2" runat="server" Width="33px"></asp:TextBox>
                <asp:Button ID="btnIgualDiv" runat="server"  Text="=" />
                <asp:TextBox ID="txtIgualDiv" runat="server" Width="33px"></asp:TextBox>
            </div>
            <div class="row">
                <asp:TextBox ID="txtMult1" runat="server" Width="33px"></asp:TextBox>
                <asp:Label ID="lblMult" runat="server" Width="16px" Text="x" style="text-align:center;" ></asp:Label>
                <asp:TextBox ID="txtMult2" runat="server" Width="33px"></asp:TextBox>
                <asp:Button ID="btnIgualMult" runat="server"  Text="=" />
                <asp:TextBox ID="txtIgualMult" runat="server" Width="33px"></asp:TextBox>
            </div><br />
            <div class="row">
                <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
