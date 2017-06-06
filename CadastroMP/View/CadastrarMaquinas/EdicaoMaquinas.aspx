﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EdicaoMaquinas.aspx.cs" Inherits="CadastroMP.View.CadastrarMaquinas.EdicaoMaquinas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <h1>Editar Máquinas</h1>
            <div class="form-group">
                <asp:Label ID="lblId" runat="server" Text="ID "></asp:Label>
                <asp:TextBox ID="txtId" runat="server" Width="31px"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblNome" runat="server" Text="Nome "></asp:Label>
                <asp:TextBox ID="txtNome" runat="server" MaxLength="100" Width="204px"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblDescricao" runat="server" Text="Descrição "></asp:Label>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />           
                <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
                <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
            </div>



            <div class="form-group">
                <asp:LinkButton ID="linkVoltar" runat="server" OnClick="linkVoltar_Click">Voltar</asp:LinkButton>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
