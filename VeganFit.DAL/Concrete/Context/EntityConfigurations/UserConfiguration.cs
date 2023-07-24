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
    public class UserConfiguration : BaseConfiguration<User>
    {
        /// <summary>
        /// User entity'sinin property'lerinin özelliklerinin belirlendiği metot.
        /// </summary>
        /// <param name="builder"></param>
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Firstname)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Lastname)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Password)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(250)
                .IsRequired();

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.Property(x => x.BirthDate)
                .IsRequired();

            builder.Property(x => x.Role)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<Role>());

            builder.HasData(new User { Id = 1,
                                       Firstname = "Umut",
                                       Lastname = "Öncel",
                                       Password = "UUuu1991**",
                                       Email = "admin@gmail.com",
                                       BirthDate = DateTime.Parse("11/04/1991"),
                                       Role = Role.Admin,
                                       CreatedDate = DateTime.Now,
                                       State = State.Created });
        }
    }
}
