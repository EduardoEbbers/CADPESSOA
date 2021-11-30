using ProjetoCADPessoas.Models;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services.Interfaces
{
    public interface ITelefoneTipoService : IService<telefone_tipo>
    {
        Task<telefone_tipo> GetById(int id);
        Task Delete(int id);
    }
}
