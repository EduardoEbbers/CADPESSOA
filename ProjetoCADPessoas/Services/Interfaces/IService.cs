using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services.Interfaces
{
    public interface IService<T> where T : class
    {
        Task<T> Insert(T t);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Expression<Func<T, bool>> predicate);
        Task Update(T t);
        Task Delete(Func<T, bool> predicate);
    }
}
