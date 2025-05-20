using Domain.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            #region Property

            builder.Property(P => P.Price).HasColumnType("decimal(8,2)");
            builder.Property(P => P.Title).HasColumnType("nvarchar(20)");
            builder.Property(P => P.Brand).HasColumnType("nvarchar(30)");
         
            builder.Property(P => P.Description).HasColumnType("nvarchar(200)");


            builder.Property(p => p.Specs)
            .HasConversion(
                v => JsonConvert.SerializeObject(v), // To database (JSON)
                v => JsonConvert.DeserializeObject<List<Specs>>(v) ?? new List<Specs>() // From database
            );

            //builder.Property(P => P.Specs).HasConversion(V=>JsonCovert.)

            #endregion

            #region Relation


            builder.OwnsOne(P => P.Rating);

            #endregion


        }
    }
}
