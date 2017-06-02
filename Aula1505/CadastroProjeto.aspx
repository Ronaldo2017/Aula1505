<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroProjeto.aspx.cs" Inherits="Aula1505.CadastroProjeto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="updCampos" runat="server">
        <ContentTemplate>
            <div class="panel panel-default">
                <div class="row">
                    <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNome" runat="server" ErrorMessage="Campo Nome Obrigatório" ControlToValidate="txtNome">
                    </asp:RequiredFieldValidator>
                </div>
                <br>
                <div class="row">
                    <asp:Label ID="lblDesxricao" runat="server" Text="Descrição"></asp:Label>
                    <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="row">
                    <asp:Label ID="lblAtivo" runat="server" Text="Ativo"></asp:Label>
                    <asp:CheckBox ID="chkAtivo" runat="server" />
                </div>
                <br>
                <br>
                <br></br>
                <div class="row">
                    <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
                    <asp:Button ID="btnCancelar" runat="server" CausesValidtion="false" OnClick="btnCancelar_Click" Text="Cancelar" />
                </div>

            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
