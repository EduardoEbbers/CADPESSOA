using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Controllers.Interfaces
{
    public interface IPessoaTelefoneController : IController<pessoa_telefone>
    {
        Task<PessoaTelefoneDto> Insert(PessoaTelefoneDto PessoaTelefoneDto);
        Task<IEnumerable<PessoaTelefoneDto>> GetAll();
        Task<PessoaTelefoneDto> GetById(int id);
        Task Update(PessoaTelefoneDto PessoaTelefoneDto);
        Task Delete(int id);
    }
}
