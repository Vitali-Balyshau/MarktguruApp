using System;

namespace Marktguru.BusinessLayer.BusinessEntities
{
    public class FullProductModelDto
    {
        public FullProductModelDto()
        {
            ProductName = String.Empty;
            Description = String.Empty;
        }

        public int Id { get; set; }

        public string  ProductName { get; set; }
        
        public decimal Price { get; set; }

        public bool Available { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }
    }
}