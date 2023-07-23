using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Entities;

namespace VeganFit.DAL.Concrete.Context.EntityConfigurations
{
    /// <summary>
    /// Weight entity'sinin property'lerinin özelliklerinin belirlendiği metot.
    /// </summary>
    public class WeightConfiguration : BaseConfiguration<Weight>
    {
        public override void Configure(EntityTypeBuilder<Weight> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.UserWeight)
                .IsRequired();

            builder.Property(x => x.DateOfRecord)
                .IsRequired();

            builder.HasOne<User>(x => x.User)
                .WithMany(x => x.Weights)
                .HasForeignKey(x => x.UserId);
        }
    }
}
