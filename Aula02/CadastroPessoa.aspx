<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroPessoa.aspx.cs" Inherits="Aula02.CadastroPessoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cadastro de Pessoa</h1>
    <p>Id:
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
    </p>
    Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
<br />
E-mail:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
<br />
Sexo:<asp:RadioButtonList ID="rblSexo" runat="server" RepeatDirection="Horizontal">
    <asp:ListItem>Mano</asp:ListItem>
    <asp:ListItem>Mina</asp:ListItem>
</asp:RadioButtonList>
<br />
Estado Civil:<asp:DropDownList ID="dplEstadoCivil" runat="server" Width="138px">
    <asp:ListItem Value="1">Casado</asp:ListItem>
    <asp:ListItem Value="2">Solteiro</asp:ListItem>
</asp:DropDownList>
<br />
    DropDownList ID
Tipo de contato:
<asp:CheckBox ID="chkEmail" runat="server" Text="E-mail" />
<asp:CheckBox ID="chkSms" runat="server" Text="SMS" />
<br />
Foto:<asp:FileUpload ID="FileUpload1" runat="server" />
<br />
<asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
<br />
<asp:GridView ID="GridView1" runat="server" Width="654px" CellPadding="4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField HeaderText="ID" />
        <asp:BoundField HeaderText="Nome" />
        <asp:BoundField HeaderText="E-mail" />
        <asp:BoundField HeaderText="Sexo" />
        <asp:BoundField HeaderText="Estado Civil" />
        <asp:BoundField HeaderText="Tipo de Contato" />
        <asp:ImageField HeaderText="Foto">
        </asp:ImageField>
    </Columns>
    <EditRowStyle BackColor="#7C6F57" />
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F8FAFA" />
    <SortedAscendingHeaderStyle BackColor="#246B61" />
    <SortedDescendingCellStyle BackColor="#D4DFE1" />
    <SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView>
</asp:Content>
