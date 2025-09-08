using Microsoft.AspNetCore.Identity;

namespace BankingApp.Helpers
{
    public interface ITokenRepository
    {
         string CreateJWTToken(IdentityUser user, List<string> roles);






    }
}