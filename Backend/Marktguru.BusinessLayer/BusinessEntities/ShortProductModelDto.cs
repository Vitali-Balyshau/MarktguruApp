namespace Marktguru.BusinessLayer.BusinessEntities
{
    public class ShortProductModelDto
    {
        public ShortProductModelDto()
        {
            ProductName = String.Empty;
        }

        public int Id { get; set; }

        public string  ProductName { get; set; }
        
        public decimal Price { get; set; }

        public bool Available { get; set; }
    }
}