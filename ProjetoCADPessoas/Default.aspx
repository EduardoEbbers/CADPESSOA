<%@ Page Async="true" Title="Inicio" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjetoCADPessoas._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .centerHeaderText th {
            text-align: center !important;
        }
    </style>
    <asp:GridView ID="GridView1"
        ItemType="ProjetoCADPessoas.Models.Dtos.PessoaDto"
        runat="server"
        SelectMethod="GetPessoas"
        AutoGenerateColumns="False"
        DataKeyNames="id_pessoa"
        BackColor="LightGoldenrodYellow"
        BorderColor="Black"
        BorderWidth="1px"
        CellPadding="2"
        GridLines="Vertical"
        Font-Names="Arial"
        Font-Size="Small"
        HeaderStyle-HorizontalAlign="Center"
        HeaderStyle-VerticalAlign="Middle">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <HeaderStyle BackColor="Tan" 
            Font-Bold="True" 
            Height="30" 
            Font-Size="Medium" 
            CssClass="centerHeaderText" />
        <Columns>
            <asp:BoundField DataField="nome" 
                HeaderText="Nome" 
                ItemStyle-Height="25" 
                ItemStyle-HorizontalAlign="Center" 
                ItemStyle-VerticalAlign="Middle" 
                ItemStyle-Width="100" 
                ItemStyle-Font-Bold="true" />
            <asp:BoundField DataField="cpf" 
                HeaderText="CPF" 
                ItemStyle-Height="25" 
                ItemStyle-HorizontalAlign="Center" 
                ItemStyle-VerticalAlign="Middle" 
                ItemStyle-Width="100" />
            <asp:TemplateField ItemStyle-Height="25" 
                ItemStyle-HorizontalAlign="Center" 
                ItemStyle-VerticalAlign="Middle" 
                ItemStyle-Width="160">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkBtnDetalhes" 
                        OnCommand="LinkBtnCommand" 
                        CommandName="Detalhes" 
                        CommandArgument='<%# Eval("id_pessoa") %>' 
                        Text="Detalhes" 
                        runat="server" 
                        Font-Bold="True" 
                        Font-Underline="True" 
                        ForeColor="DarkGoldenrod"></asp:LinkButton>
                    <asp:LinkButton ID="LinkBtnEditar" 
                        OnCommand="LinkBtnCommand" 
                        CommandName="Editar" 
                        CommandArgument='<%# Eval("id_pessoa") %>' 
                        Text="Editar" 
                        runat="server" 
                        Font-Bold="True" 
                        Font-Underline="True" 
                        ForeColor="DarkGoldenrod"></asp:LinkButton>
                    <asp:LinkButton ID="LinkBtnExcluir" 
                        OnCommand="LinkBtnCommand" 
                        CommandName="Excluir" 
                        CommandArgument='<%# Eval("id_pessoa") %>' 
                        Text="Excluir" 
                        runat="server" 
                        Font-Bold="True" 
                        Font-Underline="True" 
                        ForeColor="DarkGoldenrod"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
