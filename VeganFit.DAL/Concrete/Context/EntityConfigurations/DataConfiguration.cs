﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
        public override void Configure(EntityTypeBuilder<Data> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Calori)
                .IsRequired();

            builder.Property(x => x.Datetime)
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

            builder.HasOne<OptionalProduct>(x => x.OptionalProduct)
                .WithMany(x => x.Datas)
                .HasForeignKey(x => x.OptionalProductId);
        }
    }
}