using System;

namespace Marktguru.BusinessLayer.BusinessEntities
{
    public class AccountUserDto
    {
        public AccountUserDto()
        {
            Token = String.Empty;
            UserName = String.Empty;
        }

        public string UserName { get; set; }

        public string Token { get; set; }
    }
}