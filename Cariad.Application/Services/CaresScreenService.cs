using Cariad.Application.Interfaces;
using Cariad.Domain.Models;

namespace Cariad.Application.Services
{
    public class CaresScreenService : ICaresScreensService
    {
        private readonly ICaresScreensRepository _caresScreensRepository;

        public CaresScreenService(ICaresScreensRepository caresScreensRepository)
        {
            _caresScreensRepository = caresScreensRepository;
        }

        public async Task<IEnumerable<CaresScreenModel>> GetCaresScreensAsync()
        {
            return await _caresScreensRepository.GetScreensAsync();
        }

        public async Task<IEnumerable<CaresScreenModel>> GetCaresScreensByCategoryAsync(string category)
        {
            var pages = await _caresScreensRepository.GetScreensAsync();
            return pages.Where(p => p.Category == category);
        }
    }
}
