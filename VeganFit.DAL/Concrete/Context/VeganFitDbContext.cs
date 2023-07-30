using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganFit.DAL.Concrete.Context.EntityConfigurations;
using VeganFit.Entities;

namespace VeganFit.DAL.Concrete.Context
{
    public class VeganFitDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Data> Datas { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Weight> Weights { get; set; }

        /// <summary>
        /// Database bağlantı ayarlarının yapılmasını sağlayan metot.
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sql = @"Server=DESKTOP-JM5LJD8\SQL2022;Database=VeganFitDB;Trusted_Connection = True"; 
            optionsBuilder.UseSqlServer(sql);  //SQL BAĞLANTI YOLU!!!
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        /// <summary>
        /// Database'de oluşturulacak tabloların ayarlarının yapılmasını sağlayan metot.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration())
                        .ApplyConfiguration(new ProductConfiguration())
                        .ApplyConfiguration(new DataConfiguration())
                        .ApplyConfiguration(new FeedbackConfiguration())
                        .ApplyConfiguration(new WeightConfiguration());
        }

    }
}
