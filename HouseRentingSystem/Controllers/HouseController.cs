using HouseRentingSystem.Attributes;
using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.House;
using HouseRentingSystem.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    public class HouseController : BaseController
    {
        private readonly IHouseService houseService;
        private readonly IAgentService agentService;
        public HouseController(IHouseService _houseService, IAgentService _agentService)
        {
            houseService = _houseService;
            agentService = _agentService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllHousesQueryModel model)
        {
            var houses = await houseService.AllAsync(
                model.Category,
                model.SearchTerm,
                model.Sorting,
                model.CurrentPage,
                model.HousesPerPage);

            model.TotalHousesCount = houses.TotalHousesCount;
            model.Houses = houses.Houses;
            model.Categories = await houseService.AllCategoriesNamesAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();
            IEnumerable<HouseServiceModel> model;

            if (await agentService.ExistByIdAsync(userId))
            {
                int agentId = await agentService.GetAgentIdAsync(userId) ?? 0;
                model = await houseService.AllHousesByAgentIdAsync(agentId);
            }
            else
            {
                model = await houseService.AllHousesByUserIdAsync(userId);
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (await houseService.ExistAsync(id) == false)
            {
                return BadRequest();
            }
            var model = await houseService.HouseDetailsByIdAsync(id);

            return View(model);
        }

        [HttpGet]
        [MustBeAgent]
        public async Task<IActionResult> Add()
        {
            var model = new HouseFormModel()
            {
                Categories = await houseService.AllCategoriesAsync()
            };

            return View(model);
        }

        [HttpPost]
        [MustBeAgent]
        public async Task<IActionResult> Add(HouseFormModel model)
        {
            if (await houseService.CategoryExistsAsync(model.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
            }

            if (ModelState.IsValid == false)
            {
                model.Categories = await houseService.AllCategoriesAsync();

                return View(model);
            }

            int? agentId = await agentService.GetAgentIdAsync(User.Id());

            int newHouseId = await houseService.CreateAsync(model, agentId ?? 0);

            return RedirectToAction(nameof(Details), new { id = newHouseId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (await houseService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            if (await houseService.HasAgentWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            var model = await houseService.GetHouseFormModelByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(HouseFormModel model, int id)
        {
            if (await houseService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            if (await houseService.HasAgentWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            if (await houseService.CategoryExistsAsync(model.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
            }

            if (ModelState.IsValid == false)
            {
                model.Categories = await houseService.AllCategoriesAsync();

                return View(model);
            }

            await houseService.EditAsync(model, id);

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (await houseService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            if (await houseService.HasAgentWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            var house = await houseService.HouseDetailsByIdAsync(id);
            var model = new HouseDetailsViewModel()
            {
                Id = house.Id,
                Title = house.Title,
                Address = house.Address,
                ImageUrl = house.ImageUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(HouseDetailsViewModel house)
        {
            if (await houseService.ExistAsync(house.Id) == false)
            {
                return BadRequest();
            }

            if (await houseService.HasAgentWithIdAsync(house.Id, User.Id()) == false)
            {
                return Unauthorized();
            }

            await houseService.DeleteAsync(house.Id);

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> RentAsync(int id)
        {
            if (await houseService.ExistAsync(id) == false)
            {
                return BadRequest();
            }

            if (await agentService.ExistByIdAsync(User.Id()))
            {
                return Unauthorized();
            }

            if (await houseService.IsRented(id))
            {
                return BadRequest();
            }

            await houseService.RentAsync(id, User.Id());

            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
    }
}
