
using System.Text.Json;
using System.Text.Json.Serialization;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {

        services.AddSingleton<WeatherForecastService>();

         //services.AddSingleton(sp => new JsonSerializerOptions
         //   {
         //       Converters =
         //       {
         //           new DateTimeConverterUsingDateTimeParse()
         //       },
         //       ReferenceHandler = ReferenceHandler.IgnoreCycles
         //   });

        return services;
    }

    public static IServiceCollection AddThirdPartyDependencies(this IServiceCollection services)
    {
        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        return services;
    }




    //public class DateTimeConverterUsingDateTimeParse : JsonConverter<DateTime>
    //{
    //    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    //    {
    //        return DateTime.Parse(reader.GetString());
    //    }

    //    public override void Write(Utf8JsonWriter writer, DateTime  value, JsonSerializerOptions options)
    //    {
    //        writer.WriteStringValue(value.ToString());
    //    }
    //}
    
}