using System;

namespace Marktguru.BusinessLayer.Exceptions
{
    public class ConcurrencyDataUpdateConflictException: Exception
    {
        public ConcurrencyDataUpdateConflictException(string entityName)
            : base(String.Format("Entity '{0}' has already new data. Please refresh it and try again", entityName))
        {
        }

        public ConcurrencyDataUpdateConflictException(string entityName, Exception innerException)
            : base(String.Format("Entity '{0}' has already new data. Please refresh it and try again", entityName), innerException)
        {
        }
    }
}