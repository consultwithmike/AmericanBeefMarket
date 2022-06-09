using System.Linq;
using System.Security.Claims;
using System.Security.Principal;

namespace AmericanBeefMarket.Web
{
    public static class IdentityExtensions
    {
        public static string DisplayName(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal
                .Claims
                .FirstOrDefault(c => c.Type == "DisplayName")
                ?.Value ?? claimsPrincipal.Identity.Name;
        }
    }
}
