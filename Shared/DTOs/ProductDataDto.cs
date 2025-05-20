using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
  public class ProductDataDto
    {
        public IEnumerable<ProductToReturnDto> data { get; set; } = [];

        public PaginationDto pagination { get; set; } = default!;

    }
}
