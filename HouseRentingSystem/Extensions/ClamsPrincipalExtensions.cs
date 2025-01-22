using System.Security.Claims;

namespace HouseRentingSystem.Extensions
{
    public static class ClamsPrincipalExtensions
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
