

namespace Shared.DTOs
{
    public class ProductToReturnDto
    {
        public int Id {  get; set; }
        public string Title { get; set; } = default!;


        public decimal Price { get; set; }
        public string Description { get; set; } = default!;
        public string Category { get; set; } = default!;

        public int Stock { get; set; }

        public string Brand { get; set; } = default!;





        public string Image { get; set; } = default!;

        public Dictionary<string,dynamic> Specs { get; set; } = new();

        public RatingDto Rating { get; set; } = default!;
    }
}
