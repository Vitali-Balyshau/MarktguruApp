using System;
using Marktguru.BusinessLayer.BusinessEntities;

namespace Marktguru.BusinessLayer.Interfaces
{
    public interface IUserAccountBusiness
    {
        Task<AppUserDto?> ValidateUserAsync(LoginDto loginDto);
    }
}