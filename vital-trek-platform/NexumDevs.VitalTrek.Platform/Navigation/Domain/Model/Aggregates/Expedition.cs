using NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.Commands;
using NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.ValueObjects;

namespace NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.Aggregates;

public partial class Expedition
{
    public Expedition(
        TourId tourId,
        GuideId guideId,
        string status,
        string startedAt,
        string finishedAt
        ) : this()
    {
        TourID = tourId;
        GuideID = guideId;
        Status = status;
        StartedAt = startedAt;
        FinishedAt = finishedAt;
    }

    public Expedition(CreateExpeditionCommand command) : this(
        command.tourId, command.guideId, command.status, command.startedAt, command.finishedAt)
    {
        
    }

    private Expedition()
    {
        throw new NotImplementedException();
    }
    
    public int Id { get; }
    
    public TourId TourID { get; private set; }
    public GuideId GuideID { get; private set; }
    public string Status { get; private set; }
    public string StartedAt { get; private set; }
    public string FinishedAt { get; private set; }
}
