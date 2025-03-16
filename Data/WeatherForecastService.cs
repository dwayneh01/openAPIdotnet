
using Microsoft.Extensions.Logging;

namespace openAPIdotnet.Data;

public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastService> _logger;

    public WeatherForecastService(ILogger<WeatherForecastService> logger)
    {
        _logger = logger;
    }

    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {

        _logger.LogInformation("Weather data fetched visited at {DT}", 
        DateTime.UtcNow.ToLongTimeString());
        _logger.LogError("log error at {DT}", 
        DateTime.UtcNow.ToLongTimeString());
        _logger.LogCritical("log critical visited at {DT}", 
        DateTime.UtcNow.ToLongTimeString());

        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            

            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray());
    }
}
