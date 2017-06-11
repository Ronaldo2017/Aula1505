<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrarProdutos.aspx.cs" Inherits="AvaliacaoWebForms.View.CadastrarProdutos.CadastrarProdutos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="col-lg-4"></div>
                <div class="col-lg-4">
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
                         <asp:DropDownList ID="dwlMaquinas" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nome" DataValueField="id" Font-Bold="True"></asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CadastroConnectionString %>" SelectCommand="SELECT [Nome], [Id] FROM [Maquinas]"></asp:SqlDataSource>
                    </div>
                   

                    <div class="btn-group">
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-primary" OnClick="btnSalvar_Click" OnClientClick="return confirm('Salvo com sucesso');" />
                    </div>

                    <div class="btn-group">
                        <asp:Button ID="btnLimpar" runat="server" Text="Limpar" CssClass="btn btn-primary" OnClick="btnLimpar_Click" />
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:LinkButton ID="lnkListaProdutos" runat="server" OnClick="lnkListaProdutos_Click">Lista Produtos</asp:LinkButton>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:LinkButton ID="lnkEditarProdutos" runat="server" OnClick="lnkEditarProdutos_Click">Editar Produtos</asp:LinkButton>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
