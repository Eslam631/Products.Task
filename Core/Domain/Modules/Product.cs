
namespace Domain.Modules
{
	public class Product : BaseEntity
	{
		public string Title { get; set; } = default!;

		public decimal Price { get; set; }
		public string Description { get; set; } = default!;
		public Category Category { get; set; }

		public int Stock {  get; set; }

		public string Brand { get; set; }=default!;

		public string Image { get; set; } = default!;

        public string Specs { get; set; } = default!;

        public Rating Rating { get; set; } = default!;




}
}
