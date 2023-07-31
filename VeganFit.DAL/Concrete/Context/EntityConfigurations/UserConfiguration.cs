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

            builder.HasData(new User
            {
                Id = 1,
                Firstname = "Umut",
                Lastname = "Öncel",
                Password = "EF359CE6F0005B1AE73F70F675AA50E8E18BEA9DED1C30957C2769BB99ADF4E9",//Şİfre AAaa11**
                Email = "admin@gmail.com",
                BirthDate = DateTime.Parse("11/04/1991"),
                Role = Role.Admin,
                CreatedDate = DateTime.Now,
                State = State.Created
            });

            builder.HasData(new User
            {
                Id = 2,
                Firstname = "Pelin",
                Lastname = "Uru",
                Password = "B8667A10663F6E4222C5BC68D4E3CB22B51C7812CFB45EE687B60E3F850FC896",//Şifre Aa1*
                Email = "pelin@gmail.com",
                BirthDate = DateTime.Parse("11/06/1967"),
                Role = Role.StandartUser,
                CreatedDate = DateTime.Now,
                State = State.Created
            });

            builder.HasData(new User
            {
                Id = 3,
                Firstname = "Aynur",
                Lastname = "Aydın",
                Password = "B7E5671FA183586670E8CF95B06AB3A574B94867B3670F433C8B43EE41714AEA",//Şifre Bb2:
                Email = "aynur@gmail.com",
                BirthDate = DateTime.Parse("11/06/1960"),
                Role = Role.StandartUser,
                CreatedDate = DateTime.Now,
                State = State.Created
            });
        }
    }
}
