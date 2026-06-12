using System.Runtime.InteropServices.JavaScript;
using NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.ValueObjects;

namespace NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.Commands;

public record CreateExpeditionCommand(
    TourId tourId,
    GuideId guideId,
    string status,
    string startedAt,
    string finishedAt);
    