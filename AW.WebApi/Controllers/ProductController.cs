using AW.WebApi.BL.Products.Contracts;
using AW.WepApi.BL.Product.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace AW.WebApi.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductsService _iProductsService;

        public ProductController(IProductsService iProductsService)
        {
            _iProductsService = iProductsService;
        }

        [HttpGet]
        //[Route("api/products")]
        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            return await _iProductsService.GetProducts();
        }

        [HttpGet]
        public async Task<ProductDto> GetProductById(int productId)
        {
            return await _iProductsService.GetProductById(productId);
        }

        [HttpPost]
        public async Task<bool> CreateProduct(ProductDto product)
        {
            return await _iProductsService.CreateProduct(product);
        }

        [HttpPut]
        public async Task<bool> UpdateProduct([FromBody]ProductDto product)
        {
            return await _iProductsService.UpdateProduct(product);
        }

        [HttpDelete]
        [Route("api/DeleteProduct/{productId}")]
        public async Task<bool> DeleteProduct(int productId)
        {
            return await _iProductsService.DeleteProduct(productId);
        }

        [HttpGet]
        [Route("api/GetProductsByProductSubCategory/{productId}")]
        public async Task<IEnumerable<ProductDto>> GetProductsByProductSubCategory(int productId)
        {
            return await _iProductsService.GetProductsByProductSubCategory(productId);
        }
    }
}
