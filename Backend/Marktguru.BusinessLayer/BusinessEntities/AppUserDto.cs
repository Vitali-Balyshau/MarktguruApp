using System;

namespace Marktguru.BusinessLayer.BusinessEntities
{
    public class AppUserDto
    {
        public AppUserDto()
        {
            CustomerUserName = String.Empty;
        }

        public int Id { get; set; }
        public string CustomerUserName { get; set; }
    }
}