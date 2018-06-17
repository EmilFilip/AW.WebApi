using AW.WebApi.BL.ProductSubcategories.Contracts;
using AW.WepApi.BL.DALContracts.ProductSubcategories;
using AW.WepApi.BL.ProductSubcategories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AW.WebApi.BL.ProductSubcategories.Services
{
    public class ProductSubcategoriesService : IProductSubcategoriesService
    {
        private readonly ProductSubcategoriesContract _iProductSubCategoryRepository;

        public ProductSubcategoriesService(ProductSubcategoriesContract iProductSubCategoryRepository)
        {
            _iProductSubCategoryRepository = iProductSubCategoryRepository;
        }

        public async Task<IEnumerable<ProductSubcategoryDto>> GetProductSubcategories()
        {
            return await _iProductSubCategoryRepository.GetProductSubcategories();
        }
        
        public async Task<ProductSubcategoryDto> GetProductSubcategoryById(int subcategoryId)
        {
            return await _iProductSubCategoryRepository.GetProductSubcategoryById(subcategoryId);
        }
        
        public async Task<IEnumerable<ProductSubcategoryDto>> GetProductSubcategoriesByProductCategoryId(int categoryId)
        {
            return await _iProductSubCategoryRepository.GetProductSubcategoriesByProductCategoryId(categoryId);
        }
    }
}