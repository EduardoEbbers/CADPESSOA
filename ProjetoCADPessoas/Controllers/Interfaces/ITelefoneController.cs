using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Controllers.Interfaces
{
    public interface ITelefoneController : IController<telefone>
    {
        Task<TelefoneDto> Insert(TelefoneDto TelefoneDto);
        Task<IEnumerable<TelefoneDto>> GetAll();
        Task<TelefoneDto> GetById(int id);
        Task Update(TelefoneDto TelefoneDto);
        Task Delete(int id);
    }
}
