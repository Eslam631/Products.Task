using Abstraction;
using AutoMapper;
using Domain.Contracts;
using Domain.Modules;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService(IUnitOfWork _unitOfWork,IMapper _mapper) : IProductService
    {
        public ProductDataDto GetAllProduct(int page=1,int pageSize=10)
        {
         var Product=   _unitOfWork.GenericRepository<Product>().GetAll();



            int PageSize = pageSize >10?10: pageSize;
            int Take = PageSize;
            int Skip = (page - 1) * pageSize;

         var AfterPagination=   Product.Skip(Skip).Take(Take);


        var Mapper= _mapper.Map<IEnumerable<ProductToReturnDto>>(AfterPagination);


            var Pagination = new PaginationDto()
            {
                page = page,
                limit = AfterPagination.Count(),
                total = Product.Count()

            };



            return new ProductDataDto() {
            data=Mapper ,
             pagination=Pagination
            
            
            };




        }
    }
}
