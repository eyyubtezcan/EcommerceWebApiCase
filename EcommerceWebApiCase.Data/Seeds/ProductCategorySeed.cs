using EcommerceWebApiCase.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApiCase.Data.Seeds
{
    public class ProductCategorySeed : IEntityTypeConfiguration<ProductCategory>
    {

        private readonly int[] _ids;

        public ProductCategorySeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasData(
                new ProductCategory
                {
                    Id = 1,
                    ParentCategoryId = null,
                    IsActive = true,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now
                },
               new ProductCategory
               {
                   Id = 2,
                   ParentCategoryId = null,
                   IsActive = true,
                   UpdatedDate = DateTime.Now,
                   CreatedDate = DateTime.Now
               },
            new ProductCategory
            {
                Id = 3,
                ParentCategoryId = 1,
                IsActive = true,
                UpdatedDate = DateTime.Now,
                CreatedDate = DateTime.Now
            });
        }
    }
    public class ProductCategoryTranslationSeed : IEntityTypeConfiguration<ProductCategoryTranslation>
    {

        private readonly int[] _ids;

        public ProductCategoryTranslationSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<ProductCategoryTranslation> builder)
        {
            builder.HasData(

            new ProductCategoryTranslation
            {
                Id = 1,
                Name = "Elektronik",
                Description = "Elektronik ürünler bu kategoride bulunmaktadır",
                LanguageId = 1,
                ProductCategoryMainId = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new ProductCategoryTranslation
            {
                Id = 2,
                Name = "Electronics",
                Description = "Electronic products are in this category",
                LanguageId = 2,
                ProductCategoryMainId = 1,
                IsActive = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },

            new ProductCategoryTranslation
            {
                Id = 3,
                Name = "Tabletler",
                Description = "Tabletler bu kategoride bulunmaktadır",
                LanguageId = 1,
                ProductCategoryMainId = 3,
                IsActive = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },

            new ProductCategoryTranslation
            {
                Id = 4,
                Name = "Tablets",
                Description = "Tablets are in this category",
                LanguageId = 2,
                ProductCategoryMainId = 3,
                IsActive = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            });

        }
    }
}
