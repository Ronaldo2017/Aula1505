<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebProdutos.aspx.cs" Inherits="CadastroMF.Views.Produtos.WebProdutos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="form-group">
                <h1>Produtos</h1>
            </div>
            <div class="form-group">
                <asp:Label ID="lblCodigoP" runat="server" Text="Código"></asp:Label>
                <asp:TextBox ID="txtCodigoP" CssClass="form-control" runat="server" Width="95px" Font-Bold="True"></asp:TextBox>
<%--                <asp:RequiredFieldValidator ID="rfvCodigo" runat="server" ErrorMessage="Preenchimento Obrigatório" ControlToValidate="txtCodigoP"></asp:RequiredFieldValidator>--%>
            </div>

            <div class="form-group">
                <asp:Label ID="lblDescricaoP" runat="server" Text="Descrição"></asp:Label>
                <asp:TextBox ID="txtDescricaoP" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
               <%-- <asp:RequiredFieldValidator ID="rfvDescricao" runat="server" ErrorMessage="Preenchimento Obrigatório" ControlToValidate="txtDescricaoP"></asp:RequiredFieldValidator>--%>
            </div>

            <div class="form-group">
                <asp:Label ID="lblCodigoM" runat="server" Text="Código Máquina"></asp:Label>
                <asp:DropDownList ID="dwlMaquinas" runat="server" Width="100px" DataSourceID="SqlDataSource1" DataTextField="Código" DataValueField="Código" Font-Bold="True"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CadastroMFConnectionString %>" SelectCommand="SELECT [Código], [Descrição] FROM [Maquinas]"></asp:SqlDataSource>
            </div>
            
            <div class="form-group">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" CssClass="btn btn-primary" />
                <asp:Button ID="btnLimpar" runat="server" Text="Limpar Dados" OnClick="btnLimpar_Click" CssClass="btn btn-primary" />
            </div>

            <asp:LinkButton ID="lnkListaProduto" runat="server" OnClick="lnkListaProduto_Click">Lista Produtos</asp:LinkButton>


        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
