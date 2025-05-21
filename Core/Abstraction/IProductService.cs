using Shared.DTOs;


namespace Abstraction
{
    public interface IProductService
    {
        public ProductDataDto GetAllProduct(int page=1,int pageSize=10);
    }
}
