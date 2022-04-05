using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Project_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "First Name", "sjjdjkhbehddd", "jjehbkasbdfj", "nskjdnkabnfkef", "jhdbdsjkfbef", "jjhshdhgwevfgh", "ijndfb", "pooosdks", "kjsdbnads", "sbdmhbjd"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 100).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(2000, 5000),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                range = Random.Shared.Next(0,5)
            })
            .ToArray();
        }
    }
}