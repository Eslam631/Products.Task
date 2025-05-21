using Domain.Modules;

namespace Domain.Contracts
{
   public interface IUnitOfWork
    {
        public IGenericRepository<T> GenericRepository<T>() where T : BaseEntity;

        public Task<int> SaveChangeAsync();

    }
}
