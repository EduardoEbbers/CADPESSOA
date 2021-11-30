using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Controllers.Interfaces
{
    public interface ITelefoneTipoController : IController<telefone_tipo>
    {
        Task<TelefoneTipoDto> Insert(TelefoneTipoDto telefoneTipoDto);
        Task<IEnumerable<TelefoneTipoDto>> GetAll();
        Task<TelefoneTipoDto> GetById(int id);
        Task Update(TelefoneTipoDto telefoneTipoDto);
        Task Delete(int id);
    }
}
