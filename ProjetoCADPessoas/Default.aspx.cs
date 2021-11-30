using Ninject;
using Ninject.Web;
using ProjetoCADPessoas.Controllers.Interfaces;
using ProjetoCADPessoas.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace ProjetoCADPessoas
{
    public partial class _Default : PageBase
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

        public async Task<IEnumerable<PessoaDto>> GetPessoas()
        {
            return await _pessoaController.GetAll();
        }

        protected void LinkBtnCommand(object sender, CommandEventArgs e)
        {
            string _command = e.CommandName;
            int _indexPessoa = Convert.ToInt32(e.CommandArgument);
            switch (_command)
            {
                case "Detalhes":
                    DetailItem(_indexPessoa);
                    break;
                case "Editar":
                    EditItem(_indexPessoa);
                    break;
                case "Excluir":
                    DeleteItem(_indexPessoa);
                    break;
            }
        }

        public async void DeleteItem(int idPessoa)
        {
            PessoaDto _pessoaDto = await _pessoaController.GetById(idPessoa);
            PessoaTelefoneDto _pessoaTelefoneDto = await _pessoaTelefoneController.GetById(idPessoa);
            TelefoneDto _telefoneDto = await _telefoneController.GetById(_pessoaTelefoneDto.GetIdTelefone());

            await _pessoaTelefoneController.Delete(idPessoa);
            await _pessoaController.Delete(idPessoa);
            await _enderecoController.Delete(_pessoaDto.GetIdEndereco());
            await _telefoneController.Delete(_pessoaTelefoneDto.GetIdTelefone());
            await _telefoneTipoController.Delete(_telefoneDto.GetIdTelefoneTipo());

            Response.Redirect("~/", false);
        }

        public void EditItem(int idPessoa)
        {
            Response.Redirect("~/Views/Editar/" + idPessoa.ToString());
        }

        public void DetailItem(int idPessoa)
        {
            Response.Redirect("~/Views/Detalhes/" + idPessoa.ToString());
        }
    }
}