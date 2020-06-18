using System.Security.Claims;
using System.Threading.Tasks;
using CarChecker.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace CarChecker.Server
{
  public class ApplicationUsersClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser>
  {
    public ApplicationUsersClaimsPrincipalFactory(UserManager<ApplicationUser> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
    {
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
    {
      var identity = await base.GenerateClaimsAsync(user);
      identity.AddClaim(new Claim("firstname", user.FirstName ?? ""));
      identity.AddClaim(new Claim("lastname", user.LastName ?? ""));
      return identity;
    }
  }
}