using Abstraction;
using Domain.Contracts;
using Domain.Modules;
using Newtonsoft.Json;
using Shared.DTOs;


namespace Services
{
    public class ProductService(IUnitOfWork _unitOfWork) : IProductService
    {
        public ProductDataDto GetAllProduct(int page=1,int pageSize=10)
        {
         var Products= _unitOfWork.GenericRepository<Product>().GetAll();

           

            int PageSize = pageSize >10?10: pageSize;
            int Take = PageSize;
            int Skip = (page - 1) * pageSize;

         var AfterPagination=   Products.Skip(Skip).Take(Take);

            var Map = AfterPagination.Select(P => new ProductToReturnDto()
            {
                Brand = P.Brand,
                Category = P.Category.ToString(),
                Description = P.Description,
                Id = P.Id,
                Image = P.Image,
                Price = P.Price,
                Rating = new RatingDto()
                {
                    Count = P.Rating.Count,
                    Rate = P.Rating.Rate
                },
                Specs =JsonConvert.DeserializeObject<Dictionary<string,dynamic>>(P.Specs),
                Stock = P.Stock,
                Title = P.Title,



            });



            var Pagination = new PaginationDto()
            {
                page = page,
                limit = AfterPagination.Count(),
                total = Products.Count()

            };



            return new ProductDataDto() {
            data=Map ,
             pagination=Pagination
            
            
            };




        }
    }
}
