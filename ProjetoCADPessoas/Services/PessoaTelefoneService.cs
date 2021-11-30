using Ninject;
using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Repositories.Interfaces;
using ProjetoCADPessoas.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services
{
    public class PessoaTelefoneService : Service<pessoa_telefone>, IPessoaTelefoneService
    {
        [Inject]
        private IPessoaTelefoneRepository _pessoaTelefoneRepository;

        public PessoaTelefoneService(IPessoaTelefoneRepository pessoaTelefoneRepository) : base(pessoaTelefoneRepository)
        {
            _pessoaTelefoneRepository = pessoaTelefoneRepository;
        }

        public async Task<pessoa_telefone> GetById(int id)
        {
            pessoa_telefone _pessoaTelefone;
            try
            {
                _pessoaTelefone = await _pessoaTelefoneRepository
                    .GetById(p => p.id_pessoa == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _pessoaTelefone;
        }

        public async Task Delete(int id)
        {
            try
            {
                await _pessoaTelefoneRepository.Delete(p => p.id_pessoa == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}