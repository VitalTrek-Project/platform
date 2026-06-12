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

    private Weather()
    {
        throw new NotImplementedException();
    }
    
    public double TemperatureCelsius { get; private set; }
    public string Condition { get; private set; }
    public double Humidity { get; private set; }
    public double WindSpeedKmh { get; private set; }
}
