using Microsoft.AspNetCore.Mvc;

public static class WebApplicationExtensions
{
    public static WebApplication AddMinimalApis(this WebApplication app)
    {
        app.MapGet("/weatherforecast", (WeatherForecastService weatherService, WeatherForecastService weatherServiceTwo) =>
        {
            var reqOne = weatherService.GetForecast();
            var reqTwo = weatherServiceTwo.GetForecast();
           return new { ReqOne = reqOne[0], ReqTwo = reqTwo[0] };
        });

        // update weather forecast
        app.MapPost("/weatherforecast", 
        (WeatherForecastService weatherService, [FromBody]WeatherForecastDto forecastDto) =>
        {
            return weatherService.UpdateTodaysWeather(forecastDto);
        });


        return app;
    }
}