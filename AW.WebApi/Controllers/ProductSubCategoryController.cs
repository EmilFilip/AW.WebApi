using AW.WebApi.BL.ProductSubcategories.Contracts;
using AW.WepApi.BL.ProductSubcategories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace AW.WebApi.Controllers
{
    public class ProductSubCategoryController : BaseController
    {
        private readonly IProductSubcategoriesService _iProductSubcategoryService;

        public ProductSubCategoryController(IProductSubcategoriesService iProductCategoryService)
        {
            _iProductSubcategoryService = iProductCategoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductSubcategoryDto>> GetProductSubcategories()
        {
            return await _iProductSubcategoryService.GetProductSubcategories();
        }

        [HttpGet]
        public async Task<ProductSubcategoryDto> GetProductSubcategory(int subcategoryId)
        {
            return await _iProductSubcategoryService.GetProductSubcategoryById(subcategoryId);
        }

        [HttpGet]
        public async Task<IEnumerable<ProductSubcategoryDto>> GetProductSubcategoriesByProductCategoryId(int productCategoryId)
        {
            return await _iProductSubcategoryService.GetProductSubcategoriesByProductCategoryId(productCategoryId);
        }
    }
}
