using AW.WepApi.BL.DALContracts.Products;
using AW.WepApi.BL.Product.Entities;
using AW.WepApi.DAL.Entities.Products;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AW.WepApi.DAL.RepositoryService.Products
{
    public class ProductsRepository : BaseRepository<AWContext>, IProductsContract
    {
        public Task<bool> CreateProduct(ProductDto product, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    return base.Insert<DimProduct>(new DimProduct()
                    {
                        //ProductKey = product.Key,
                        ProductSubcategoryKey = product.ProductSubcategoryKey,
                        ProductAlternateKey = product.AlternateKey,
                        EnglishProductName = product.Name,
                        SafetyStockLevel = product.StockLevel,
                        ListPrice = product.Price
                    });
                }
            }, cancellationToken);
        }

        public Task<bool> UpdateProduct(ProductDto product, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    var dbProduct = base.Get<DimProduct>(x => x.ProductKey == product.Key);

                    if (dbProduct != null)
                    {
                        dbProduct.EnglishProductName = product.Name;
                        dbProduct.ListPrice = product.Price;
                        dbProduct.SafetyStockLevel = product.StockLevel;
                    }

                    return base.Update<DimProduct>(dbProduct);
                }
            }, cancellationToken);
        }

        public Task<bool> DeleteProduct(int productId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    var product = base.Get<DimProduct>(x => x.ProductKey == productId);
                    return base.Delete<DimProduct>(product);
                }
            }, cancellationToken);
        }

        public Task<IEnumerable<ProductDto>> GetProducts(CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    return base.GetList<DimProduct>().ToList().Select(product => new ProductDto()
                    {
                        Key = product.ProductKey,
                        AlternateKey = product.ProductAlternateKey,
                        ProductSubcategoryKey = product.ProductSubcategoryKey,
                        Name = product.EnglishProductName,
                        StockLevel = product.SafetyStockLevel,
                        Price = product.ListPrice
                    });
                }
            }, cancellationToken);
        }

        public Task<ProductDto> GetProductById(int productId, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    var product = base.Get<DimProduct>(x => x.ProductKey == productId);

                    if (product != null)
                    {
                        return new ProductDto()
                        {
                            Key = product.ProductKey,
                            AlternateKey = product.ProductAlternateKey,
                            ProductSubcategoryKey = product.ProductSubcategoryKey,
                            Name = product.EnglishProductName,
                            StockLevel = product.SafetyStockLevel,
                            Price = product.ListPrice
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }, cancellationToken);
        }
        public Task<IEnumerable<ProductDto>> GetProductsByProductSubCategoryId(int productSubCategoryKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    return base.GetList<DimProduct>(x => x.ProductSubcategoryKey == productSubCategoryKey).ToList().Select(product => new ProductDto()
                    {
                        Key = product.ProductKey,
                        AlternateKey = product.ProductAlternateKey,
                        ProductSubcategoryKey = product.ProductSubcategoryKey,
                        Name = product.EnglishProductName,
                        StockLevel = product.SafetyStockLevel,
                        Price = product.ListPrice
                    });
                }
            }, cancellationToken);
        }

        public Task<bool> IsProductAlternateKeyValidForCreate(string productAlternateKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    return !DataContext.DimProducts.Any(x => x.ProductAlternateKey == productAlternateKey);
                }
            }, cancellationToken);
        }
        public Task<bool> IsProductAlternateKeyValidForUpdate(string productAlternateKey, int productKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    return !DataContext.DimProducts.Any(x => x.ProductAlternateKey == productAlternateKey && x.ProductKey != productKey);
                }
            }, cancellationToken);
        }
    }
}
