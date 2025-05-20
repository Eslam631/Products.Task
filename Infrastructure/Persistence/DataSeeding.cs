using Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using Persistence.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DataSeeding(ApplicationDbContext _dbContext) : IDataSeeding
    {
        public void DataSeed()
        {
          if(_dbContext.Database.GetPendingMigrations().Any()) 
                _dbContext.Database.Migrate();


        }
    }
}
