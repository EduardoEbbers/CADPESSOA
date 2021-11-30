using Ninject;
using ProjetoCADPessoas.Controllers.Interfaces;
using ProjetoCADPessoas.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoCADPessoas.Controllers
{
    public class Controller<T> : ControllerBase, IController<T> where T : class
    {
        [Inject]
        private IService<T> _service;

        public Controller(IService<T> service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<T> Insert(T t)
        {
            T _entity;
            try
            {
                _entity = await _service.Insert(t);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _entity;
        }

        [HttpGet]
        public async Task<IEnumerable<T>> GetAll()
        {
            IEnumerable<T> _entity;
            try
            {
                _entity = await _service.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _entity;
        }

        [HttpGet]
        public async Task<T> GetById(Expression<Func<T, bool>> predicate)
        {
            T _entity;
            try
            {
                _entity = await _service.GetById(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _entity;
        }

        [HttpPut]
        public async Task Update(T t)
        {
            try
            {
                await _service.Update(t);
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
                await _service.Delete(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}