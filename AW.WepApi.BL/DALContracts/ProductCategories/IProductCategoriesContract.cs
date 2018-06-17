using AW.WepApi.BL.ProductCategories.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AW.WepApi.BL.DALContracts.ProductCategories
{
    public interface IProductCategoriesContract
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<ProductCategoryDto>> GetProductCategories(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productKey"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ProductCategoryDto> GetProductCategoryByProductId(int productKey, CancellationToken cancellationToken = default(CancellationToken));
    }
}
