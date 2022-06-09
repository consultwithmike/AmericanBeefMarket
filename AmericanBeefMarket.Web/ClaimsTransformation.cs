using AmericanBeefMarket.Web.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AmericanBeefMarket.Web
{
    public class ClaimsTransformation : IClaimsTransformation
    {
        private readonly UserManager<ApplicationUser> userManager;

        public ClaimsTransformation(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            var user = await userManager.FindByEmailAsync(principal.Identity.Name);

            ClaimsIdentity claimsIdentity = new ClaimsIdentity();
            var claimType = "DisplayName";
            if (!principal.HasClaim(claim => claim.Type == claimType))
            {
                claimsIdentity.AddClaim(new Claim(claimType, user.Name));
            }

            principal.AddIdentity(claimsIdentity);

            return principal;
        }
    }
}
