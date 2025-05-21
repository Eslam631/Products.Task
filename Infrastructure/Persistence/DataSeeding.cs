using Domain.Contracts;
using Domain.Modules;
using Microsoft.EntityFrameworkCore;
using Persistence.Data.Context;
using Persistence.Dto;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Persistence
{
    public class DataSeeding(ApplicationDbContext _dbContext) : IDataSeeding
    {
        public void DataSeed()
        {
            if (_dbContext.Database.GetPendingMigrations().Any())
                _dbContext.Database.Migrate();

            if (!_dbContext.Products.Any())
            {
                var json = File.ReadAllText(@"..\Infrastructure\Persistence\DataSeedFile\json-sorter.json");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                options.Converters.Add(new JsonStringEnumConverter());

                //convert Json To ProductSeedDto
                var dtoList = JsonSerializer.Deserialize<List<ProductSeedDto>>(json, options);

                if (dtoList != null && dtoList.Any())
                {
                    //convert ProductSeedDto To product
                     var products = dtoList.Select(dto => new Product
                    {
                        Title = dto.Title,
                        Price = dto.Price,
                        Description = dto.Description,
                        Category = Enum.TryParse<Category>(dto.Category,out var result)?result:Category.furniture,
                        Brand = dto.Brand,
                        Stock = dto.Stock,
                        Image = dto.Image,
                        Specs = dto.Specs.GetRawText(), 
                        Rating = dto.Rating
                    }).ToList();

                    _dbContext.Products.AddRange(products);
                    _dbContext.SaveChanges();
                }
            }


        }
    }
}
