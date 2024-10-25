using System;
using Marktguru.DataLayer.DataEntities;

namespace Marktguru.DataLayer.Repository.Interfaces
{
    public interface IUserAccountRepository
    {
        Task<AppUser?> GetUserByNameAsync(string userName);
    }
}