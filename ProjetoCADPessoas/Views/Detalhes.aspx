<%@ Page Title="Detalhes" Async="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="ProjetoCADPessoas.Views.Detalhes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .headerStyle th {
            font-size: medium;
            padding-right: 10px;
        }
        .itemStyle td {
            font-size: small;
        }
        .generalStyle table {
            font-family: Arial;
        }
    </style>
    <asp:FormView ID="FormViewDetalhes" runat="server" DefaultMode="Insert">

        <InsertItemTemplate>
            <asp:Table ID="TableDetalhes" runat="server" CssClass="generalStyle">
                
                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Nome: "></asp:TableHeaderCell>
                    <asp:TableCell>
                        <asp:Label ID="LblNome" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="CPF: "></asp:TableHeaderCell>
                    <asp:TableCell>
                        <asp:Label ID="LblCpf" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell Text="Telefone: "></asp:TableHeaderCell>
                    <asp:TableCell>
                        <asp:Label ID="LblDddTelefone" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell Text="Tipo: "></asp:TableHeaderCell>
                    <asp:TableCell>
                        <asp:Label ID="LblTipo" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Endereço: "></asp:TableHeaderCell>
                    <asp:TableCell>
                        <asp:Label ID="LblEndereco" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Número: "></asp:TableHeaderCell>
                    <asp:TableCell>
                        <asp:Label ID="LblNumero" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="CEP: "></asp:TableHeaderCell>
                    <asp:TableCell>
                        <asp:Label ID="LblCep" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Bairro: "></asp:TableHeaderCell>
                    <asp:TableCell>
                        <asp:Label ID="LblBairro" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Cidade: "></asp:TableHeaderCell>
                    <asp:TableCell>
                        <asp:Label ID="LblCidade" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Estado: "></asp:TableHeaderCell>
                    <asp:TableCell>
                        <asp:Label ID="LblEstado" runat="server"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:LinkButton ID="LinkBtnVoltar"
                            runat="server"
                            Text="Voltar"
                            PostBackUrl="~/"
                            Font-Bold="true"
                            Font-Size="Medium" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
