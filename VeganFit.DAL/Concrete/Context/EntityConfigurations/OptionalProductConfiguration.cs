﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Entities;

namespace VeganFit.DAL.Concrete.Context.EntityConfigurations
{
    public class OptionalProductConfiguration : ProductConfiguration   //product ile aynı olduğu için product'tan kalıtım aldı ????
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
        }
    }
}