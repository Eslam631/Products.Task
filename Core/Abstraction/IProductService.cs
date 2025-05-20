using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface IProductService
    {
        public ProductDataDto GetAllProduct(int page=1,int pageSize=10);
    }
}
