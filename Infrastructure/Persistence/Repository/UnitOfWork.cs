using Domain.Contracts;
using Domain.Modules;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Persistence.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class UnitOfWork(ApplicationDbContext _dbContext) : IUnitOfWork
    {
        private readonly Dictionary<string, object> _Repositories = [];
        public IGenericRepository<T> GenericRepository<T>() where T : BaseEntity
        {
            var Type=typeof(T).Name;

            if (_Repositories.TryGetValue(Type,out object? value))
                return (IGenericRepository<T>)value;
            else
            {
                var Repo = new GenericRepository<T>(_dbContext);

               

                _Repositories[Type] = Repo;

                return Repo;
            }

        }

        public async Task<int> SaveChangeAsync()
        {
         return  await _dbContext.SaveChangesAsync();
        }
    }
}
