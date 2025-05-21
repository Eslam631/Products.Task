

namespace Shared.DTOs
{
  public class ProductDataDto
    {
        public IEnumerable<ProductToReturnDto> data { get; set; } = [];

        public PaginationDto pagination { get; set; } = default!;

    }
}
