using Domain.Modules;


namespace Domain.Contracts
{
public interface IGenericRepository<T> where T:BaseEntity
    {
        public IEnumerable<T> GetAll();

    }
}
