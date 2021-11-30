using ProjetoCADPessoas.Models;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services.Interfaces
{
    public interface ITelefoneService : IService<telefone>
    {
        Task<telefone> GetById(int id);
        Task Delete(int id);
    }
}
