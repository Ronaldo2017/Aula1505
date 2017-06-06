<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrarProdutos.aspx.cs" Inherits="AvaliacaoWebForms.View.CadastrarProdutos.CadastrarProdutos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <h1>Cadastrar Produtos</h1>
            <div class="form-group">
                <asp:Label ID="lblNomeP" runat="server" Text="Nome "></asp:Label>
                <asp:TextBox ID="txtNomeP" CssClass="form-control" runat="server"></asp:TextBox>
            </div>


            <div class="form-group">
                <asp:Label ID="lblDescricaoP" runat="server" Text="Descrição "></asp:Label>
                <asp:TextBox ID="txtDescricaoP" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblNome" runat="server" Text="Máquinas"></asp:Label>
                <asp:DropDownList ID="dwlMaquinas" CssClass="form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nome" DataValueField="Nome"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CadastroConnectionString %>" SelectCommand="SELECT [Nome], [Descricao] FROM [Maquinas]"></asp:SqlDataSource>
            </div>

            <div class="form-group">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
            </div>

            <div class="form-group">
                <asp:LinkButton ID="lnkListaProdutos" runat="server" OnClick="lnkListaProdutos_Click">Lista Produtos</asp:LinkButton>
            </div>
            <br />
            <div class="form-group">
                <asp:LinkButton ID="lnkEditarProdutos" runat="server" OnClick="lnkEditarProdutos_Click">Editar Produtos</asp:LinkButton>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
