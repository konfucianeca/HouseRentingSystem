using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static HouseRentingSystem.Core.Constants.AdministratorConstants;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AdminRoleName)]
    public class AdminBaseController : Controller
    {

    }
}
