using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static HouseRentingSystem.Core.Constants.AdministratorConstants;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
    public class RentController : AdminBaseController
    {
        private readonly IRentService rentService;
        private readonly IMemoryCache memoryCache;

        public RentController(
            IRentService _rentService,
            IMemoryCache _memoryCache)
        {
            rentService = _rentService;
            memoryCache = _memoryCache;
        }
        public async Task<IActionResult> All()
        {
            var rents = memoryCache
                .Get<IEnumerable<RentServiceModel>>(RentsCacheKey);

            if (rents == null)
            {
                rents = await rentService.AllAsync();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

                memoryCache.Set(RentsCacheKey,rents,cacheOptions);
            }

            return View(rents);
        }
    }
}
