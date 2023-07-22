using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Entities;

namespace VeganFit.DAL.Concrete.Context.EntityConfigurations
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ProductName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Calori)
                .IsRequired();

            builder.Property(x => x.Serving)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(x => x.Picture)
                .IsRequired(false);
        }
    }
}
