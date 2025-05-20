using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modules
{
	public class Product : BaseEntity
	{


		//      		"id": 1,
		//"title": "Smartphone X",
		//"price": 799.99,
		//"description": "Latest smartphone with advanced features",
		//"category": "electronics",
		//"brand": "TechCo",
		//"stock": 50,
		//"image": "https://fakeapi.net/images/smartphone.jpg",
		//"specs": {
		//	"color": "black",
		//	"weight": "180g",
		//	"storage": "128GB"
		//},
		//"rating": {
		//	"rate": 4.5,
		//	"count": 120
		public string Title { get; set; } = default!;


		public decimal Price { get; set; }
		public string Description { get; set; } = default!;
		public Category Category { get; set; }

		public int Stock {  get; set; }

		public string Brand { get; set; }=default!;




	
		public string Image { get; set; } = default!;

		public List<Specs> Specs { get; set; } = new();

		public Rating Rating { get; set; } = default!;




}
}
