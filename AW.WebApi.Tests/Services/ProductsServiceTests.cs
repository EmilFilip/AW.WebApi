//using AW.WebApi.BL.Products.Contracts;
//using AW.WebApi.BL.Products.Services;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Rhino.Mocks;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace AW.WebApi.Tests.Controllers
//{
//    [TestClass]
//    public class ProductControllerTests
//    {

//        private IProductRepository _iProductRepositoryStub;

//        private IProductsService _iProductService;

//        [TestInitialize]
//        public void Setup()
//        {
//            _iProductRepositoryStub = MockRepository.GenerateStub<IProductRepository>();

//            _iProductService = new ProductsService(_iProductRepositoryStub);
//        }

//        [TestMethod]
//        public async Task GetProducts_Returns_Null()
//        {
//            List<Product> products = null;

//            // Arrange
//            _iProductRepositoryStub.Expect(service => service.GetProducts()).Return(Task.FromResult(products));

//            // Act
//            var result = await _iProductService.GetProducts();

//            // Assert
//            _iProductRepositoryStub.AssertWasCalled(o => o.GetProducts());
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public async Task GetProducts_Returns_NotNull()
//        {
//            List<Product> products = new List<Product>() { new Product { Id = 1, Key = "1234", Name = "Prod1"},
//                                                           new Product { Id = 2, Key = "5678", Name = "Prod2" }};

//            // Arrange
//            _iProductRepositoryStub.Expect(service => service.GetProducts()).Return(Task.FromResult(products));

//            // Act
//            var result = await _iProductService.GetProducts();

//            // Assert
//            _iProductRepositoryStub.AssertWasCalled(o => o.GetProducts());
//            Assert.IsNotNull(result);
//        }

//        [TestMethod]
//        public async Task GetProductById_Returns_Null()
//        {
//            Product product = null;
//            var id = 1;

//            // Arrange
//            _iProductRepositoryStub.Expect(service => service.GetProductById(id)).Return(Task.FromResult(product));

//            // Act
//            var result = await _iProductService.GetProductById(id);

//            // Assert
//            _iProductRepositoryStub.AssertWasCalled(o => o.GetProductById(id));
//            Assert.IsNull(result);
//        }

//        [TestMethod]
//        public async Task GetProductById_Returns_NotNull()
//        {
//            Product product = new Product { Id = 1, Key = "1234", Name = "Prod1" };
//            var id = 1;

//            // Arrange
//            _iProductRepositoryStub.Expect(service => service.GetProductById(id)).Return(Task.FromResult(product));

//            // Act
//            var result = await _iProductService.GetProductById(id);

//            // Assert
//            _iProductRepositoryStub.AssertWasCalled(o => o.GetProductById(id));
//            Assert.IsNotNull(result);
//        }

//        [TestMethod]
//        public async Task DeleteProduct_Returns_False()
//        {
//            var id = 1;

//            // Arrange
//            _iProductRepositoryStub.Expect(service => service.DeleteProduct(id)).Return(Task.FromResult(0));

//            // Act
//            var result = await _iProductService.DeleteProduct(id);

//            // Assert
//            _iProductRepositoryStub.AssertWasCalled(o => o.DeleteProduct(id));
//            Assert.IsFalse(Convert.ToBoolean(result));
//        }

//        [TestMethod]
//        public async Task DeleteProduct_Returns_True()
//        {
//            var id = 1;

//            // Arrange
//            _iProductRepositoryStub.Expect(service => service.DeleteProduct(id)).Return(Task.FromResult(1));

//            // Act
//            var result = await _iProductService.DeleteProduct(id);

//            // Assert
//            _iProductRepositoryStub.AssertWasCalled(o => o.DeleteProduct(id));
//            Assert.IsTrue(Convert.ToBoolean(result));
//        }

//        [TestMethod]
//        public async Task UpdateProduct_Returns_False()
//        {
//            var product = new Product { Id = 2, Key = "5678", Name = "Prod2", Price = 25M, ProductSubcategoryId = 1, StockLevel = 1 };

//            // Arrange
//            _iProductRepositoryStub.Expect(service => service.UpdateProduct(product)).Return(Task.FromResult(0));

//            // Act
//            var result = await _iProductService.UpdateProduct(product);

//            // Assert
//            _iProductRepositoryStub.AssertWasCalled(o => o.UpdateProduct(product));
//            Assert.IsFalse(Convert.ToBoolean(result));
//        }

//        [TestMethod]
//        public async Task UpdateProduct_Returns_True()
//        {
//            var product = new Product { Id = 2, Key = "5678", Name = "Prod2", Price = 25M, ProductSubcategoryId = 1, StockLevel = 1 };

//            // Arrange
//            _iProductRepositoryStub.Expect(service => service.UpdateProduct(product)).Return(Task.FromResult(1));

//            // Act
//            var result = await _iProductService.UpdateProduct(product);

//            // Assert
//            _iProductRepositoryStub.AssertWasCalled(o => o.UpdateProduct(product));
//            Assert.IsTrue(Convert.ToBoolean(result));
//        }

//        [TestMethod]
//        public async Task CreateProduct_Returns_True()
//        {
//            var product = new Product { Id = 2, Key = "5678", Name = "Prod2", Price = 25M, ProductSubcategoryId = 1, StockLevel = 1 };

//            // Arrange
//            _iProductRepositoryStub.Expect(service => service.CreateProduct(product)).Return(Task.FromResult(1));

//            // Act
//            var result = await _iProductService.CreateProduct(product);

//            // Assert
//            _iProductRepositoryStub.AssertWasCalled(o => o.CreateProduct(product));
//            Assert.IsTrue(Convert.ToBoolean(result));
//        }

//        [TestMethod]
//        public async Task CreateProduct_Returns_False()
//        {
//            var product = new Product { Id = 2, Key = "5678", Name = "Prod2", Price = 25M, ProductSubcategoryId = 1, StockLevel = 1 };

//            // Arrange
//            _iProductRepositoryStub.Expect(service => service.CreateProduct(product)).Return(Task.FromResult(0));

//            // Act
//            var result = await _iProductService.CreateProduct(product);

//            // Assert
//            _iProductRepositoryStub.AssertWasCalled(o => o.CreateProduct(product));
//            Assert.IsFalse(Convert.ToBoolean(result));
//        }
//    }
//}
