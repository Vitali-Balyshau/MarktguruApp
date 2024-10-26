using System;

namespace Marktguru.BusinessLayer.Exceptions
{
    public class ProductAlreadyExistsException: Exception
    {
        public ProductAlreadyExistsException(string productName)
            : base(String.Format("Product '{0}' already exists.", productName))
        {
        }

        public ProductAlreadyExistsException(string productName, Exception innerException)
            : base(String.Format("Product '{0}' already exists.", productName), innerException)
        {
        }
    }
}