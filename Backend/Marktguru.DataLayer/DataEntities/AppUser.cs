using System;

namespace Marktguru.DataLayer.DataEntities
{
    public class AppUser
    {
        public AppUser()
        {
            UserName = String.Empty;
            UserRoles = new List<string>();
            Password = String.Empty;
        }

        public int Id { get; set; }

        public string UserName { get; set; }

        //Should be a hash and in byte array, but for simplicity - it is a clear text string
        public string Password { get; set; }

        public List<string> UserRoles { get; set; }
    }
}