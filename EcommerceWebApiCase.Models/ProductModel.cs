namespace EcommerceWebApiCase.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int LanguageId { get; set; }
        public List<ProductTranslationModel> ProductTranslation { get; set; }
        public List<ProductCategoryModel> ProductCategory { get; set; }

    }

    public class ProductTranslationModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; } // Will inserting new data for Every languge
        public int ProductMainId { get; set; }

    }
    public class ProductCategoryModel 
    {

        // Foreign key for Parent Category
        public string Name { get; set; }
        public string Description { get; set; }
        public int LanguageId { get; set; }
    }
}

