using Microsoft.AspNetCore.Identity;
using PetAdoptionCenter.Data;

namespace PetAdoptionCenter.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<PetAdoptionCenterUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<PetAdoptionCenterUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
