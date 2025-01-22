using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
