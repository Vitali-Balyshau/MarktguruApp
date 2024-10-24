namespace Marktguru.BusinessLayer.BusinessEntities
{
    public class ProductModelDto
    {
        public ProductModelDto()
        {
            ProductName = String.Empty;
            ProductDescription = String.Empty;
            DateCreated = DateTime.Now;
        }

        public int Id { get; set; }

        public string  ProductName { get; set; }
        
        public decimal Price { get; set; }

        public bool Available { get; set; }

        public string  ProductDescription { get; set; }

        public DateTime DateCreated { get; set; }
    }
}