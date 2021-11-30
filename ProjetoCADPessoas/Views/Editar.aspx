<%@ Page Title="Editar" Async="true" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Editar.aspx.cs" Inherits="ProjetoCADPessoas.Views.Editar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .headerStyle {
            font-size: large;
        }
        .itemStyle {
            font-size: medium;
        }
        .generalStyle table {
            font-family: Arial;
        }
        .marginTxtBox {
            position: relative;
            right: 235px;
        }
        .marginTxtBox1 {
            position: relative;
            right: 231px;
        }
    </style>
    <asp:FormView ID="FormViewEditar" runat="server" DefaultMode="Insert">
        <InsertItemTemplate>
            <asp:Table ID="TableEditar" runat="server" CssClass="generalStyle">

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Nome"></asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxNome" 
                            CssClass="itemStyle" 
                            runat="server" 
                            Width="300px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="CPF"></asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxCpf" 
                            CssClass="itemStyle" 
                            runat="server" 
                            Width="119px"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell Text="DDD"></asp:TableHeaderCell>
                    <asp:TableHeaderCell Text="Telefone" CssClass="marginTxtBox"></asp:TableHeaderCell>
                    <asp:TableHeaderCell Text="Tipo" CssClass="marginTxtBox1"></asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxDdd" 
                            CssClass="itemStyle" 
                            Width="40px" 
                            runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell></asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxTelefone" 
                            CssClass="marginTxtBox itemStyle" 
                            Width="110px" 
                            runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxTipo" 
                            CssClass="marginTxtBox1 itemStyle" 
                            Width="90px" 
                            runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Endereço"></asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxEndereco" 
                            CssClass="itemStyle" 
                            Width="300px" 
                            runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Número"></asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxNumero" 
                            CssClass="itemStyle" 
                            Width="90px" 
                            runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="CEP"></asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxCep" 
                            CssClass="itemStyle" 
                            Width="90px" 
                            runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Bairro"></asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxBairro" 
                            CssClass="itemStyle" 
                            Width="300px" 
                            runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Cidade"></asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxCidade" 
                            CssClass="itemStyle" 
                            Width="300px" 
                            runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="Estado"></asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxEstado" 
                            CssClass="itemStyle" 
                            Width="300px" 
                            runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:LinkButton ID="LinkBtnEditar"
                            runat="server"
                            Text="Editar"
                            OnClick="LinkBtnEditarClick"
                            Font-Bold="true"
                            Font-Size="Large" />
                    </asp:TableCell><asp:TableCell>
                        <asp:LinkButton ID="LinkBtnVoltar"
                            runat="server"
                            Text="Voltar"
                            PostBackUrl="~/"
                            Font-Bold="true"
                            Font-Size="Large" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </InsertItemTemplate>

        <EditItemTemplate>
            <asp:Table ID="Table1" runat="server">
                
                <asp:TableRow>
                    <asp:TableHeaderCell runat="server" Text="Nome"></asp:TableHeaderCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableHeaderCell runat="server" Text="CPF"></asp:TableHeaderCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableHeaderCell Text="DDD"></asp:TableHeaderCell>
                    <asp:TableHeaderCell Text="-"></asp:TableHeaderCell>
                    <asp:TableHeaderCell Text="Telefone"></asp:TableHeaderCell>
                    <asp:TableHeaderCell Text="Tipo"></asp:TableHeaderCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell></asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableHeaderCell runat="server" Text="Endereço"></asp:TableHeaderCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableHeaderCell runat="server" Text="Número"></asp:TableHeaderCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableHeaderCell runat="server" Text="CEP"></asp:TableHeaderCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableHeaderCell runat="server" Text="Bairro"></asp:TableHeaderCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableHeaderCell runat="server" Text="Cidade"></asp:TableHeaderCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableHeaderCell runat="server" Text="Estado"></asp:TableHeaderCell>
                </asp:TableRow>
                
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:LinkButton ID="LinkButton1"
                            runat="server"
                            Text="Editar"
                            OnClick="LinkBtnEditarClick" />
                    </asp:TableCell><asp:TableCell>
                        <asp:LinkButton ID="LinkButton2"
                            runat="server"
                            Text="Voltar"
                            PostBackUrl="~/Views/Inicio.aspx" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </EditItemTemplate>
    </asp:FormView>
</asp:Content>
