using Ninject;
using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Repositories.Interfaces;
using ProjetoCADPessoas.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services
{
    public class PessoaService : Service<pessoa>, IPessoaService
    {
        [Inject]
        private IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository) : base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public async Task<pessoa> GetById(int id)
        {
            pessoa _pessoa;
            try
            {
                _pessoa = await _pessoaRepository
                    .GetById(p => p.id_pessoa == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _pessoa;
        }

        public async Task Delete(int id)
        {
            try
            {
                await _pessoaRepository.Delete(p => p.id_pessoa == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}