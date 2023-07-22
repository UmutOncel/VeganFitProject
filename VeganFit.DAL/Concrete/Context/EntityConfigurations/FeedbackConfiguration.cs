using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Entities;

namespace VeganFit.DAL.Concrete.Context.EntityConfigurations
{
    public class FeedbackConfiguration : BaseConfiguration<Feedback>
    {
        public override void Configure(EntityTypeBuilder<Feedback> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.MessageText)
                .HasMaxLength(500)
                .IsRequired();

            builder.HasOne<User>(x => x.User)
                .WithMany(x => x.Feedbacks)
                .HasForeignKey(x => x.UserId);
        }
    }
}
