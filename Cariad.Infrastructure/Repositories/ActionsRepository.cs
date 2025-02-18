using Cariad.Application.Interfaces;
using Cariad.Domain.DTOs.User;

namespace Cariad.Infrastructure.Repositories
{
    public class ActionsRepository : IActionsRepository
    {
        public async Task<IEnumerable<ActionsDto>> GetActionsAsync()
        {
            return await Task.FromResult(new List<ActionsDto>
            {
                new() { ActionId = 1, Author = "shaun.weston@principality.co.uk", Title = "Call back", Description = "Call Mr Smith about new savings account", Status = "Active", Created = DateTime.Now },
                new() { ActionId = 2, Author = "shaun.weston@principality.co.uk", Title = "Service Now Ticket", Description = "Call Sue Denim about technical issue resolution", Status = "Pending", Created = DateTime.Now },
                new() { ActionId = 3, Author = "shaun.weston@principality.co.uk", Title = "Log complaint", Description = "Log complaint for Mr. Burns", Status = "Closed", Created = DateTime.Now },
            });
        }
    }
}
