using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.BaseEntities;
using VeganFit.Core.Enums;

namespace VeganFit.DAL.Concrete.Context.EntityConfigurations
{
    public abstract class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> 
                                                       where TEntity : BaseEntity
    {
        /// <summary>
        /// BaseEntity entity'sinin property'lerinin özelliklerinin belirtildiği metot. BaseEntity'nin property'leri diğer entity'ler için ortaktı. Herbirinin configuration'ında bu property'leri tekrar yazmamak için metodu virtual yaparak ezdik.
        /// </summary>
        /// <param name="builder"></param>
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder.Property(x => x.CreatedDate)
                .IsRequired();

            builder.Property(x => x.CreatedBy)
                .IsRequired(false);

            builder.Property(x => x.UpdatedDate)
                .IsRequired(false);

            builder.Property(x => x.UpdatedBy)
                .IsRequired(false);

            builder.Property(x => x.State)
                .HasConversion(new EnumToStringConverter<State>());
        }
    }
}
