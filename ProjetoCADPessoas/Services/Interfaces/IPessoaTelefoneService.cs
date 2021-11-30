using ProjetoCADPessoas.Models;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services.Interfaces
{
    public interface IPessoaTelefoneService : IService<pessoa_telefone>
    {
        Task<pessoa_telefone> GetById(int id);
        Task Delete(int id);
    }
}
