using Ninject;
using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Repositories.Interfaces;
using ProjetoCADPessoas.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services
{
    public class TelefoneService : Service<telefone>, ITelefoneService
    {
        [Inject]
        private ITelefoneRepository _telefoneRepository;

        public TelefoneService(ITelefoneRepository telefoneRepository) : base(telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }

        public async Task<telefone> GetById(int id)
        {
            telefone _telefone;
            try
            {
                _telefone = await _telefoneRepository
                    .GetById(p => p.id_telefone == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _telefone;
        }

        public async Task Delete(int id)
        {
            try
            {
                await _telefoneRepository.Delete(p => p.id_telefone == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}