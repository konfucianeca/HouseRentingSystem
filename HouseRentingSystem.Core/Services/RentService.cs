using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Admin;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class RentService : IRentService
    {
        private readonly IRepository repository;
        public RentService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IEnumerable<RentServiceModel>> AllAsync()
        {
            return await repository.AllReadOnly<House>()
                .Include(h => h.Agent.User)
                .Include(h => h.Renter)
                .Where(h => h.RenterId != null)
                .Select(h => new RentServiceModel()
                {
                    HouseTitle = h.Title,
                    HouseImageURL = h.ImageUrl,
                    AgentFullName = $"{h.Agent.User.FirstName} {h.Agent.User.LastName}",
                    AgentEmail = h.Agent.User.Email,
                    RenterFullName = h.Renter != null ? $"{h.Renter.FirstName} {h.Renter.LastName}" : string.Empty,
                    RenterEmail = h.Renter != null ? $"{h.Renter.Email}" : string.Empty
                })
                .ToListAsync();
        }
    }
}
