using Domain.Modules;
using Microsoft.EntityFrameworkCore;

using System.Reflection;

namespace Persistence.Data.Context
{
    public class ApplicationDbContext:DbContext
    {

       public DbSet<Product> Products { get; set; }
       



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
