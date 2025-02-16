using Cariad.Domain.Models;

namespace Cariad.Application.Interfaces
{
    public interface ICaresScreensService
    {
        Task<IEnumerable<CaresScreenModel>> GetCaresScreensAsync();
        Task<IEnumerable<CaresScreenModel>> GetCaresScreensByCategoryAsync(string category);
    }
}
