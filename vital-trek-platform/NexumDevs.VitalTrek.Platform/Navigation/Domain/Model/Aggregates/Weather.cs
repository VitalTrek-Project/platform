using NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.Commands;

namespace NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.Aggregates;

public class Weather
{
    public Weather(
        double temperatureCelsius,
        string condition,
        double humidity,
        double windSpeedKmh
    ) : this()
    {
        TemperatureCelsius = temperatureCelsius;
        Condition = condition;
        Humidity = humidity;
        WindSpeedKmh = windSpeedKmh;
    }

    public Weather(CreateWeatherCommand command) : this(
        command.temperatureCelsius, command.condition, command.humidity, command.windSpeedKmh)
    {
        
    }

    private Weather()
    {
        throw new NotImplementedException();
    }
    
    public int Id { get; }
    
    public double TemperatureCelsius { get; private set; }
    public string Condition { get; private set; }
    public double Humidity { get; private set; }
    public double WindSpeedKmh { get; private set; }
}
