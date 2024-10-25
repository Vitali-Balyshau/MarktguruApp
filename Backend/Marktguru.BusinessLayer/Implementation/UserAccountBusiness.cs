using System;
using Marktguru.BusinessLayer.BusinessEntities;
using Marktguru.BusinessLayer.Interfaces;
using Marktguru.DataLayer.DataEntities;
using Marktguru.DataLayer.Repository.Interfaces;

namespace Marktguru.BusinessLayer.Implementation
{
    public class UserAccountBusiness: IUserAccountBusiness
    {
        private readonly IUserAccountRepository _userAccountRepository;

        public UserAccountBusiness(IUserAccountRepository userAccountRepository)
        {
            _userAccountRepository = userAccountRepository;
            
        }

        public async Task<AppUserDto?> ValidateUserAsync(LoginDto loginDto)
        {
            AppUserDto? result = null;

            AppUser? user = await _userAccountRepository.GetUserByNameAsync(loginDto.UserName);

            //User Exists
            if (user != null)
            {
                //Should be a hash and in byte array, but for simplicity - it is a clear text string
                if (String.Compare(user.Password, loginDto.Password, false) == 0)
                {
                    result = new AppUserDto()
                    {
                        Id = user.Id,
                        CustomerUserName = loginDto.UserName,
                    };
                }
            }

            return result;
        }
    }
}