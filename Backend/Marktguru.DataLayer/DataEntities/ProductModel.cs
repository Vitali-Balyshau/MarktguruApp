using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marktguru.DataLayer.DataEntities
{
    public class ProductModel
    {
        public ProductModel()
        {
            ProductName = String.Empty;
            ProductDescription = String.Empty;
        }

        public int Id { get; set; }

        [MaxLength(100)]
        public string  ProductName { get; set; }
    
        [Column(TypeName = "REAL")]
        public decimal Price { get; set; }

        public bool Available { get; set; }

        [MaxLength(100)]
        public string  ProductDescription { get; set; }

        public DateTime DateCreated { get; set; }

        [ConcurrencyCheck]
        public Guid Version { get; set; }
    }
}