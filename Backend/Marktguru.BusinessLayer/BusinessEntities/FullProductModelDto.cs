using System;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        [MaxLength(100)]
        public string  ProductName { get; set; }
        
        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool Available { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        public DateTime DateCreated { get; set; }
    }
}