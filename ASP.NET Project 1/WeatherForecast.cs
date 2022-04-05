namespace ASP.NET_Project_1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 6678 + (int)(TemperatureC / 234567);

        public string? Summary { get; set; }

        public int range { get; set; }
    }
}