using Domain.Contracts;
using Domain.Modules;
using Microsoft.EntityFrameworkCore;
using Persistence.Data.Context;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Persistence
{
    public class DataSeeding(ApplicationDbContext _dbContext) : IDataSeeding
    {
        public void DataSeed()
        {
          if(_dbContext.Database.GetPendingMigrations().Any()) 
                _dbContext.Database.Migrate();
            if (!_dbContext.Products.Any())
            {

                var Product = File.ReadAllText(@"..\Infrastructure\Persistence\DataSeedFile\json-sorter.json");
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                options.Converters.Add(new JsonStringEnumConverter());
                var ProductList=JsonSerializer.Deserialize<List<Product>>(Product,options);

                if(ProductList is not null&&ProductList.Any())
                    _dbContext.Products.AddRange(ProductList);


            }


            _dbContext.SaveChanges();

        }
    }
}
