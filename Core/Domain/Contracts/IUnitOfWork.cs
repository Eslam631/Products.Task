using Domain.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
   public interface IUnitOfWork
    {

        public IGenericRepository<T> GenericRepository<T>() where T : BaseEntity;


        public Task<int> SaveChangeAsync();


    }
}
