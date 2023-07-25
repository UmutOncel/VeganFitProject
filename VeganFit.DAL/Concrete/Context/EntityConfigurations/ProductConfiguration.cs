using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.Core.Enums;
using VeganFit.Entities;

namespace VeganFit.DAL.Concrete.Context.EntityConfigurations
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        /// <summary>
        /// Product entity'sinin property'lerinin özelliklerinin belirlendiği metot.
        /// </summary>
        /// <param name="builder"></param>
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ProductName)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasIndex(x => x.ProductName)
                   .IsUnique();

            builder.Property(x => x.Calori)
                   .IsRequired();

            builder.Property(x => x.Serving)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(x => x.Picture).HasColumnType("Image")
                   .IsRequired(false);


            builder.HasData(
             new Product
             { Id = 1, ProductName = "Kepekli Ekmek", Calori = 128, Serving = "46", Picture = null },
             new Product
             { Id = 2, ProductName = "Elma", Calori = 116, Serving = "223", Picture = null },
             new Product
             { Id = 3, ProductName = "Ceviz", Calori = 193, Serving = "30", Picture = null },
             new Product
             { Id = 4, ProductName = "Muz", Calori = 105, Serving = "223", Picture = null },
             new Product
             { Id = 5, ProductName = "Maydonoz", Calori = 1.5, Serving = "0.5", Picture = null },
             new Product
             { Id = 6, ProductName = "Siyah Zeytin", Calori = 16, Serving = "15.2", Picture = null },
             new Product
             { Id = 7, ProductName = "Yeşil Biber", Calori = 32.8, Serving = "164", Picture = null },
             new Product
             { Id = 8, ProductName = "Kayısı", Calori = 16.8, Serving = "35", Picture = null },
             new Product
             { Id = 9, ProductName = "Mercimek Çorbası", Calori = 75, Serving = "100", Picture = null },
             new Product
             { Id = 10, ProductName = "Badem", Calori = 174, Serving = "30", Picture = null },
             new Product
             { Id = 11, ProductName = "Badem Sütü", Calori = 39.3, Serving = "262", Picture = null },
             new Product
             { Id = 12, ProductName = "Çilek", Calori = 8.6, Serving = "27", Picture = null },
             new Product
             { Id = 13, ProductName = "Portakal", Calori = 86.5, Serving = "184", Picture = null },
             new Product
             { Id = 14, ProductName = "Domates", Calori = 22.1, Serving = "123", Picture = null },
             new Product
             { Id = 15, ProductName = "Müsli", Calori = 96.4, Serving = "28.2", Picture = null },
             new Product
             { Id = 16, ProductName = "Nar", Calori = 234, Serving = "282", Picture = null },
             new Product
             { Id = 17, ProductName = "Kepekli Grissini", Calori = 116, Serving = "100", Picture = null },
             new Product
             { Id = 18, ProductName = "Vegan Sade Peynir", Calori = 30, Serving = "87.3", Picture = null },
             new Product
             { Id = 20, ProductName = "Bulgur Pilavı", Calori = 116, Serving = "89.2", Picture = null },
             new Product
             { Id = 21, ProductName = "Zeytin Yağı", Calori = 119, Serving = "13.5", Picture = null },
             new Product
             { Id = 22, ProductName = "Konserve Yeşil Bezelye", Calori = 116, Serving = "163", Picture = null },
             new Product
             { Id = 23, ProductName = "Karpuz", Calori = 85.8, Serving = "286", Picture = null },
             new Product
             { Id = 24, ProductName = "Mandalina", Calori = 15, Serving = "23.8", Picture = null },
             new Product
             { Id = 25, ProductName = "Ispanaklı Börek", Calori = 74.8, Serving = "28.4", Picture = null },
             new Product
             { Id = 26, ProductName = "Turşu", Calori = 4.2, Serving = "35", Picture = null },
             new Product
             { Id = 27, ProductName = "Domates Çorbası", Calori = 79.4, Serving = "248", Picture = null },
             new Product
             { Id = 28, ProductName = "Patates Salatası", Calori = 358, Serving = "250", Picture = null },
             new Product
             { Id = 29, ProductName = "Yulaf Ezmesi", Calori = 166, Serving = "234", Picture = null },
             new Product
             { Id = 30, ProductName = "Karışık Sebze", Calori = 79.9, Serving = "163", Picture = null },
             new Product
             { Id = 31, ProductName = "Kuru Üzüm", Calori = 41.9, Serving = "14", Picture = null },
             new Product
             { Id = 32, ProductName = "Çok Tahıllı Ekmek", Calori = 68.9, Serving = "26", Picture = null },
             new Product
             { Id = 33, ProductName = "Sebzeli Makarna", Calori = 125, Serving = "100", Picture = null },
             new Product
             { Id = 34, ProductName = "Portakal Suyu", Calori = 38.7, Serving = "86", Picture = null },
             new Product
             { Id = 35, ProductName = "Yeşil Çay", Calori = 2.5, Serving = "245", Picture = null },
             new Product
             { Id = 36, ProductName = "Zeytinyağlı Taze Fasulye", Calori = 16, Serving = "20.3", Picture = null },
             new Product
             { Id = 37, ProductName = "Ezogelin Çorbası", Calori = 52, Serving = "100", Picture = null },
             new Product
             { Id = 38, ProductName = "Mücver", Calori = 86, Serving = "74.8", Picture = null },
             new Product
             { Id = 39, ProductName = "Portakal Suyu", Calori = 38.7, Serving = "156", Picture = null },
             new Product
             { Id = 40, ProductName = "Burger", Calori = 106, Serving = "100", Picture = null },
             new Product
             { Id = 41, ProductName = "Ratatouille", Calori = 26, Serving = "100", Picture = null },
             new Product
             { Id = 42, ProductName = "Ispanaklı Pizza", Calori = 129, Serving = "100", Picture = null },
             new Product
             { Id = 43, ProductName = "Mantarlı Kinoa Risotto", Calori = 110, Serving = "100", Picture = null },
             new Product
             { Id = 44, ProductName = "Fırında Domatesli Kabak Dilimleri", Calori = 45, Serving = "100", Picture = null },
             new Product
             { Id = 45, ProductName = "Muzlu Vegan Fransız Tostu", Calori = 164, Serving = "100", Picture = null },
             new Product
             { Id = 46, ProductName = "Avokado Soslu Patetes", Calori = 80, Serving = "100", Picture = null },
             new Product
             { Id = 47, ProductName = "Mantar ve Pırasalı Tofu", Calori = 92, Serving = "100", Picture = null },
             new Product
             { Id = 48, ProductName = "Patates ve Roka Çorbası", Calori = 47, Serving = "100", Picture = null },
             new Product
             { Id = 49, ProductName = "Şeftali Püreli Tatlı Kuskus", Calori = 140, Serving = "100", Picture = null },
             new Product
             { Id = 50, ProductName = "Yaban Mersinli Kinoa Lapası", Calori = 68, Serving = "100", Picture = null }
             );




































           

        }
    }
}
