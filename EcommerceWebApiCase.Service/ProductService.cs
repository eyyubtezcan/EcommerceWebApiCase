using EcommerceWebApiCase.Data;
using EcommerceWebApiCase.Data.Entities;
using EcommerceWebApiCase.Models;
using EcommerceWebApiCase.Models.FilterModel;
using Microsoft.EntityFrameworkCore;
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

        public List<ProductModel> GetAllProductsFilter(ProductFilterModel model)
        {
                   
            List<ProductModel> productList=new List<ProductModel>();

            

            var products= from pro in _dbContext.Products
                          from pt in _dbContext.ProductTranslations.Where(x=>x.ProductMainId==pro.Id && x.LanguageId == model.LanguageId)
                          from ptf in _dbContext.ProductFeatures.Where(x => x.CategoryId== pro.CategoryId)
                          from pcat in _dbContext.ProductCategories.Where(x => x.Id== pro.CategoryId)
                          from pcatf in _dbContext.ProductCategoryTranslations.Where(x => x.ProductCategoryMainId == pcat.Id && x.LanguageId == model.LanguageId)
                          where pro.Id==pt.ProductMainId && pro.CategoryId==pcat.Id && pcatf.ProductCategoryMainId==pcat.Id

                          select new ProductModel()
                          {
                              Description=pt.Description,
                              ImageUrl=pro.ImageUrl,
                              LanguageId=model.LanguageId??1,
                              Name=pt.Name,
                              Price=pro.Price,
                              ProductCategory=new List<ProductCategoryModel>() {  },
                              ProductTranslation=new List<ProductTranslationModel>()
                                
                          };



            
            var ddd= products.ToList();

            return products.ToList();
        }
    }
}
