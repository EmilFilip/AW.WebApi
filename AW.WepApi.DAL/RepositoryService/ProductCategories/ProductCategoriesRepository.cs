using AW.WepApi.BL.DALContracts.ProductCategories;
using AW.WepApi.BL.ProductCategories.Entities;
using AW.WepApi.DAL.Entities.ProductCategories;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AW.WepApi.DAL.RepositoryService.ProductCategories
{
    public class ProductCategoriesRepository : BaseRepository<AWContext>, IProductCategoriesContract
    {
        public Task<IEnumerable<ProductCategoryDto>> GetProductCategories(CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    return base.GetList<DimProductCategory>().ToList().Select(productCategory => new ProductCategoryDto()
                    {
                        Key = productCategory.ProductCategoryKey,
                        Name = productCategory.EnglishProductCategoryName
                    });
                }
            }, cancellationToken);
        }

        public Task<ProductCategoryDto> GetProductCategoryByProductId(int productKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.StartNew(() =>
            {
                using (DataContext)
                {
                    return DataContext.DimProductCategories
                        .Join(DataContext.DimProductSubcategories,
                            pc => pc.ProductCategoryKey,
                            psc => psc.ProductCategoryKey,
                            (pc, psc) => new { pc, psc })
                        .Join(DataContext.DimProducts,
                            o => o.psc.ProductSubcategoryKey,
                            p => p.ProductSubcategoryKey,
                            (pc1, p) => new { pc1, p })
                        .Where(z => z.p.ProductKey == productKey)
                        .Select(z => new ProductCategoryDto()
                        {
                            Key = z.pc1.pc.ProductCategoryKey,
                            Name = z.pc1.pc.EnglishProductCategoryName
                        }).FirstOrDefault();
                }
            }, cancellationToken);
        }
    }
}
