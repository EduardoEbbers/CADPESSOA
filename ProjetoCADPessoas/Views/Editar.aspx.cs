using Ninject;
using Ninject.Web;
using ProjetoCADPessoas.Controllers.Interfaces;
using ProjetoCADPessoas.Models.Dtos;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoCADPessoas.Views
{
    public partial class Editar : PageBase
    {
        private IPessoaController _pessoaController;
        private IEnderecoController _enderecoController;
        private IPessoaTelefoneController _pessoaTelefoneController;
        private ITelefoneTipoController _telefoneTipoController;
        private ITelefoneController _telefoneController;
        private int _indexPessoa = 0;
        private int _indexEndereco = 0;
        private int _indexTelefone = 0;
        private int _indexTelefoneTipo = 0;

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

        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                _indexPessoa = Convert.ToInt32(Request.Url.Segments[3]);

                Control tableControl = FormViewEditar.FindControl("TableEditar");

                PessoaDto _pessoaDto = await _pessoaController.GetById(_indexPessoa);
                _indexEndereco = _pessoaDto.GetIdEndereco();

                TextBox _txtBoxNome = (TextBox)tableControl.FindControl("TxtBoxNome");
                _txtBoxNome.Text = _pessoaDto.GetNome();
                TextBox _txtBoxCpf = (TextBox)tableControl.FindControl("TxtBoxCpf");
                _txtBoxCpf.Text = _pessoaDto.GetCpf().ToString();

                EnderecoDto _enderecoDto = await _enderecoController.GetById(_indexEndereco);

                TextBox _txtBoxEndereco = (TextBox)tableControl.FindControl("TxtBoxEndereco");
                _txtBoxEndereco.Text = _enderecoDto.GetLogradouro();
                TextBox _txtBoxNumero = (TextBox)tableControl.FindControl("TxtBoxNumero");
                _txtBoxNumero.Text = _enderecoDto.GetNumero().ToString();
                TextBox _txtBoxCep = (TextBox)tableControl.FindControl("TxtBoxCep");
                _txtBoxCep.Text = _enderecoDto.GetCep().ToString();
                TextBox _txtBoxBairro = (TextBox)tableControl.FindControl("TxtBoxBairro");
                _txtBoxBairro.Text = _enderecoDto.GetBairro();
                TextBox _txtBoxCidade = (TextBox)tableControl.FindControl("TxtBoxCidade");
                _txtBoxCidade.Text = _enderecoDto.GetCidade();
                TextBox _txtBoxEstado = (TextBox)tableControl.FindControl("TxtBoxEstado");
                _txtBoxEstado.Text = _enderecoDto.GetEstado();

                PessoaTelefoneDto _pessoaTelefoneDto = await _pessoaTelefoneController.GetById(_indexPessoa);
                _indexTelefone = _pessoaTelefoneDto.GetIdTelefone();

                TelefoneDto _telefoneDto = await _telefoneController.GetById(_indexTelefone);
                _indexTelefoneTipo = _telefoneDto.GetIdTelefoneTipo();

                TextBox _txtBoxDdd = (TextBox)tableControl.FindControl("TxtBoxDdd");
                _txtBoxDdd.Text = _telefoneDto.GetDdd().ToString();
                TextBox _txtBoxTelefone = (TextBox)tableControl.FindControl("TxtBoxTelefone");
                _txtBoxTelefone.Text = _telefoneDto.GetNumero().ToString();

                TelefoneTipoDto _telefoneTipoDto = await _telefoneTipoController.GetById(_indexTelefoneTipo);

                TextBox _txtBoxTipo = (TextBox)tableControl.FindControl("TxtBoxTipo");
                _txtBoxTipo.Text = _telefoneTipoDto.GetTipo();
            }
        }

        protected async void LinkBtnEditarClick(object sender, EventArgs e)
        {
            _indexPessoa = Convert.ToInt32(Request.Url.Segments[3]);

            Control tableControl = FormViewEditar.FindControl("TableEditar");

            PessoaDto _pesDto = await _pessoaController.GetById(_indexPessoa);

            PessoaTelefoneDto _pesTelDto = await _pessoaTelefoneController.GetById(_pesDto.GetIdPessoa());

            TelefoneDto _telDto = await _telefoneController.GetById(_pesTelDto.GetIdTelefone());

            EnderecoDto _enderecoDto = new EnderecoDto();

            TextBox _txtBoxEndereco = (TextBox)tableControl.FindControl("TxtBoxEndereco");
            _enderecoDto.SetLogradouro(_txtBoxEndereco.Text);
            //_enderecoDto.logradouro = _txtBoxEndereco.Text;
            
            TextBox _txtBoxNumero = (TextBox)tableControl.FindControl("TxtBoxNumero");
            _enderecoDto.SetNumero(Int32.Parse(_txtBoxNumero.Text));
            //_enderecoDto.numero = Convert.ToInt32(_txtBoxNumero.Text);
            
            TextBox _txtBoxCep = (TextBox)tableControl.FindControl("TxtBoxCep");
            _enderecoDto.SetCep(Int32.Parse(_txtBoxCep.Text));
            //_enderecoDto.cep = Convert.ToInt32(_txtBoxCep.Text);
            
            TextBox _txtBoxBairro = (TextBox)tableControl.FindControl("TxtBoxBairro");
            _enderecoDto.SetBairro(_txtBoxBairro.Text);
            //_enderecoDto.bairro = _txtBoxBairro.Text;
            
            TextBox _txtBoxCidade = (TextBox)tableControl.FindControl("TxtBoxCidade");
            _enderecoDto.SetCidade(_txtBoxCidade.Text);
            //_enderecoDto.cidade = _txtBoxCidade.Text;
            
            TextBox _txtBoxEstado = (TextBox)tableControl.FindControl("TxtBoxEstado");
            _enderecoDto.SetEstado(_txtBoxEstado.Text);
            _enderecoDto.SetIdEndereco(_pesDto.GetIdEndereco());
            //_enderecoDto.estado = _txtBoxEstado.Text;
            //_enderecoDto.id_endereco = _pesDto.id_endereco;


            await _enderecoController
                .Update(_enderecoDto);

            TelefoneTipoDto _telefoneTipoDto = new TelefoneTipoDto();

            TextBox _txtBoxTipo = (TextBox)tableControl.FindControl("TxtBoxTipo");
            _telefoneTipoDto.SetTipo(_txtBoxTipo.Text);
            _telefoneTipoDto.SetIdTelefoneTipo(_telDto.GetIdTelefoneTipo());
            //_telefoneTipoDto.tipo = _txtBoxTipo.Text;
            //_telefoneTipoDto.id_telefone_tipo = _telDto.id_telefone_tipo;

            await _telefoneTipoController
               .Update(_telefoneTipoDto);

            TelefoneDto _telefoneDto = new TelefoneDto();

            TextBox _txtBoxDdd = (TextBox)tableControl.FindControl("TxtBoxDdd");
            _telefoneDto.SetDdd(Int32.Parse(_txtBoxDdd.Text));
            //_telefoneDto.ddd = Convert.ToInt32(_txtBoxDdd.Text);
            
            TextBox _txtBoxTelefone = (TextBox)tableControl.FindControl("TxtBoxTelefone");
            _telefoneDto.SetNumero(Int32.Parse(_txtBoxTelefone.Text));
            //_telefoneDto.numero = Convert.ToInt32(_txtBoxTelefone.Text);
            _telefoneDto.SetIdTelefone(_telDto.GetIdTelefone());
            _telefoneTipoDto.SetIdTelefoneTipo(_telDto.GetIdTelefoneTipo());
            //_telefoneDto.id_telefone = _telDto.id_telefone;
            //_telefoneDto.id_telefone_tipo = _telDto.id_telefone_tipo;

            await _telefoneController
               .Update(_telefoneDto);

            PessoaDto _pessoaDto = new PessoaDto();

            TextBox _txtBoxNome = (TextBox)tableControl.FindControl("TxtBoxNome");
            _pessoaDto.SetNome(_txtBoxNome.Text);
            //_pessoaDto.nome = _txtBoxNome.Text;

            TextBox _txtBoxCpf = (TextBox)tableControl.FindControl("TxtBoxCpf");
            _pessoaDto.SetCpf(long.Parse(_txtBoxCpf.Text));
            //_pessoaDto.cpf = long.Parse(_txtBoxCpf.Text);

            _pessoaDto.SetIdPessoa(_indexPessoa);
            _pessoaDto.SetIdEndereco(_pesDto.GetIdEndereco());
            //_pessoaDto.id_pessoa = _indexPessoa;
            //_pessoaDto.id_endereco = _pesDto.id_endereco;

            await _pessoaController
               .Update(_pessoaDto);

            PessoaTelefoneDto _pessoaTelefoneDto = new PessoaTelefoneDto();

            _pessoaTelefoneDto.SetIdPessoa(_indexPessoa);
            _pessoaTelefoneDto.SetIdTelefone(_telDto.GetIdTelefone());
            //_pessoaTelefoneDto.id_pessoa = _indexPessoa;
            //_pessoaTelefoneDto.id_telefone = _telDto.id_telefone;

            await _pessoaTelefoneController
               .Update(_pessoaTelefoneDto);

            Response.Redirect("~/", false);
        }
    }
}