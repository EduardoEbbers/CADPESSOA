using Ninject;
using Ninject.Web;
using ProjetoCADPessoas.Controllers.Interfaces;
using ProjetoCADPessoas.Models.Dtos;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoCADPessoas.Views
{
    public partial class Cadastrar : PageBase
    {
        private IPessoaController _pessoaController;
        private IEnderecoController _enderecoController;
        private IPessoaTelefoneController _pessoaTelefoneController;
        private ITelefoneTipoController _telefoneTipoController;
        private ITelefoneController _telefoneController;

        [Inject]
        public void Setup(IPessoaController pessoaController,
            IEnderecoController enderecoController,
            IPessoaTelefoneController pessoaTelefoneController,
            ITelefoneTipoController telefoneTipoController,
            ITelefoneController telefoneController)
        {
            _pessoaController = pessoaController;
            _enderecoController = enderecoController;
            _pessoaTelefoneController = pessoaTelefoneController;
            _telefoneTipoController = telefoneTipoController;
            _telefoneController = telefoneController;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void LinkBtnCadastrarClick(object sender, EventArgs e)
        {
            Control tableControl = FormViewCadastrar.FindControl("TableCadastrar");

            EnderecoDto _enderecoDto = new EnderecoDto();

            TextBox _txtBoxEndereco = (TextBox)tableControl.FindControl("TxtBoxEndereco");
            //_enderecoDto.SetLogradouro(_txtBoxEndereco.Text);
            _enderecoDto.logradouro = _txtBoxEndereco.Text;
            
            TextBox _txtBoxNumero = (TextBox)tableControl.FindControl("TxtBoxNumero");
            //_enderecoDto.SetNumero(Int32.Parse(_txtBoxNumero.Text));
            _enderecoDto.numero = Int32.Parse(_txtBoxNumero.Text);

            TextBox _txtBoxCep = (TextBox)tableControl.FindControl("TxtBoxCep");
            //_enderecoDto.SetCep(Int32.Parse(_txtBoxCep.Text));
            _enderecoDto.cep = Int32.Parse(_txtBoxCep.Text);

            TextBox _txtBoxBairro = (TextBox)tableControl.FindControl("TxtBoxBairro");
            //_enderecoDto.SetBairro(_txtBoxBairro.Text);
            _enderecoDto.bairro = _txtBoxBairro.Text;
            
            TextBox _txtBoxCidade = (TextBox)tableControl.FindControl("TxtBoxCidade");
            //_enderecoDto.SetCidade(_txtBoxCidade.Text);
            _enderecoDto.cidade = _txtBoxCidade.Text;

            TextBox _txtBoxEstado = (TextBox)tableControl.FindControl("TxtBoxEstado");
            //_enderecoDto.SetCidade(_txtBoxEstado.Text);
            _enderecoDto.estado = _txtBoxEstado.Text;

            EnderecoDto _enderecoInserted = await _enderecoController.Insert(_enderecoDto);

            TelefoneTipoDto _telefoneTipoDto = new TelefoneTipoDto();

            TextBox _txtBoxTipo = (TextBox)tableControl.FindControl("TxtBoxTipo");
            //_telefoneTipoDto.SetTipo(_txtBoxTipo.Text);
            _telefoneTipoDto.tipo = _txtBoxTipo.Text;

            TelefoneTipoDto _telefoneTipoInserted = await _telefoneTipoController
                .Insert(_telefoneTipoDto);

            TelefoneDto _telefoneDto = new TelefoneDto();

            TextBox _txtBoxDdd = (TextBox)tableControl.FindControl("TxtBoxDdd");
            //_telefoneDto.SetDdd(Int32.Parse(_txtBoxDdd.Text));
            _telefoneDto.ddd = Int32.Parse(_txtBoxDdd.Text);

            TextBox _txtBoxTelefone = (TextBox)tableControl.FindControl("TxtBoxTelefone");
            //_telefoneDto.SetNumero(Int64.Parse(_txtBoxTelefone.Text));
            _telefoneDto.numero = Int64.Parse(_txtBoxTelefone.Text);
            //_telefoneDto.SetIdTelefoneTipo(_telefoneTipoInserted.GetIdTelefoneTipo());
            _telefoneDto.id_telefone_tipo = _telefoneTipoInserted.id_telefone_tipo;

            TelefoneDto _telefoneInserted = await _telefoneController
                .Insert(_telefoneDto);

            PessoaDto _pessoaDto = new PessoaDto();

            TextBox _txtBoxNome = (TextBox)tableControl.FindControl("TxtBoxNome");
            //_pessoaDto.SetNome(_txtBoxNome.Text);
            _pessoaDto.nome = _txtBoxNome.Text;

            TextBox _txtBoxCpf = (TextBox)tableControl.FindControl("TxtBoxCpf");
            //_pessoaDto.SetCpf(Int64.Parse(_txtBoxCpf.Text));
            _pessoaDto.cpf = long.Parse(_txtBoxCpf.Text);
            //_pessoaDto.SetIdEndereco(_enderecoInserted.GetIdEndereco());
            _pessoaDto.id_endereco = _enderecoInserted.id_endereco;

            PessoaDto _pessoaInserted = await _pessoaController
                .Insert(_pessoaDto);

            PessoaTelefoneDto _pessoaTelefoneDto = new PessoaTelefoneDto();

            //_pessoaTelefoneDto.SetIdPessoa(_pessoaInserted.GetIdPessoa());
            //_pessoaTelefoneDto.SetIdTelefone(_telefoneInserted.GetIdTelefone());
            _pessoaTelefoneDto.id_pessoa = _pessoaInserted.id_pessoa;
            _pessoaTelefoneDto.id_telefone = _telefoneInserted.id_telefone;

            await _pessoaTelefoneController.Insert(_pessoaTelefoneDto);
            
            Response.Redirect("~/", false);
        }

        protected void LinkBtnVoltarClick(object sender, EventArgs e)
        {
            Response.Redirect("~/", false);
            
        }
    }
}