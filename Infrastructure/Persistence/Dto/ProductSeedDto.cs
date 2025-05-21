using Domain.Modules;
using System.Text.Json;

namespace Persistence.Dto
{
   public class ProductSeedDto
    {
        public string Title { get; set; } = default!;
        public decimal Price { get; set; }= default!;
        public string Description { get; set; } = default!;
        public string Category { get; set; } = default!;
        public string Brand { get; set; } = default!;
        public int Stock { get; set; }
        public string Image { get; set; } = default!;
        public JsonElement Specs { get; set; } 
        public Rating Rating { get; set; } = default!;

    }
}
