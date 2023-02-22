using EcommerceWebApiCase.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApiCase.Data.Seeds
{
    public class ProductFeatureTypeSeed : IEntityTypeConfiguration<ProductFeatureType>
    {

        private readonly int[] _ids;

        public ProductFeatureTypeSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<ProductFeatureType> builder)
        {
            builder.HasData(
                new ProductFeatureType
                {
                    Id = 1,
                    Name = "Lookup",
                    Description = "Çoktan Seçmeli",
                    IsActive = true,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now
                },
                 new ProductFeatureType
                 {
                     Id = 2,
                     Name = "CheckBox",
                     Description = "Var veya Yok",
                     IsActive = true,
                     UpdatedDate = DateTime.Now,
                     CreatedDate = DateTime.Now
                 });


        }
    }
}
