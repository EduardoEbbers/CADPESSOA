using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProjetoCADPessoas.Models;
using ProjetoCADPessoas.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjetoCADPessoas.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private EntitiesContext _context;

        public Repository()
        {
            _context = new EntitiesContext(new DbContextOptions<EntitiesContext>());
        }

        public Task<T> Insert(T t)
        {
            EntityEntry<T> _entityEntry;
            try
            {
                _entityEntry = _context
                    .Set<T>()
                    .AddAsync(t)
                    .Result;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Task.FromResult(_entityEntry.Entity);
        }

        public Task<IEnumerable<T>> GetAll()
        {
            IEnumerable<T> _entityList;
            try
            {
                _entityList = _context
                    .Set<T>()
                    .AsNoTracking()
                    .AsEnumerable();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Task.FromResult(_entityList);
        }

        public Task<T> GetById(Expression<Func<T, bool>> predicate)
        {
            T _entity;
            try
            {
                _entity = _context
                    .Set<T>()
                    .AsNoTracking()
                    .SingleOrDefaultAsync(predicate)
                    .Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Task.FromResult(_entity);
        }

        public Task Update(T t)
        {
            T _entityEntry;
            try
            {
                _entityEntry = _context
                    .Set<T>()
                    .Update(t)
                    .Entity;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Task.CompletedTask;
        }

        public Task Delete(Func<T, bool> predicate)
        {
            try
            {
                _context
                   .Set<T>()
                   .Where(predicate)
                   .ToList()
                   .ForEach(del => _context.Set<T>().Remove(del));
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Task.CompletedTask;
        }
    }
}