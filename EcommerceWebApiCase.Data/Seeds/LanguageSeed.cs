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
    public class LanguageSeed: IEntityTypeConfiguration<Language>
    {

        private readonly int[] _ids;

        public LanguageSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(
                new Language
                {
                    Id = 1,
                    Name = "Türkçe",
                    Code = "tr",
                    Description = "Türkçe",
                    IsActive = true,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now
                },
               new Language
               {
                   Id = 2,
                   Name = "İngilizce",
                   Code = "en",
                   Description = "İngilizce",
                   IsActive = true,
                   UpdatedDate = DateTime.Now,
                   CreatedDate = DateTime.Now
               });
        }
    }
}
