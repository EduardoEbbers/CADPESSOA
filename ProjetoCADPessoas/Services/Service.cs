using Ninject;
using ProjetoCADPessoas.Repositories.Interfaces;
using ProjetoCADPessoas.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Services
{
    public class Service<T> : IService<T> where T : class
    {
        [Inject]
        private IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<T> Insert(T t)
        {
            T _entity;
            try
            {
                _entity = await _repository
                    .Insert(t);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            IEnumerable<T> _entityList;
            try
            {
                _entityList = await _repository
                    .GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _entityList;
        }

        public async Task<T> GetById(Expression<Func<T, bool>> predicate)
        {
            T _entity;
            try
            {
                _entity = await _repository
                    .GetById(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _entity;
        }

        public async Task Update(T t)
        {
            try
            {
                await _repository
                    .Update(t);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Delete(Func<T, bool> predicate)
        {
            try
            {
                await _repository
                    .Delete(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}