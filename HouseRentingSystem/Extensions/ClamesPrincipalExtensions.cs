using System.Security.Claims;

namespace HouseRentingSystem.Extensions
{
    public static class ClamesPrincipalExtensions
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
