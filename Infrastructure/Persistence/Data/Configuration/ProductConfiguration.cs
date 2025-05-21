using Domain.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



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

            #endregion

            #region Relation

            builder.OwnsOne(P => P.Rating);

            #endregion


        }
    }
}
