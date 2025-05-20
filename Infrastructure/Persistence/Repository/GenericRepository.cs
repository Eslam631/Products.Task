using Domain.Contracts;
using Domain.Modules;
using Persistence.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class GenericRepository<T>(ApplicationDbContext _dbContext) : IGenericRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList(); 
        }
    }

}
