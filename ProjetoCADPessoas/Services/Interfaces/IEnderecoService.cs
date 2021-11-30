using ProjetoCADPessoas.Models;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services.Interfaces
{
    public interface IEnderecoService : IService<endereco>
    {
        Task<endereco> GetById(int id);
        Task Delete(int id);
    }
}
