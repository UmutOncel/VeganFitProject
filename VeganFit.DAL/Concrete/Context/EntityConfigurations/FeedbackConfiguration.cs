using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.Enums;
using VeganFit.Entities;

namespace VeganFit.DAL.Concrete.Context.EntityConfigurations
{
    public class FeedbackConfiguration : BaseConfiguration<Feedback>
    {
        /// <summary>
        /// Feedback entity'sinin property'lerinin özelliklerinin belirlendiği metot.
        /// </summary>
        /// <param name="builder"></param>
        public override void Configure(EntityTypeBuilder<Feedback> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Message)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.HasOne<User>(x => x.User)
                .WithMany(x => x.Feedbacks)
                .HasForeignKey(x => x.UserId);

            builder.Property(x => x.UserId).IsRequired(false);

            builder.HasData(new Feedback
            {
                Id = 1,
                UserName = "Aynur",
                Message="Uygulama için çok teşekkür ederim. Her şeyi ile tam istediğim gibi sade basit ve anlaşılır bir uygulamadır. Elinize sağlık",
                CreatedDate = DateTime.Now,
                State = State.Created
            });

            builder.HasData(new Feedback
            {
                Id = 2,
                UserName = "Pelin",
                Message = "Uygulama için teşekkürler. Başarılarınızın devamını dileriz.",
                CreatedDate = DateTime.Now,
                State = State.Created
            });
        }
    }
}
