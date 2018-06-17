using AW.WebApi.BL.Products.Contracts;
using AW.WepApi.BL.DALContracts.Products;
using AW.WepApi.BL.Product.Entities;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AW.WebApi.BL.Products.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsContract _iProductContract;

        public ProductsService(IProductsContract iProductContract)
        {
            _iProductContract = iProductContract;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            return await _iProductContract.GetProducts();
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            return await _iProductContract.GetProductById(productId);
        }

        public async Task<bool> CreateProduct(ProductDto product)
        {
            if (await this.IsProductAlternateKeyValidForCreate(product.AlternateKey))
            {
                return await _iProductContract.CreateProduct(product);
            }
            return false;
        }

        public async Task<bool> UpdateProduct(ProductDto product)
        {

            if (await this.IsProductAlternateKeyValidForUpdate(product.AlternateKey, product.Key))
            {
                return await _iProductContract.UpdateProduct(product);
            }
            return false;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            return await _iProductContract.DeleteProduct(productId);
        }

        public Task<bool> IsProductAlternateKeyValidForCreate(string productAlternateKey)
        {
            return _iProductContract.IsProductAlternateKeyValidForCreate(productAlternateKey);
        }

        public Task<bool> IsProductAlternateKeyValidForUpdate(string productAlternateKey, int productKey)
        {
            return _iProductContract.IsProductAlternateKeyValidForUpdate(productAlternateKey, productKey);
        }

        public async Task<IEnumerable<ProductDto>> GetProductsByProductSubCategory(int subcategoryId)
        {
            return await _iProductContract.GetProductsByProductSubCategoryId(subcategoryId);
        }
    }
}