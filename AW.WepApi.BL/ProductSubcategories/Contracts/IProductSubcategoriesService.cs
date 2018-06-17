using AW.WepApi.BL.ProductSubcategories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AW.WebApi.BL.ProductSubcategories.Contracts
{
    public interface IProductSubcategoriesService
    {
        /// <summary>
        /// Gets all subcategories
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ProductSubcategoryDto>> GetProductSubcategories();

        /// <summary>
        /// Gets a subcategory
        /// </summary>
        /// <param name="subcategoryKey">The subcategory ID</param>
        /// <returns>Returns a subcategory object</returns>
        Task<ProductSubcategoryDto> GetProductSubcategoryById(int subcategoryKey);

        /// <summary>
        /// Gets all subcategories that belongs to a category
        /// </summary>
        /// <param name="categoryKey"></param>
        /// <returns></returns>
        Task<IEnumerable<ProductSubcategoryDto>> GetProductSubcategoriesByProductCategoryId(int categoryKey);
    }
}
