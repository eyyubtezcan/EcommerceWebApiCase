using EcommerceWebApiCase.Data;
using EcommerceWebApiCase.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApiCase.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        EcommerceDbContext _dbContext;
        public ProductService(EcommerceDbContext context) : base(context)
        {
            _dbContext=context;
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();

        }
    }
}
