using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApiCase.Data.Entities
{
    public class ProductCategory:BaseEntity
    {
     
        // Foreign key for Parent Category
        public int? ParentCategoryId { get; set; }
        public ProductCategory ParentCategory { get; set; }
        public ICollection<ProductCategoryTranslation> Translations { get; set; }
        public ICollection<ProductCategory> ChildCategories { get; set; }
        public ICollection<Product> Products { get; set; }
    }

    public class ProductCategoryTranslation : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; } // Will inserting new data for Every languge
        public int ProductCategoryMainId { get; set; }
        public Language Language { get; set; }
        public ProductCategory ProductCategoryMain { get; set; }
       

    }
}
