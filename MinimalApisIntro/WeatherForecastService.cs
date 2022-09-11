public class WeatherForecastService
{
    private readonly string[] _summaries;
    private readonly List<WeatherForecast> _forecast;
    public WeatherForecastService()
    {
        _summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        _forecast = CreateForecast();
    }


    public List<WeatherForecast> GetForecast()
    {
        return _forecast;
    }


    private List<WeatherForecast> CreateForecast()
    {
        return Enumerable.Range(0, 6).Select(index =>
                new WeatherForecast
                (
                    //This gets today's date and adds n number of days to it
                    DateTime.Now.AddDays(index),
                    // randomly generates a temperature between -20 and 55
                    Random.Shared.Next(-20, 55),
                    //Randomly gets a summary from the summary array
                    _summaries[Random.Shared.Next(_summaries.Length)]
                ))
            .ToList();
    }

    public List<WeatherForecast> UpdateTodaysWeather(WeatherForecastDto forecastDto)
    {
        var today = DateTime.UtcNow.Date;

        _forecast
            .Where(f => f.Date == today)
            .Select(w =>
            {
                w.TemperatureC = forecastDto.TemperatureC;
                w.Summary = forecastDto.Summary;
                return w;
            })
            .ToList();
       
        return _forecast;
    }
}