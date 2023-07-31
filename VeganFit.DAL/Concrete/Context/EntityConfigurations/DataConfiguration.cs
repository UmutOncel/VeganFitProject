using Microsoft.EntityFrameworkCore;
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
    public class DataConfiguration : BaseConfiguration<Data>
    {
        /// <summary>
        /// Data entity'sinin property'lerinin özelliklerinin belirlendiği metot.
        /// </summary>
        /// <param name="builder"></param>
        public override void Configure(EntityTypeBuilder<Data> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Calori)
                .IsRequired();

            builder.Property(x => x.Datetime)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(x => x.Meal)
                .IsRequired()
                .HasConversion(new EnumToStringConverter<Meal>());

            builder.HasOne<User>(x => x.User)
                .WithMany(x => x.Datas)
                .HasForeignKey(x => x.UserId);

            builder.HasOne<Product>(x => x.Product)
                .WithMany(x => x.Datas)
                .HasForeignKey(x => x.ProductId);

            builder.Property(x => x.ProductId).IsRequired(false);
            builder.Property(x => x.UserId).IsRequired(false);

            builder.Property(x => x.UserEmail)
                   .IsRequired(false)
                   .HasMaxLength(250);

            builder.HasData(new Data
            { Id = 1, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Kepekli Ekmek", Calori = 100, Datetime = DateTime.Parse("31/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 2, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Elma", Calori = 116, Datetime = DateTime.Parse("31/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 3, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Ceviz", Calori = 220, Datetime = DateTime.Parse("31/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 4, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Kayısı", Calori = 50, Datetime = DateTime.Parse("31/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 5, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Badem", Calori = 174, Datetime = DateTime.Parse("31/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 6, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Çilek", Calori = 80, Datetime = DateTime.Parse("31/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 7, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Karpuz", Calori = 250, Datetime = DateTime.Parse("31/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 8, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Bulgur Pilavı", Calori = 350, Datetime = DateTime.Parse("31/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 9, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Müsli", Calori = 150, Datetime = DateTime.Parse("31/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 10, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Nar", Calori = 330, Datetime = DateTime.Parse("30/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 11, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Vegan Sade Peynir", Calori = 300, Datetime = DateTime.Parse("30/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 12, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Portakal", Calori = 230, Datetime = DateTime.Parse("30/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 13, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Turşu", Calori = 190, Datetime = DateTime.Parse("30/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 14, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Domates Çorbası", Calori = 120, Datetime = DateTime.Parse("30/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 15, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Patates Salatası", Calori = 150, Datetime = DateTime.Parse("30/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 16, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Yulaf Ezmesi", Calori = 390, Datetime = DateTime.Parse("29/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 17, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Vegan Sade Peynir", Calori = 340, Datetime = DateTime.Parse("29/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 18, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Yeşil Çay", Calori = 50, Datetime = DateTime.Parse("29/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 19, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Turşu", Calori = 169, Datetime = DateTime.Parse("29/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 20, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Mücver", Calori = 320, Datetime = DateTime.Parse("29/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 21, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Armut", Calori = 190, Datetime = DateTime.Parse("29/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 22, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Kuru Üzüm", Calori = 90, Datetime = DateTime.Parse("28/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 23, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Muzlu Vegan Fransız Tostu", Calori = 146, Datetime = DateTime.Parse("28/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 24, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Yeşil Çay", Calori = 50, Datetime = DateTime.Parse("28/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 25, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Çok Tahıllı Ekmek", Calori = 120, Datetime = DateTime.Parse("28/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 26, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Zeytinyağlı Taze Fasulye", Calori = 329, Datetime = DateTime.Parse("28/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 27, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Ratatouille", Calori = 240, Datetime = DateTime.Parse("28/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 28, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Mandalina", Calori = 90, Datetime = DateTime.Parse("27/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 29, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Müsli", Calori = 180, Datetime = DateTime.Parse("27/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 30, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Karışık Sebze", Calori = 190, Datetime = DateTime.Parse("27/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 31, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Portakal Suyu", Calori = 150, Datetime = DateTime.Parse("27/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 32, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Zeytinyağlı Taze Fasulye", Calori = 245, Datetime = DateTime.Parse("27/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 33, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Fırında Domatesli Kabak Dilimleri", Calori = 266, Datetime = DateTime.Parse("27/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 34, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Siyah Zeytin", Calori = 222, Datetime = DateTime.Parse("26/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 35, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Badem Sütü", Calori = 328, Datetime = DateTime.Parse("26/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 36, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Karışık Sebze", Calori = 230, Datetime = DateTime.Parse("26/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 37, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Mantar ve Pırasalı Tofu", Calori = 253, Datetime = DateTime.Parse("26/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 38, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Domates Çorbası", Calori = 200, Datetime = DateTime.Parse("26/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 39, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Yaban Mersinli Kinoa Lapası", Calori = 336, Datetime = DateTime.Parse("26/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 40, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Siyah Zeytin", Calori = 242, Datetime = DateTime.Parse("25/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 41, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Badem Sütü", Calori = 138, Datetime = DateTime.Parse("25/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 42, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Maydonoz", Calori = 110, Datetime = DateTime.Parse("25/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 43, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Ispanaklı Pizza", Calori = 267, Datetime = DateTime.Parse("25/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 44, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Domates Çorbası", Calori = 221, Datetime = DateTime.Parse("25/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 45, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Şeftali Püreli Tatlı Kuskus", Calori = 336, Datetime = DateTime.Parse("25/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 46, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Yeşil Biber", Calori = 123, Datetime = DateTime.Parse("24/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 47, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Portakal Suyu", Calori = 140, Datetime = DateTime.Parse("24/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 48, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Patates Salatası", Calori = 169, Datetime = DateTime.Parse("24/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 49, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Burger", Calori = 320, Datetime = DateTime.Parse("24/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 50, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Domates Çorbası", Calori = 200, Datetime = DateTime.Parse("24/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 51, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Sebzeli Makarna", Calori = 170, Datetime = DateTime.Parse("24/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 52, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Kepekli Ekmek", Calori = 120, Datetime = DateTime.Parse("23/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 53, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Vegan Sade Peynir", Calori = 345, Datetime = DateTime.Parse("23/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 54, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Elma", Calori = 140, Datetime = DateTime.Parse("23/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 55, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Bulgur Pilavı", Calori = 227, Datetime = DateTime.Parse("23/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 56, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Karpuz", Calori = 230, Datetime = DateTime.Parse("23/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 57, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Ispanaklı Börek", Calori = 330, Datetime = DateTime.Parse("23/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 58, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Kuru Üzüm", Calori = 120, Datetime = DateTime.Parse("22/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 59, UserEmail = "pelin@gmail.com", Meal = Meal.Sabah, ProductName = "Yeşil Çay", Calori = 80, Datetime = DateTime.Parse("22/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 60, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Elma", Calori = 150, Datetime = DateTime.Parse("22/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 61, UserEmail = "pelin@gmail.com", Meal = Meal.Öğle, ProductName = "Avokado Soslu Patetes", Calori = 330, Datetime = DateTime.Parse("22/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 62, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Şeftali Püreli Tatlı Kuskus", Calori = 400, Datetime = DateTime.Parse("22/07/2023"), CreatedDate = DateTime.Now, State = State.Created },
            new Data
            { Id = 63, UserEmail = "pelin@gmail.com", Meal = Meal.Akşam, ProductName = "Mantarlı Kinoa Risotto", Calori = 300, Datetime = DateTime.Parse("22/07/2023"), CreatedDate = DateTime.Now, State = State.Created });



            builder.HasData(new Data
            { Id = 64, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Kepekli Ekmek", Calori = 80, Datetime = DateTime.Parse("20/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 65, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Elma", Calori = 120, Datetime = DateTime.Parse("20/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 66, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Ceviz", Calori = 200, Datetime = DateTime.Parse("20/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 67, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Kayısı", Calori = 60, Datetime = DateTime.Parse("20/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 68, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Badem", Calori = 180, Datetime = DateTime.Parse("20/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 69, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Çilek", Calori = 100, Datetime = DateTime.Parse("20/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 70, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Karpuz", Calori = 220, Datetime = DateTime.Parse("20/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 71, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Bulgur Pilavı", Calori = 360, Datetime = DateTime.Parse("20/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 72, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Müsli", Calori = 180, Datetime = DateTime.Parse("20/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 73, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Nar", Calori = 300, Datetime = DateTime.Parse("19/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 74, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Vegan Sade Peynir", Calori = 320, Datetime = DateTime.Parse("19/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 75, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Portakal", Calori = 200, Datetime = DateTime.Parse("19/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 76, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Turşu", Calori = 200, Datetime = DateTime.Parse("19/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 77, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Domates Çorbası", Calori = 130, Datetime = DateTime.Parse("19/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 78, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Patates Salatası", Calori = 160, Datetime = DateTime.Parse("19/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 79, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Yulaf Ezmesi", Calori = 400, Datetime = DateTime.Parse("18/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 80, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Vegan Sade Peynir", Calori = 350, Datetime = DateTime.Parse("18/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 81, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Yeşil Çay", Calori = 60, Datetime = DateTime.Parse("18/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 82, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Turşu", Calori = 180, Datetime = DateTime.Parse("18/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 83, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Mücver", Calori = 360, Datetime = DateTime.Parse("18/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 84, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Armut", Calori = 200, Datetime = DateTime.Parse("18/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 85, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Kuru Üzüm", Calori = 100, Datetime = DateTime.Parse("17/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 86, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Muzlu Vegan Fransız Tostu", Calori = 180, Datetime = DateTime.Parse("17/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 87, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Yeşil Çay", Calori = 80, Datetime = DateTime.Parse("17/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 88, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Çok Tahıllı Ekmek", Calori = 125, Datetime = DateTime.Parse("17/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 89, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Zeytinyağlı Taze Fasulye", Calori = 350, Datetime = DateTime.Parse("17/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 90, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Ratatouille", Calori = 250, Datetime = DateTime.Parse("17/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 91, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Mandalina", Calori = 100, Datetime = DateTime.Parse("16/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 92, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Müsli", Calori = 190, Datetime = DateTime.Parse("16/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 93, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Karışık Sebze", Calori = 200, Datetime = DateTime.Parse("16/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 94, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Portakal Suyu", Calori = 160, Datetime = DateTime.Parse("16/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 95, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Zeytinyağlı Taze Fasulye", Calori = 250, Datetime = DateTime.Parse("16/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 96, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Fırında Domatesli Kabak Dilimleri", Calori = 250, Datetime = DateTime.Parse("16/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 97, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Siyah Zeytin", Calori = 200, Datetime = DateTime.Parse("15/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 98, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Badem Sütü", Calori = 300, Datetime = DateTime.Parse("15/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 99, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Karışık Sebze", Calori = 200, Datetime = DateTime.Parse("15/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 100, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Mantar ve Pırasalı Tofu", Calori = 240, Datetime = DateTime.Parse("15/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 101, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Domates Çorbası", Calori = 180, Datetime = DateTime.Parse("15/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 102, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Yaban Mersinli Kinoa Lapası", Calori = 290, Datetime = DateTime.Parse("15/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 103, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Siyah Zeytin", Calori = 230, Datetime = DateTime.Parse("14/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 104, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Badem Sütü", Calori = 150, Datetime = DateTime.Parse("14/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 105, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Maydonoz", Calori = 150, Datetime = DateTime.Parse("14/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 106, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Ispanaklı Pizza", Calori = 300, Datetime = DateTime.Parse("14/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 107, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Domates Çorbası", Calori = 250, Datetime = DateTime.Parse("14/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 108, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Şeftali Püreli Tatlı Kuskus", Calori = 300, Datetime = DateTime.Parse("14/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 109, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Yeşil Biber", Calori = 150, Datetime = DateTime.Parse("13/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 110, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Portakal Suyu", Calori = 231, Datetime = DateTime.Parse("13/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 111, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Patates Salatası", Calori = 264, Datetime = DateTime.Parse("13/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 112, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Burger", Calori = 250, Datetime = DateTime.Parse("13/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 113, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Domates Çorbası", Calori = 160, Datetime = DateTime.Parse("13/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 114, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Sebzeli Makarna", Calori = 200, Datetime = DateTime.Parse("13/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 115, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Kepekli Ekmek", Calori = 100, Datetime = DateTime.Parse("12/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 116, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Vegan Sade Peynir", Calori = 400, Datetime = DateTime.Parse("12/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 117, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Elma", Calori = 146, Datetime = DateTime.Parse("12/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 118, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Bulgur Pilavı", Calori = 342, Datetime = DateTime.Parse("12/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 119, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Karpuz", Calori = 344, Datetime = DateTime.Parse("12/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 120, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Ispanaklı Börek", Calori = 342, Datetime = DateTime.Parse("12/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 121, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Kuru Üzüm", Calori = 123, Datetime = DateTime.Parse("11/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 122, UserEmail = "aynur@gmail.com", Meal = Meal.Sabah, ProductName = "Yeşil Çay", Calori = 80, Datetime = DateTime.Parse("11/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 123, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Elma", Calori = 120, Datetime = DateTime.Parse("11/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 124, UserEmail = "aynur@gmail.com", Meal = Meal.Öğle, ProductName = "Avokado Soslu Patetes", Calori = 221, Datetime = DateTime.Parse("11/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 125, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Şeftali Püreli Tatlı Kuskus", Calori = 344, Datetime = DateTime.Parse("11/06/2023"), CreatedDate = DateTime.Now, State = State.Created },
           new Data
           { Id = 126, UserEmail = "aynur@gmail.com", Meal = Meal.Akşam, ProductName = "Mantarlı Kinoa Risotto", Calori = 255, Datetime = DateTime.Parse("11/06/2023"), CreatedDate = DateTime.Now, State = State.Created });







        }
    }
}
