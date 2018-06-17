[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(AW.WebApi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(AW.WebApi.App_Start.NinjectWebCommon), "Stop")]

namespace AW.WebApi.App_Start
{
    using AW.WebApi.BL.ProductCategories.Contracts;
    using AW.WebApi.BL.ProductCategories.Services;
    using AW.WebApi.BL.Products.Contracts;
    using AW.WebApi.BL.Products.Services;
    using AW.WebApi.BL.ProductSubcategories.Contracts;
    using AW.WebApi.BL.ProductSubcategories.Services;
    using AW.WepApi.BL.DALContracts.ProductCategories;
    using AW.WepApi.BL.DALContracts.Products;
    using AW.WepApi.BL.DALContracts.ProductSubcategories;
    using AW.WepApi.DAL.RepositoryService.ProductCategories;
    using AW.WepApi.DAL.RepositoryService.Products;
    using AW.WepApi.DAL.RepositoryService.ProductSubcategories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using System;
    using System.Web;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IProductCategoriesService>().To<ProductCategoriesService>();
            kernel.Bind<IProductCategoriesContract>().To<ProductCategoriesRepository>();

            kernel.Bind<IProductSubcategoriesService>().To<ProductSubcategoriesService>();
            kernel.Bind<ProductSubcategoriesContract>().To<ProductSubcategoriesRepository>();

            kernel.Bind<IProductsService>().To<ProductsService>();
            kernel.Bind<IProductsContract>().To<ProductsRepository>();
        }
    }
}