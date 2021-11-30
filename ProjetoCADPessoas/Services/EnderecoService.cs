using Ninject;
using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Repositories.Interfaces;
using ProjetoCADPessoas.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services
{
    public class EnderecoService : Service<endereco>, IEnderecoService
    {
        [Inject]
        private IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public async Task<endereco> GetById(int id)
        {
            endereco _endereco;
            try
            {
                _endereco = await _enderecoRepository
                    .GetById(p => p.id_endereco == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _endereco;
        }

        public async Task Delete(int id)
        {
            try
            {
                await _enderecoRepository.Delete(p => p.id_endereco == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}