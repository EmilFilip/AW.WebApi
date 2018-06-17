using AW.WepApi.BL.Product.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AW.WepApi.BL.DALContracts.Products
{
    public interface IProductsContract
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> CreateProduct(ProductDto product, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productKey"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> DeleteProduct(int productKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productKey"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ProductDto> GetProductById(int productKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<ProductDto>> GetProducts(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productAlternateKey"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> IsProductAlternateKeyValidForCreate(string productAlternateKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productAlternateKey"></param>
        /// <param name="productKey"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> IsProductAlternateKeyValidForUpdate(string productAlternateKey, int productKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> UpdateProduct(ProductDto product, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productSubCategoryKey"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<ProductDto>> GetProductsByProductSubCategoryId(int productSubCategoryKey, CancellationToken cancellationToken = default(CancellationToken));
    }
}
