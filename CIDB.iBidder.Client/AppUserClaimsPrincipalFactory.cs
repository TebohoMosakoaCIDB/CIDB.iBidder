using CIDB.iBidder.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace CIDB.iBidder.Client
{
    public class AppUserClaimsPrincipalFactory(
    UserManager<ApplicationUser> userManager,
    IOptions<IdentityOptions> optionsAccessor)
    : UserClaimsPrincipalFactory<ApplicationUser>(userManager, optionsAccessor)
    {
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            identity.AddClaim(new Claim("CsdNumber", user.CsdNumber));
            identity.AddClaim(new Claim("CrsNumber", user.CrsNumber));
            identity.AddClaim(new Claim("IsActive", user.IsActive.ToString()));

            return identity;
        }
    }
}
