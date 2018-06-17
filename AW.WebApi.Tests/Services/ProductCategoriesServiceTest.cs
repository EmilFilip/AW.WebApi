//using AW.WebApi.BL.ProductCategories.Contracts;
//using AW.WebApi.BL.ProductCategories.Services;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Rhino.Mocks;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace AW.WebApi.Tests.Controllers
//{
//    [TestClass]
//    public class ProductCategoriesServiceTest
//    {
//        private IProductSubCategoryRepository _iProductSubCategoryRepositoryStub;
//        private IProductCategoryRepository _iProductCategoryRepositoryStub;

//        private IProductCategoriesService _iProductCategoriesService;

//        [TestInitialize]
//        public void Setup()
//        {
//            _iProductCategoryRepositoryStub = MockRepository.GenerateStub<IProductCategoryRepository>();
//            _iProductSubCategoryRepositoryStub = MockRepository.GenerateStub<IProductSubCategoryRepository>();

//            _iProductCategoriesService = new ProductCategoriesService(_iProductCategoryRepositoryStub, _iProductSubCategoryRepositoryStub); ;

//        }

//        [TestMethod]
//        public async Task GetProductCategories_Returns_NotNull()
//        {
//            List<ProductCategory> productCategories = new List<ProductCategory>() { new ProductCategory { Id = 1, Key = 1234, Name = "Prod1"},
//                                                           new ProductCategory { Id = 2, Key = 5678, Name = "Prod2" }};

//            // Arrange
//            _iProductCategoryRepositoryStub.Expect(service => service.GetProductCategories()).Return(Task.FromResult(productCategories));

//            // Act
//            var result = await _iProductCategoriesService.GetProductCategories();

//            // Assert
//            _iProductCategoryRepositoryStub.AssertWasCalled(o => o.GetProductCategories());
//            Assert.IsNotNull(result);
//        }

//        [TestMethod]
//        public async Task GetProductCategories_Returns_Null()
//        {
//            List<ProductCategory> productCategories = null;
//            // Arrange
//            _iProductCategoryRepositoryStub.Expect(service => service.GetProductCategories()).Return(Task.FromResult(productCategories));

//            // Act
//            var result = await _iProductCategoriesService.GetProductCategories();

//            // Assert
//            _iProductCategoryRepositoryStub.AssertWasCalled(o => o.GetProductCategories());
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public async Task GetProductCategoryByID_Returns_Null()
//        {
//            ProductCategory productCategory = null;
//            var id = 1;

//            // Arrange
//            _iProductCategoryRepositoryStub.Expect(service => service.GetProductCategoryById(id)).Return(Task.FromResult(productCategory));

//            // Act
//            var result = await _iProductCategoriesService.GetProductCategoryById(id);

//            // Assert
//            _iProductCategoryRepositoryStub.AssertWasCalled(o => o.GetProductCategoryById(id));
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public async Task GetProductCategoryByID_Returns_NotNull()
//        {
//            ProductCategory productCategory = new ProductCategory() { Id = 1, Key = 1234, Name = "Test" };
//            var id = 1;

//            // Arrange
//            _iProductCategoryRepositoryStub.Expect(service => service.GetProductCategoryById(id)).Return(Task.FromResult(productCategory));

//            // Act
//            var result = await _iProductCategoriesService.GetProductCategoryById(id);

//            // Assert
//            _iProductCategoryRepositoryStub.AssertWasCalled(o => o.GetProductCategoryById(id));
//            Assert.IsNotNull(result);
//        }

//        [TestMethod]
//        public async Task GetProductSubcategoriesByProductCategoryId_Returns_NotNull()
//        {
//            List<ProductSubcategory> productSubcategories = new List<ProductSubcategory>() { new ProductSubcategory { Id = 1, Key = 1234, Name = "ProdSubcat1"},
//                                                           new ProductSubcategory { Id = 2, Key = 5678, Name = "ProdSubcat2" }};
//            var id = 1;

//            // Arrange
//            _iProductSubCategoryRepositoryStub.Expect(service => service.GetProductSubcategoriesByProductCategoryId(id)).Return(Task.FromResult(productSubcategories));

//            // Act
//            var result = await _iProductCategoriesService.GetProductSubcategoriesByProductCategoryId(id);

//            // Assert
//            _iProductSubCategoryRepositoryStub.AssertWasCalled(o => o.GetProductSubcategoriesByProductCategoryId(id));
//            Assert.IsNotNull(result);
//        }

//        [TestMethod]
//        public async Task GetProductSubcategoriesByProductCategoryId_Returns_Null()
//        {
//            List<ProductSubcategory> productSubcategories = null;
//            var id = 1;

//            // Arrange
//            _iProductSubCategoryRepositoryStub.Expect(service => service.GetProductSubcategoriesByProductCategoryId(id)).Return(Task.FromResult(productSubcategories));

//            // Act
//            var result = await _iProductCategoriesService.GetProductSubcategoriesByProductCategoryId(id);

//            // Assert
//            _iProductSubCategoryRepositoryStub.AssertWasCalled(o => o.GetProductSubcategoriesByProductCategoryId(id));
//            Assert.IsNull(result);
//        }
//    }
//}
