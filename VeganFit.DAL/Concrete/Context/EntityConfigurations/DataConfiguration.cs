using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.Enums;
using VeganFit.Entities;

namespace VeganFit.DAL.Concrete.Context.EntityConfigurations
{
    public class DataConfiguration : BaseConfiguration<Data>
    {
        /// <summary>
        /// Data entity'sinin property'lerinin özelliklerinin belirlendiği metot.
        /// </summary>
        /// <param name="builder"></param>
        public override void Configure(EntityTypeBuilder<Data> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Calori)
                .IsRequired();

            builder.Property(x => x.Datetime)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(x => x.Meal)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<Meal>());

            builder.HasOne<User>(x => x.User)
                .WithMany(x => x.Datas)
                .HasForeignKey(x => x.UserId);

            builder.HasOne<Product>(x => x.Product)
                .WithMany(x => x.Datas)
                .HasForeignKey(x => x.ProductId);

            builder.Property(x=>x.ProductId).IsRequired(false);
            builder.Property(x=>x.UserId).IsRequired(false);

            builder.Property(x=>x.UserEmail)
                   .IsRequired(false)
                   .HasMaxLength(250);
        }
    }
}
