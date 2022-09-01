public class WeatherForecast
{
    public WeatherForecast(DateTime date, int temperatureC, string? summary)
    {
        Date = date.Date;
        TemperatureC = temperatureC;
        Summary = summary;
    }
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string? Summary { get; set; }
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

// An alternative to the class above is to use a `record` as shown below. For more infor
// checkout this link: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/records

public record WeatherForecastRecord(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}