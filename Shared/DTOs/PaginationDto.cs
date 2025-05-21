

namespace Shared.DTOs
{
    public class PaginationDto
    {

        public int page { get; set; }

        public int limit { get; set; } = default!;
        public int total { get; set; } = default!;


    }
}
