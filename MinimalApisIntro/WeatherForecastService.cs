using MongoDB.Driver;

public class WeatherForecastService
{
    private readonly string[] _summaries;
    private List<WeatherForecast> _forecast;
    private readonly MongoClient _client;
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<WeatherForecast> _weatherForecasts;

    public WeatherForecastService()
    {
        _client = new MongoClient("<ADD YOUR MONGODB ATLAS CONNECTION STRING HERE>");
        _database = _client.GetDatabase("Weather");
        _weatherForecasts = _database.GetCollection<WeatherForecast>("WeatherForecasts");

        _summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        _forecast = CreateForecast();
    }

    public List<WeatherForecast> GetForecast()
    {
        _forecast = _weatherForecasts.Find(wf => true).ToList();

        return _forecast;
    }

    private List<WeatherForecast> CreateForecast()
    {
        // This deletes all documents in the collection first so we start with it empty
        // but you can delete this line if you want to keep forecasts.
        _weatherForecasts.DeleteMany(Builders<WeatherForecast>.Filter.Empty);

        var Forecast = Enumerable.Range(0, 6).Select(index =>
            new WeatherForecast
            (
                //This gets today's date and adds n number of days to it
                DateTime.Now.AddDays(index),
                // randomly generates a temperature between -20 and 55
                Random.Shared.Next(-20, 55),
                //Randomly gets a summary from the summary array
                _summaries[Random.Shared.Next(_summaries.Length)]
            ));


        foreach(var wf in Forecast)
        {
            try
            {
                _weatherForecasts.InsertOne(wf);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
     
        return Forecast.ToList();
        
    }

    public void UpdateTodaysWeather(WeatherForecast weather)
    {
        _weatherForecasts.InsertOne(weather);
    }
}