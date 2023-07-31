using Microsoft.EntityFrameworkCore;
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

            builder.Property(x => x.RecordDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.HasOne<User>(x => x.User)
                .WithMany(x => x.Weights)
                .HasForeignKey(x => x.UserId);

            builder.Property(x => x.UserId).IsRequired(false);

            builder.HasData(new Weight
            {
                Id = 1,
                UserName = "Pelin",
                UserWeight = 67,
                RecordDate = DateTime.Parse("31/07/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 2,
                UserName = "Pelin",
                UserWeight = 67,
                RecordDate = DateTime.Parse("30/07/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 3,
                UserName = "Pelin",
                UserWeight = 67,
                RecordDate = DateTime.Parse("29/07/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 4,
                UserName = "Pelin",
                UserWeight = 67,
                RecordDate = DateTime.Parse("28/07/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 5,
                UserName = "Pelin",
                UserWeight = 66,
                RecordDate = DateTime.Parse("27/07/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 6,
                UserName = "Pelin",
                UserWeight = 66,
                RecordDate = DateTime.Parse("26/07/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 7,
                UserName = "Pelin",
                UserWeight = 66,
                RecordDate = DateTime.Parse("25/07/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 8,
                UserName = "Pelin",
                UserWeight = 65,
                RecordDate = DateTime.Parse("24/07/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 9,
                UserName = "Pelin",
                UserWeight = 65,
                RecordDate = DateTime.Parse("23/07/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 10,
                UserName = "Pelin",
                UserWeight = 65,
                RecordDate = DateTime.Parse("22/07/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 11,
                UserName = "Pelin",
                UserWeight = 64.5,
                RecordDate = DateTime.Parse("22/07/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            });


            builder.HasData(new Weight
            {
                Id = 12,
                UserName = "Aynur",
                UserWeight = 58,
                RecordDate = DateTime.Parse("20/06/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 13,
                UserName = "Aynur",
                UserWeight = 58,
                RecordDate = DateTime.Parse("19/06/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 14,
                UserName = "Aynur",
                UserWeight = 58,
                RecordDate = DateTime.Parse("18/06/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 15,
                UserName = "Aynur",
                UserWeight = 58,
                RecordDate = DateTime.Parse("17/06/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 16,
                UserName = "Aynur",
                UserWeight = 58,
                RecordDate = DateTime.Parse("16/06/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 17,
                UserName = "Aynur",
                UserWeight = 57.5,
                RecordDate = DateTime.Parse("15/06/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 18,
                UserName = "Aynur",
                UserWeight = 57.5,
                RecordDate = DateTime.Parse("14/06/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 19,
                UserName = "Aynur",
                UserWeight = 56,
                RecordDate = DateTime.Parse("13/06/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 20,
                UserName = "Aynur",
                UserWeight = 56,
                RecordDate = DateTime.Parse("12/06/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 21,
                UserName = "Aynur",
                UserWeight = 55,
                RecordDate = DateTime.Parse("11/06/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            },
            new Weight
            {
                Id = 22,
                UserName = "Aynur",
                UserWeight = 54.5,
                RecordDate = DateTime.Parse("10/06/2023"),
                CreatedDate = DateTime.Now,
                State = State.Created
            });

        }
    }
}
