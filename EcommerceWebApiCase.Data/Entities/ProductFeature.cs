using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApiCase.Data.Entities
{
    public class ProductFeature:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int ProductFeatureTypeId { get; set; }
        public ProductCategory Category { get; set; }
        public ProductFeatureType ProductFeatureType { get; set; }
        public ICollection<ProductFeatureProduct> ProductFeatures { get; set; }

    }
    public class ProductFeatureType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProductFeature> ProductFeatures { get; set; }

    }
}
