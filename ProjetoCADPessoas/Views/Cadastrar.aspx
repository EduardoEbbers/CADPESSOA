<%@ Page Title="Cadastrar" Async="true"  Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Cadastrar.aspx.cs" Inherits="ProjetoCADPessoas.Views.Cadastrar" %>

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
    <asp:FormView ID="FormViewCadastrar" DefaultMode="Insert" runat="server">
        <InsertItemTemplate>
            <asp:Table ID="TableCadastrar" CssClass="generalStyle" runat="server">

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell Text="Nome" runat="server"></asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxNome" 
                            CssClass="itemStyle" 
                            runat="server" 
                            Width="300px">
                        </asp:TextBox>
                    
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="TxtBoxNome" ID="rfvNome" Font-Bold="true" ErrorMessage="Nome é Obrigatório! Máx: 256." ForeColor="Red"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow CssClass="headerStyle">
                    <asp:TableHeaderCell runat="server" Text="CPF"></asp:TableHeaderCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxCpf" 
                            CssClass="itemStyle" 
                            Width="119px" 
                            runat="server">
                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                 <asp:TableRow>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="TxtBoxCpf" ID="rfvCpf" Font-Bold="true" ErrorMessage="CPF é Obrigatório (Apenas dígitos)! Máx: 11 dígitos." ForeColor="Red"></asp:RequiredFieldValidator>
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
                            runat="server">
                        </asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxTelefone" 
                            CssClass="marginTxtBox itemStyle" 
                            Width="99px" 
                            runat="server">
                        </asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TxtBoxTipo" 
                            CssClass="marginTxtBox1 itemStyle" 
                            Width="90px" 
                            runat="server">
                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="TxtBoxDdd" ID="rfvDdd" Font-Bold="true" ErrorMessage="DDD é Obrigatório! Máx: 2." ForeColor="Red"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="TxtBoxTelefone" ID="rfvTelefone" Font-Bold="true" ErrorMessage="Telefone é Obrigatório! Máx: 10 dígitos." ForeColor="Red"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="TxtBoxTipo" ID="rfvTipo" Font-Bold="true" ErrorMessage="Tipo é Obrigatório! Máx: 10." ForeColor="Red"></asp:RequiredFieldValidator>
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
                            runat="server">
                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="TxtBoxEndereco" ID="rfvLogradouro" Font-Bold="true" ErrorMessage="Logradouro é Obrigatório! Máx: 256." ForeColor="Red"></asp:RequiredFieldValidator>
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
                            runat="server">
                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="TxtBoxNumero" ID="rfvNumero" Font-Bold="true" ErrorMessage="Número é Obrigatório! Máx: 4 dígitos." ForeColor="Red" />
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
                            runat="server">
                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="TxtBoxCep" ID="rfvCep" Font-Bold="true" ErrorMessage="CEP é Obrigatório (apenas dígitos)! Máx: 8 dígitos." ForeColor="Red"></asp:RequiredFieldValidator>
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
                            runat="server">
                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="TxtBoxBairro" ID="rfvBairro" Font-Bold="true" ErrorMessage="Bairro é Obrigatório! Máx: 50 caracteres." ForeColor="Red"></asp:RequiredFieldValidator>
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
                            runat="server">
                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="TxtBoxCidade" ID="rfvCidade" Font-Bold="true" ErrorMessage="Cidade é Obrigatório! Máx: 30 caracteres." ForeColor="Red"></asp:RequiredFieldValidator>
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
                            runat="server">
                        </asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="TxtBoxEstado" ID="rfvEstado" Font-Bold="true" ErrorMessage="Estado é Obrigatório! Máx: 20 caracteres." ForeColor="Red"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:LinkButton ID="LinkBtnCadastrar"
                            runat="server"
                            Text="Cadastrar"
                            OnClick="LinkBtnCadastrarClick"
                            Font-Bold="true"
                            Font-Size="Large" />
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:LinkButton ID="LinkBtnVoltar"
                            runat="server"
                            Text="Voltar"
                            CausesValidation="false"
                            OnClick="LinkBtnVoltarClick"
                            Font-Bold="true"
                            Font-Size="Large" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
