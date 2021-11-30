using Ninject;
using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Repositories.Interfaces;
using ProjetoCADPessoas.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services
{
    public class TelefoneTipoService : Service<telefone_tipo>, ITelefoneTipoService
    {
        [Inject]
        private ITelefoneTipoRepository _telefoneTipoRepository;

        public TelefoneTipoService(ITelefoneTipoRepository telefoneTipoRepository) : base(telefoneTipoRepository)
        {
            _telefoneTipoRepository = telefoneTipoRepository;
        }

        public async Task<telefone_tipo> GetById(int id)
        {
            telefone_tipo _telefoneTipo;
            try
            {
                _telefoneTipo = await _telefoneTipoRepository
                    .GetById(p => p.id_telefone_tipo == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _telefoneTipo;
        }

        public async Task Delete(int id)
        {
            try
            {
                await _telefoneTipoRepository.Delete(p => p.id_telefone_tipo == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}