using System;

namespace Marktguru.BusinessLayer.Exceptions
{
    public class ProductDoesNotExistException: Exception
    {
        public ProductDoesNotExistException(int id)
            : base(String.Format("Product with id '{0}' does not exist.", id))
        {
        }

        public ProductDoesNotExistException(int id, Exception innerException)
            : base(String.Format("Product with id '{0}' does not exist.", id), innerException)
        {
        }
    }
}