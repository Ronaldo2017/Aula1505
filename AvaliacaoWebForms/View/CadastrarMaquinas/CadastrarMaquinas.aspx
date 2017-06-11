<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrarMaquinas.aspx.cs" Inherits="AvaliacaoWebForms.View.CadastrarMaquinas.CadastrarMaquinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="col-lg-4"></div>
                <div class="col-lg-4">
                    <h1>Cadastro Máquinas</h1>
                    <div class="form-group">
                        <asp:Label ID="lblNome" runat="server" Text="Nome "></asp:Label>
                        <asp:TextBox ID="txtNome" CssClass="form-control" runat="server" Font-Bold="True"></asp:TextBox>

                    </div>
                    <%--<asp:RequiredFieldValidator runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtNome"></asp:RequiredFieldValidator>--%>
                    <div class="form-group">
                        <asp:Label ID="lblDescricao" runat="server" Text="Descrição "></asp:Label>
                        <asp:TextBox ID="txtDescricao" CssClass="form-control" runat="server" TextMode="MultiLine" Font-Bold="True"></asp:TextBox>

                    </div>

                    <div class="form-group">
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-primary" OnClick="btnSalvar_Click" OnClientClick="return confirm('Salvo com sucesso');" />

                        <asp:Button ID="btnLimpar" runat="server" Text="Limpar" CssClass="btn btn-primary" OnClick="btnLimpar_Click" />

                    </div>
                 
                    <div class="form-group">
                        <asp:LinkButton ID="lnkListarMaquinas" runat="server" OnClick="lnkListaMaquinas_Click">Lista Máquinas</asp:LinkButton>
                    </div>
                    <br />

                    <div class="form-group">
                        <asp:LinkButton ID="lnkEditarMaquinas" runat="server" OnClick="lnkEditarMaquinas_Click">Editar Máquinas</asp:LinkButton>
                    </div>

                </div>
            </div>
       
        </ContentTemplate>

    </asp:UpdatePanel>

</asp:Content>
