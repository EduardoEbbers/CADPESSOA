using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Controllers.Interfaces
{
    public interface IPessoaController : IController<pessoa>
    {
        Task<PessoaDto> Insert(PessoaDto PessoaDto);
        Task<IEnumerable<PessoaDto>> GetAll();
        Task<PessoaDto> GetById(int id);
        Task Update(PessoaDto PessoaDto);
        Task Delete(int id);
    }
}
