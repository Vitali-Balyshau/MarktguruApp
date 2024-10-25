using System;
using Microsoft.AspNetCore.Mvc;
using Marktguru.BusinessLayer.BusinessEntities;
using Marktguru.BusinessLayer.Interfaces;

namespace Marktguru.WebAPI.Controllers
{
    public class AccountController: BaseApiController
    {
        private readonly ITokenService _tokenService;
        private readonly IUserAccountBusiness _userAccount;

        public AccountController(ITokenService tokenService, IUserAccountBusiness userAccount)
        {
            _userAccount = userAccount;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AccountUserDto?>> LoginAsync(LoginDto loginDto)
        {
            AccountUserDto? result = null;

            AppUserDto? user = await _userAccount.ValidateUserAsync(loginDto);

            //User is valid
            if (user != null)
            {
                result = new AccountUserDto();
                result.UserName = user.CustomerUserName;
                result.Token = _tokenService.CreateToken(user);
            }
            else
            {
                return Unauthorized("Authorization failed");
            }

            return result;
        }
    }
}