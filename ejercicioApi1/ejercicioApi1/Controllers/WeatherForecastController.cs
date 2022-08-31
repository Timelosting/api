using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace ejercicioApi1.Controllers
{
    [ApiController]
    [Route("pronostico-del-tiempo")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] islands = new[]
        {
        "Ibiza", "Bora bora", "santorini", "Bali", "Creta", "Moorea"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                isla = islands[Random.Shared.Next(islands.Length)]

            })
            .ToArray();
        }
    }
}