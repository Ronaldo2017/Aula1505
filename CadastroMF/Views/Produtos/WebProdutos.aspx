<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebProdutos.aspx.cs" Inherits="CadastroMF.Views.Produtos.WebProdutos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="form-group">
                <h1>Produtos</h1>
            </div>
            <div class="form-group">
                <asp:Label ID="lblCodigo" runat="server" Text="Código"></asp:Label>
                <asp:TextBox ID="txtCodigo" CssClass="form-control" runat="server" Width="200px" Font-Bold="True"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="rfvCodigo" runat="server" ErrorMessage="Preenchimento Obrigatório" ControlToValidate="txtCodigoP"></asp:RequiredFieldValidator>--%>
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

            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnLimpar" runat="server" Text="Limpar Dados" OnClick="btnLimpar_Click" CssClass="btn btn-primary" />
            </div>
                    <div class="form-group">
                        <asp:LinkButton ID="lnkListaProduto" runat="server" OnClick="lnkListaProduto_Click">Lista Produtos</asp:LinkButton>
                    </div>

            <div class="form-group">
                <asp:LinkButton ID="lnkEditaProduto" runat="server" OnClick="lnkEditarProduto_Click">Editar Produtos</asp:LinkButton>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
