using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Marktguru.BusinessLayer.BusinessEntities;
using Marktguru.BusinessLayer.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Marktguru.BusinessLayer.Implementation
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _config;
        private readonly SymmetricSecurityKey _key;

        public TokenService(IConfiguration config)
        {
            _config = config;

            string? secretTokenKey = _config["TokenKey"];

            if (!String.IsNullOrEmpty(secretTokenKey))
            {
                _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretTokenKey));
            }
            else
            {
                throw new ArgumentException("Security token key is null or empty");
            }
        }

        public string CreateToken(AppUserDto user)
        {
            string result = String.Empty;

            List<Claim> claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Name, user.CustomerUserName)
            };

            SigningCredentials creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256Signature);

            SecurityTokenDescriptor tokenDesc = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = creds
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            SecurityToken token = tokenHandler.CreateToken(tokenDesc);

            result = tokenHandler.WriteToken(token);

            return result;
        }
    }
}