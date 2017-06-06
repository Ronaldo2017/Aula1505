﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrarMaquinas.aspx.cs" Inherits="CadastroMP.View.Cadastrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <h1>Cadastro Máquinas</h1>
            <div class="form-group">
                <asp:Label ID="lblNome" runat="server" Text="Nome "></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblDescricao" runat="server" Text="Descrição "></asp:Label>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />

            </div>
            <asp:LinkButton ID="lnkListaMaquinas" runat="server" OnClick="lnkListaMaquinas_Click">Lista Máquinas</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lnkEditarMaquinas" runat="server" OnClick="lnkEditarMaquinas_Click">Editar Máquinas</asp:LinkButton>
        </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>
