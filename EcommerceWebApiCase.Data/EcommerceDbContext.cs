using EcommerceWebApiCase.Data.Entities;
using EcommerceWebApiCase.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApiCase.Data
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext()
        {
        }

        //public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options) { }

        public DbSet<Language> Languages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
 
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductCategoryTranslation> ProductCategoryTranslations { get; set; }
        public DbSet<ProductFeatureProduct> ProductFeatureProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=EcommerceProjectDb; user=sa; password=test123;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new LanguageSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new ProductCategorySeed(new int[] { 1, 2 ,3}));
            modelBuilder.ApplyConfiguration(new ProductCategoryTranslationSeed(new int[] { 1, 2,3,4 }));

            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1 }));
            modelBuilder.ApplyConfiguration(new ProductTranslationSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new ProductFeatureSeed(new int[] { 1, 2,3,4 }));
            modelBuilder.ApplyConfiguration(new ProductFeatureTypeSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new ProductFeatureProductSeed(new int[] { 1, 2,3,4,5,6 }));



        }
    }
}
