using AW.WepApi.BL.DALContracts.ProductSubcategories;
using AW.WepApi.BL.ProductSubcategories.Entities;
using AW.WepApi.DAL.Entities.ProductSubcategories;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AW.WepApi.DAL.RepositoryService.ProductSubcategories
{
    public class ProductSubcategoriesRepository : BaseRepository<AWContext>, ProductSubcategoriesContract
    {
        public Task<IEnumerable<ProductSubcategoryDto>> GetProductSubcategories(CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    return base.GetList<DimProductSubcategory>().ToList().Select(productSubcatebory => new ProductSubcategoryDto()
                    {
                        Key = productSubcatebory.ProductSubcategoryKey,
                        Name = productSubcatebory.EnglishProductSubcategoryName
                    });
                }
            }, cancellationToken);
        }

        public Task<IEnumerable<ProductSubcategoryDto>> GetProductSubcategoriesByProductCategoryId(int productCategoryKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    return base.GetList<DimProductSubcategory>(x => x.ProductCategoryKey == productCategoryKey).ToList().Select(productSubcatebory => new ProductSubcategoryDto()
                    {
                        Key = productSubcatebory.ProductSubcategoryKey,
                        Name = productSubcatebory.EnglishProductSubcategoryName
                    });
                }
            }, cancellationToken);
        }

        public Task<ProductSubcategoryDto> GetProductSubcategoryById(int subcategoryKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    var productSubcategory = base.Get<DimProductSubcategory>(x => x.ProductSubcategoryKey == subcategoryKey);

                    if (productSubcategory != null)
                    {
                        return new ProductSubcategoryDto()
                        {
                            Key = productSubcategory.ProductSubcategoryKey,
                            ProductCategoryKey = productSubcategory.ProductCategoryKey,
                            Name = productSubcategory.EnglishProductSubcategoryName
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }, cancellationToken);
        }
    }
}
