using AW.WebApi.BL.ProductCategories.Contracts;
using AW.WepApi.BL.ProductCategories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace AW.WebApi.Controllers
{
    public class ProductCategoryController : BaseController
    {
        private readonly IProductCategoriesService _iProductCategoryService;

        public ProductCategoryController(IProductCategoriesService iProductCategoryService)
        {
            _iProductCategoryService = iProductCategoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductCategoryDto>> GetProductCategories()
        {
            return await _iProductCategoryService.GetProductCategories();
        }

        [HttpGet]
        public async Task<ProductCategoryDto> GetProductCategoryByProductId(int productId)
        {
            return await _iProductCategoryService.GetProductCategoryByProductId(productId);
        }
    }
}
