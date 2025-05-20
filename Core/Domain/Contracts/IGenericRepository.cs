using Domain.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
public interface IGenericRepository<T> where T:BaseEntity
    {

        public IEnumerable<T> GetAll();


    }
}
