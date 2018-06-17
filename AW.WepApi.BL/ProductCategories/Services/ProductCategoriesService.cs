using AW.WebApi.BL.ProductCategories.Contracts;
using AW.WepApi.BL.DALContracts.ProductCategories;
using AW.WepApi.BL.ProductCategories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AW.WebApi.BL.ProductCategories.Services
{
    public class ProductCategoriesService : IProductCategoriesService
    {
        private readonly IProductCategoriesContract _iProductCategoryRepositoryContract;

        public ProductCategoriesService(IProductCategoriesContract iProductCategoryRepositoryContract)
        {
            _iProductCategoryRepositoryContract = iProductCategoryRepositoryContract;
        }

        public async Task<IEnumerable<ProductCategoryDto>> GetProductCategories()
        {
            return await _iProductCategoryRepositoryContract.GetProductCategories();
        }

        public Task<ProductCategoryDto> GetProductCategoryByProductId(int productId)
        {
            return _iProductCategoryRepositoryContract.GetProductCategoryByProductId(productId);
        }
    }
}