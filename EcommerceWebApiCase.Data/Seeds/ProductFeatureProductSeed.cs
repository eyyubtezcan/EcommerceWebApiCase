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
    public class ProductFeatureProductSeed : IEntityTypeConfiguration<ProductFeatureProduct>
    {

        private readonly int[] _ids;

        public ProductFeatureProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<ProductFeatureProduct> builder)
        {
            builder.HasData(
                new ProductFeatureProduct
                {
                    Id = 1,
                    ProductId=1,
                    ProductFeatureId=1,
                    Value="7 inç",
                    IsActive = true,                  
                    CreatedDate = DateTime.Now
                },
                  new ProductFeatureProduct
                  {
                      Id = 2,
                      ProductId = 1,
                      ProductFeatureId = 1,
                      Value = "8 inç",
                      IsActive = true,
                      CreatedDate = DateTime.Now
                  },
                    new ProductFeatureProduct
                    {
                        Id = 3,
                        ProductId = 1,
                        ProductFeatureId = 1,
                        Value = "10 inç",
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    },
                      new ProductFeatureProduct
                      {
                          Id = 4,
                          ProductId = 1,
                          ProductFeatureId = 3,
                          Value = "Siyah",
                          IsActive = true,
                          CreatedDate = DateTime.Now,
                      },
                  new ProductFeatureProduct
                  {
                      Id = 5,
                      ProductId = 1,
                      ProductFeatureId = 3,
                      Value = "Beyaz",
                      IsActive = true,
                      CreatedDate = DateTime.Now
                  },
                    new ProductFeatureProduct
                    {
                        Id = 6,
                        ProductId = 1,
                        ProductFeatureId = 3,
                        Value = "Gümüş",
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    }
               );


        }
    }

}