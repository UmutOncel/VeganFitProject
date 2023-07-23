﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;

namespace VeganFit.DAL.Concrete.Context.EntityConfigurations
{
    public abstract class AuditableConfiguration<TEntity> : BaseConfiguration<TEntity> 
                                                            where TEntity : AuditableEntity
    {
        /// <summary>
        /// AuditableEntity entity'sinin property'lerinin özelliklerinin belirtildiği metot.
        /// </summary>
        /// <param name="builder"></param>
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.DeletedDate)
                .IsRequired(false);
        }
    }
}
