using EcommerceWebApiCase.Data.Entities;
using EcommerceWebApiCase.Models;
using EcommerceWebApiCase.Models.FilterModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApiCase.Service
{
    public interface IProductService:IService<Product>
    {
        public List<Product> GetAllProducts();
        public List<ProductModel> GetAllProductsFilter(ProductFilterModel model);
    }
}
