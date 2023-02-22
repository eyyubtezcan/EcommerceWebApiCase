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
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {

        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 3,
                    Price = 500,
                    ImageUrl = "img/product/product.jpg",                   
                    IsActive = true,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now
                });
               
      
        }
    }


    public class ProductTranslationSeed : IEntityTypeConfiguration<ProductTranslation>
    {

        private readonly int[] _ids;

        public ProductTranslationSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            builder.HasData(
                new ProductTranslation
                {
                    Id = 1,
                    Description = "Samsung Tablet 16 Gb ......",
                    Name = "Samsung Tablet",
                    LanguageId = 1,
                    ProductMainId = 1,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                  new ProductTranslation
                  {
                      Id = 2,
                      Description = "Eng Samsung Tablet 16 Gb ......",
                      Name = "Samsung Tablet Eng",
                      LanguageId = 2,
                      ProductMainId = 1,
                      IsActive = true,
                      CreatedDate = DateTime.Now,
                      UpdatedDate = DateTime.Now
                  });


        }
    }
}


