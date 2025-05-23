using Cariad.API.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Cariad.API.Controllers;

[ApiController]
[Route("api/[controller]")]
 public class WeatherForecastController : ControllerBase
{
    private readonly ApiSettingsOptions _apiSettings;

    public WeatherForecastController(IOptions<ApiSettingsOptions> options)
    {
        _apiSettings = options?.Value ?? throw new ArgumentNullException(nameof(options));
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = 22,
            Summary = _apiSettings.ClientId
        })
        .ToArray();
    }
}
