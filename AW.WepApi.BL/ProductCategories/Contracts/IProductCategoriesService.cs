using AW.WepApi.BL.ProductCategories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AW.WebApi.BL.ProductCategories.Contracts
{
    public interface IProductCategoriesService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ProductCategoryDto>> GetProductCategories();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productKey"></param>
        /// <returns></returns>
        Task<ProductCategoryDto> GetProductCategoryByProductId(int productKey);
    }
}
