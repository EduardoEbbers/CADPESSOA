using ProjetoCADPessoas.Models;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services.Interfaces
{
    public interface IPessoaService : IService<pessoa>
    {
        Task<pessoa> GetById(int id);
        Task Delete(int id);
    }
}
