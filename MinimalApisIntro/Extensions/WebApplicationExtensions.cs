using Microsoft.AspNetCore.Mvc;

public static class WebApplicationExtensions
{
    public static WebApplication AddMinimalApis(this WebApplication app)
    {
        app.MapGet("/weatherforecast", (WeatherForecastService weatherService) =>
        {
            return weatherService.GetForecast();
        });

        // add weather forecast
        app.MapPost("/weatherforecast", 
        (WeatherForecastService weatherService, [FromBody]WeatherForecastDto weatherForecast) =>
        {
            weatherService.UpdateTodaysWeather(weatherForecast);
        });

        

        return app;
    }
}