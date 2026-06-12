using System.Runtime.InteropServices.JavaScript;
using NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.ValueObjects;

namespace NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.Commands;

public record CreateExperienceCommand(
    ExpeditionId expeditionId,
    TouristId touristId,
    NoteItem note,
    string mediaURL,
    string createdAt);
    