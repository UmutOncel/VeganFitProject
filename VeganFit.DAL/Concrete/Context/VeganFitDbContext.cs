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
        public virtual DbSet<OptionalProduct> OptionalProducts { get; set; }
        public virtual DbSet<Data> Datas { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Weight> Weights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();  //SQL BAĞLANTI YOLU!!!
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration())
                        .ApplyConfiguration(new ProductConfiguration())
                        .ApplyConfiguration(new OptionalProductConfiguration())
                        .ApplyConfiguration(new DataConfiguration())
                        .ApplyConfiguration(new FeedbackConfiguration())
                        .ApplyConfiguration(new WeightConfiguration());
        }
    }
}
