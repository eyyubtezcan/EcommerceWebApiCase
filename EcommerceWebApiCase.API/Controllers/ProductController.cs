using EcommerceWebApiCase.Data.Entities;
using EcommerceWebApiCase.Models;
using EcommerceWebApiCase.Models.FilterModel;
using EcommerceWebApiCase.Service;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebApiCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet("Products")]
        public async Task<IEnumerable<Product>> GetProducts()
        {
           
            var result =  _service.GetAllProducts();

            return result;

        }
        [HttpPost("Products2")]
        public async Task<IEnumerable<ProductModel>> GetProducts(ProductFilterModel model)
        {

            var result = _service.GetAllProductsFilter(model);

            return result;

        }
    }
}
