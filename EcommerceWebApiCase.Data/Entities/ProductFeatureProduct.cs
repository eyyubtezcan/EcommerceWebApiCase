using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApiCase.Data.Entities
{
    
    public class ProductFeatureProduct:BaseEntity
    {
        public string Value { get; set; }
        [ForeignKey("Product"), Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("ProductFeature")]
        public int ProductFeatureId { get; set; }
        public ProductFeature ProductFeature { get; set; }
        
    }
}
