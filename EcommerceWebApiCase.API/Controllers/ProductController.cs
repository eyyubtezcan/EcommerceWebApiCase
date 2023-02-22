using EcommerceWebApiCase.Data.Entities;
using EcommerceWebApiCase.Service;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebApiCase.API.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPost("Stock")]
        public async Task<IEnumerable<Product>> GetCustomersVariantCodeStock(List<Product> stockList)
        {
           
            var result =  _service.GetAllProducts();

            return result;

        }
    }
}
