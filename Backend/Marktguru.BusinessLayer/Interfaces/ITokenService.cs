using System;
using Marktguru.BusinessLayer.BusinessEntities;

namespace Marktguru.BusinessLayer.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUserDto user);
    }
}