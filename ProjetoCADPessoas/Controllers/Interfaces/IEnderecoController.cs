using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Controllers.Interfaces
{
    public interface IEnderecoController : IController<endereco>
    {
        Task<EnderecoDto> Insert(EnderecoDto EnderecoDto);
        Task<IEnumerable<EnderecoDto>> GetAll();
        Task<EnderecoDto> GetById(int id);
        Task Update(EnderecoDto EnderecoDto);
        Task Delete(int id);
    }
}
