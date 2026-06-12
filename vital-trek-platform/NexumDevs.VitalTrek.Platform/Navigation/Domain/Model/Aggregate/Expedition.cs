using NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.ValueObjects;

namespace NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.Aggregate;

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

    private Expedition()
    {
        throw new NotImplementedException();
    }
    
    public TourId TourID { get; private set; }
    public GuideId GuideID { get; private set; }
    public string Status { get; private set; }
    public string StartedAt { get; private set; }
    public string FinishedAt { get; private set; }
}
