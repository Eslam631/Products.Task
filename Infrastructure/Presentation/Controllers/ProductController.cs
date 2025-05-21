using Abstraction;
using Microsoft.AspNetCore.Mvc;

using Shared.DTOs;


namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController(IProductService _productService):ControllerBase
    {

        [HttpGet("Product")]
        public ActionResult<ProductDataDto> GetAllProduct([FromQuery]int? Page)
        {

            var Result = _productService.GetAllProduct(Page??1 );
        
            return Ok(Result);
        
        }


    }
}
