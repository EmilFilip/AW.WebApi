using AW.WepApi.BL.ProductSubcategories.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AW.WepApi.BL.DALContracts.ProductSubcategories
{
    public interface ProductSubcategoriesContract
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<ProductSubcategoryDto>> GetProductSubcategories(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subcategoryKey"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ProductSubcategoryDto> GetProductSubcategoryById(int subcategoryKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets all subcategories that belongs to a category
        /// </summary>
        /// <param name="productCategoryKey">The Product Category ID/Key</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Returns a subcategory object</returns>
        Task<IEnumerable<ProductSubcategoryDto>> GetProductSubcategoriesByProductCategoryId(int productCategoryKey, CancellationToken cancellationToken = default(CancellationToken));
    }
}
