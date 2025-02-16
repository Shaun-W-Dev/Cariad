using Cariad.Domain.DTOs.User;

namespace Cariad.Application.Interfaces
{
    public interface IActionsRepository
    {
        Task<IEnumerable<ActionsDto>> GetActionsAsync();
    }
}
