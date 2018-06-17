namespace AW.WepApi.BL.Product.Entities
{
    public class ProductDto
    {
        public int Key { get; set; }
        public string AlternateKey { get; set; }
        public int? ProductSubcategoryKey { get; set; }
        public string Name { get; set; }
        public short? StockLevel { get; set; }
        public decimal? Price { get; set; }
    }
}
