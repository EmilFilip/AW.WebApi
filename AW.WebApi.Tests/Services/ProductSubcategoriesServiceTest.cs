//using AW.WebApi.BL.ProductSubcategories.Contracts;
//using AW.WebApi.BL.ProductSubcategories.Services;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Rhino.Mocks;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace AW.WebApi.Tests.Controllers
//{
//    [TestClass]
//    public class ProductSubcategoriesServiceTest
//    {
//        private IProductSubCategoryRepository _iProductSubCategoryRepositoryStub;
//        private IProductRepository _iProductRepositoryStub;

//        private IProductSubcategoriesService _iProductCategoriesService;

//        [TestInitialize]
//        public void Setup()
//        {
//            _iProductSubCategoryRepositoryStub = MockRepository.GenerateStub<IProductSubCategoryRepository>();
//            _iProductRepositoryStub = MockRepository.GenerateStub<IProductRepository>();

//            _iProductCategoriesService = new ProductSubcategoriesService(_iProductSubCategoryRepositoryStub, _iProductRepositoryStub); ;

//        }

//        [TestMethod]
//        public async Task GetProductSubcategories_Returns_Null()
//        {
//            List<ProductSubcategory> productSubcategories = null;

//            // Arrange
//            _iProductSubCategoryRepositoryStub.Expect(service => service.GetProductSubcategories()).Return(Task.FromResult(productSubcategories));

//            // Act
//            var result = await _iProductCategoriesService.GetProductSubcategories();

//            // Assert
//            _iProductSubCategoryRepositoryStub.AssertWasCalled(o => o.GetProductSubcategories());
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public async Task GetProductSubcategories_Returns_NotNull()
//        {
//            List<ProductSubcategory> productSubcategories = new List<ProductSubcategory>() { new ProductSubcategory { Id = 1, Key = 1234, Name = "Prod1"},
//                                                           new ProductSubcategory { Id = 2, Key = 5678, Name = "Prod2" }};

//            // Arrange
//            _iProductSubCategoryRepositoryStub.Expect(service => service.GetProductSubcategories()).Return(Task.FromResult(productSubcategories));

//            // Act
//            var result = await _iProductCategoriesService.GetProductSubcategories();

//            // Assert
//            _iProductSubCategoryRepositoryStub.AssertWasCalled(o => o.GetProductSubcategories());
//            Assert.IsNotNull(result);
//        }

//        [TestMethod]
//        public async Task GetProductSubcategory_Returns_Null()
//        {
//            ProductSubcategory productSubCategory = null;
//            var id = 1;

//            // Arrange
//            _iProductSubCategoryRepositoryStub.Expect(service => service.GetProductSubcategoryById(id)).Return(Task.FromResult(productSubCategory));

//            // Act
//            var result = await _iProductCategoriesService.GetProductSubcategory(id);

//            // Assert
//            _iProductSubCategoryRepositoryStub.AssertWasCalled(o => o.GetProductSubcategoryById(id));
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public async Task GetProductSubcategory_Returns_NotNull()
//        {
//            ProductSubcategory productSubCategory = new ProductSubcategory() {Id = 1, Key = 1234, Name = "Test", ProductCategoryId = 1 };
//            var id = 1;

//            // Arrange
//            _iProductSubCategoryRepositoryStub.Expect(service => service.GetProductSubcategoryById(id)).Return(Task.FromResult(productSubCategory));

//            // Act
//            var result = await _iProductCategoriesService.GetProductSubcategory(id);

//            // Assert
//            _iProductSubCategoryRepositoryStub.AssertWasCalled(o => o.GetProductSubcategoryById(id));
//            Assert.IsNotNull(result);
//        }

//        [TestMethod]
//        public async Task GetProductsByProductSubCategory_Returns_NotNull()
//        {

//            List<Product> products = new List<Product>() { new Product { Id = 1, Key = "1234", Name = "Prod1"},
//                                                           new Product { Id = 2, Key = "5678", Name = "Prod2" }};
//            var id = 1;

//            // Arrange
//            _iProductRepositoryStub.Expect(service => service.GetProductsByProductSubCategoryId(id)).Return(Task.FromResult(products));

//            // Act
//            var result = await _iProductCategoriesService.GetProductsByProductSubCategory(id);

//            // Assert
//            _iProductRepositoryStub.AssertWasCalled(o => o.GetProductsByProductSubCategoryId(id));
//            Assert.IsNotNull(result);
//        }
//    }
//}
