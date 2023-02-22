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
    public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {

        private readonly int[] _ids;

        public ProductFeatureSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature
                {
                    Id = 1,
                    Description = "Ekran Boyutu (İnç Cinsinden)",
                    Name = "Ekran Boyutu",
                    CategoryId = 3,
                    IsActive = true,
                    ProductFeatureTypeId = 1,
                    CreatedDate = DateTime.Now
                },
            new ProductFeature
            {
                Id = 2,
                Description = "İşlemci Hızı",
                Name = "İşlemci Hızı",
                CategoryId = 3,
                IsActive = true,
                ProductFeatureTypeId=1,
                CreatedDate = DateTime.Now
            },
               new ProductFeature
               {
                   Id = 3,
                   Description = "Renk",
                   Name = "Renk",
                   CategoryId = 3,
                   IsActive = true,
                   ProductFeatureTypeId = 1,
                   CreatedDate = DateTime.Now
               },
                new ProductFeature
                {
                    Id = 4,
                    Description = "Pil Kapasitesi",
                    Name = "Pil Kapasitesi",
                    CategoryId = 3,
                    IsActive = true,
                    ProductFeatureTypeId = 1,
                    CreatedDate = DateTime.Now
                }

               );


        }
    }

}