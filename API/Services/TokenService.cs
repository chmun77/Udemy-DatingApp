using API.Entities;
using API.interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace API.Services
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _key;
        public TokenService(IConfiguration config)
        {
        }

        public string CreateToken(AppUser user)
        {
            throw new System.NotImplementedException();
        }
    }
}