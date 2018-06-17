using AW.WepApi.BL.Product.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AW.WebApi.BL.Products.Contracts
{
    public interface IProductsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ProductDto>> GetProducts();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productKey"></param>
        /// <returns></returns>
        Task<ProductDto> GetProductById(int productKey);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<bool> CreateProduct(ProductDto product);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<bool> UpdateProduct(ProductDto product);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productKey"></param>
        /// <returns></returns>
        Task<bool> DeleteProduct(int productKey);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productKey"></param>
        /// <returns></returns>
        Task<bool> IsProductAlternateKeyValidForCreate(string productAlternateKey);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productKey"></param>
        /// <returns></returns>
        Task<bool> IsProductAlternateKeyValidForUpdate(string productAlternateKey, int productKey);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subcategoryKey"></param>
        /// <returns></returns>
        Task<IEnumerable<ProductDto>> GetProductsByProductSubCategory(int subcategoryKey);
    }
}
