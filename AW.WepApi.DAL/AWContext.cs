namespace AW.WepApi.DAL
{
    using AW.WepApi.DAL.Entities.ProductCategories;
    using AW.WepApi.DAL.Entities.Products;
    using AW.WepApi.DAL.Entities.ProductSubcategories;
    using System.Data.Entity;

    public partial class AWContext : DbContext
    {
        public AWContext()
            : base("name=AWContext")
        {
        }

        public virtual DbSet<DimProduct> DimProducts { get; set; }
        public virtual DbSet<DimProductCategory> DimProductCategories { get; set; }
        public virtual DbSet<DimProductSubcategory> DimProductSubcategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DimProduct>()
                .Property(e => e.WeightUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.SizeUnitMeasureCode)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.StandardCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.ListPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.ProductLine)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.DealerPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.Class)
                .IsFixedLength();

            modelBuilder.Entity<DimProduct>()
                .Property(e => e.Style)
                .IsFixedLength();
        }
    }
}
