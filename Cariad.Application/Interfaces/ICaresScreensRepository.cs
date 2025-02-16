using Cariad.Domain.Models;

namespace Cariad.Application.Interfaces
{
    public interface ICaresScreensRepository
    {
        Task<IEnumerable<CaresScreenModel>> GetScreensAsync();
    }
}