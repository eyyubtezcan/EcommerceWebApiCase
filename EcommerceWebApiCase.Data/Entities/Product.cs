using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApiCase.Data.Entities
{
    public class Product:BaseEntity
    {
        
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        // Foreign key for Category
        public int CategoryId { get; set; }
        public ProductCategory Category { get; set; }
        public ICollection<ProductTranslation> Translations { get; set; }
        public ICollection<ProductFeatureProduct> ProductFeatureProducts { get; set; }
    }

    public class ProductTranslation : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; } // Will inserting new data for Every languge
        public int ProductMainId { get; set; }
        public Language Language { get; set; }
        public Product ProductMain { get; set; }


    }
}

