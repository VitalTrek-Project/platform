using System.Runtime.InteropServices.JavaScript;
using NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.ValueObjects;

namespace NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.Commands;

public record CreateWeatherCommand(
    double temperatureCelsius,
    string condition,
    double humidity,
    double windSpeedKmh);
    