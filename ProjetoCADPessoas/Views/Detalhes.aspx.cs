using Ninject;
using Ninject.Web;
using ProjetoCADPessoas.Controllers.Interfaces;
using ProjetoCADPessoas.Models.Dtos;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoCADPessoas.Views
{
    public partial class Detalhes : PageBase
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

                Control tableControl = FormViewDetalhes.FindControl("TableDetalhes");

                PessoaDto _pessoaDto = await _pessoaController.GetById(_indexPessoa);
                _indexEndereco = _pessoaDto.GetIdEndereco();

                Label _lblNome = (Label)tableControl.FindControl("LblNome");
                _lblNome.Text = _pessoaDto.GetNome();
                Label _lblCpf = (Label)tableControl.FindControl("LblCpf");
                _lblCpf.Text = _pessoaDto.GetCpf().ToString();

                EnderecoDto _enderecoDto = await _enderecoController.GetById(_indexEndereco);

                Label _lblEndereco = (Label)tableControl.FindControl("LblEndereco");
                _lblEndereco.Text = _enderecoDto.GetLogradouro();
                Label _lblNumero = (Label)tableControl.FindControl("LblNumero");
                _lblNumero.Text = _enderecoDto.GetNumero().ToString();
                Label _lblCep = (Label)tableControl.FindControl("LblCep");
                _lblCep.Text = _enderecoDto.GetCep().ToString();
                Label _lblBairro = (Label)tableControl.FindControl("LblBairro");
                _lblBairro.Text = _enderecoDto.GetBairro();
                Label _lblCidade = (Label)tableControl.FindControl("LblCidade");
                _lblCidade.Text = _enderecoDto.GetCidade();
                Label _lblEstado = (Label)tableControl.FindControl("LblEstado");
                _lblEstado.Text = _enderecoDto.GetEstado();

                PessoaTelefoneDto _pessoaTelefoneDto = await _pessoaTelefoneController.GetById(_indexPessoa);
                _indexTelefone = _pessoaTelefoneDto.GetIdTelefone();

                TelefoneDto _telefoneDto = await _telefoneController.GetById(_indexTelefone);
                _indexTelefoneTipo = _telefoneDto.GetIdTelefoneTipo();

                Label _lblDddTelefone = (Label)tableControl.FindControl("LblDddTelefone");
                _lblDddTelefone.Text = "(" + _telefoneDto.GetDdd().ToString() + ") " + _telefoneDto.GetNumero();

                TelefoneTipoDto _telefoneTipoDto = await _telefoneTipoController.GetById(_indexTelefoneTipo);

                Label _lblTipo = (Label)tableControl.FindControl("LblTipo");
                _lblTipo.Text = _telefoneTipoDto.GetTipo();
            }
        }
    }
}