using Abstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(IProductService _productService):ControllerBase
    {

        [HttpGet("Product")]
        public ActionResult<ProductDataDto> GetAllProduct(int Page)
        {

            var Result = _productService.GetAllProduct(Page );
        
            return Ok(Result);
        
        }


    }
}
