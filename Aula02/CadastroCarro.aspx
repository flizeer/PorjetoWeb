<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCarro.aspx.cs" Inherits="Aula02.CadastroCarro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cadastro de Carro</h1>
    <p>Marca:
        <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
    </p>
    <p>Modelo:
        <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
    </p>
    <p>Ano:<asp:TextBox ID="txtAno" runat="server"></asp:TextBox>
    </p>
    <p>Cor:<asp:TextBox ID="txtCor" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
    </p>
</asp:Content>
