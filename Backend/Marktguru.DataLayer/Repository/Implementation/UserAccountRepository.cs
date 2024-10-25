using System;
using Marktguru.DataLayer.DataEntities;
using Marktguru.DataLayer.Repository.Interfaces;

namespace Marktguru.DataLayer.Repository.Implementation
{
    public class UserAccountRepository : IUserAccountRepository
    {
        public async Task<AppUser?> GetUserByNameAsync(string userName)
        {
            AppUser? result = null;

            //No DB schema for users and roles, so keeping it hardcoded
            if (String.Compare(userName, "user1", true) == 0)
            {
                result = new AppUser() 
                {
                     Id = 1, 
                     UserName = "user1",
                     UserRoles = new List<string> { "Customer" }, //Not needed now, but...
                    Password = "Password1" //Should be a hash and in byte array, but for simplicity - it is a clear text string
                };
            }
            else if (String.Compare(userName, "user2", true) == 0)
            {
                result = new AppUser() 
                {
                     Id = 2, 
                     UserName = "user2",
                     UserRoles = new List<string> { "Admin" }, //Not needed now, but...
                     Password = "Password2" //Should be a hash and in byte array, but for simplicity - it is a clear text string
                };
            }

            await Task.CompletedTask;

            return result;
        }
    }
}