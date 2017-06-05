<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebMaquinas.aspx.cs" Inherits="CadastroMF.Views.MaquinasEProdutos.ListaMaquinasEProdutos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="form-group">
                <h1>Máquinas</h1>
            </div>
            <div class="form-group">
                <asp:Label ID="lblCodigoM" runat="server" Text="Código"></asp:Label>
                <asp:TextBox ID="txtCodigoM" CssClass="form-control" runat="server" Width="95px" Font-Bold="True"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="rfvCodigo" runat="server" ErrorMessage="Preenchimento Obrigatório" ControlToValidate="txtCodigoM"></asp:RequiredFieldValidator>--%>
            </div>

            <div class="form-group">
                <asp:Label ID="lblDescricaoM" runat="server" Text="Descrição"></asp:Label>
                <asp:TextBox ID="txtDescricaoM" CssClass="form-control" runat="server" TextMode="MultiLine" Font-Bold="True"></asp:TextBox>
                <%--                <asp:RequiredFieldValidator ID="rfvDescricao" runat="server" ErrorMessage="Preenchimento Obrigatório" ControlToValidate="txtDescricaoM"></asp:RequiredFieldValidator>--%>
            </div>

            <div class="form-group">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" CssClass="btn btn-primary" />
                <asp:Button ID="btnLimpar" runat="server" Text="Limpar Dados" OnClick="btnLimpar_Click" CssClass="btn btn-primary" />
            </div>
            <asp:LinkButton ID="LinkListaMaquinas" runat="server" OnClick="LinkListaMaquinas_Click">Lista Máquinas</asp:LinkButton>

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
