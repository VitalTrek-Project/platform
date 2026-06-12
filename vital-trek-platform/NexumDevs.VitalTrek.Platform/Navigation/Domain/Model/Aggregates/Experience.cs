using NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.ValueObjects;

namespace NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.Aggregates;

public partial class Experience
{
    public Experience(
        ExpeditionId expeditionId,
        TouristId touristId,
        NoteItem note,
        string mediaURL,
        string createdAt
    ) : this()
    {
        ExpeditionID = expeditionId;
        TouristID = touristId;
        Note = note;
        MediaURL = mediaURL;
        CreatedAt = createdAt;
    }

    private Experience()
    {
        throw new NotImplementedException();
    }
    
    public ExpeditionId  ExpeditionID { get; private set; }
    public TouristId TouristID { get; private set; }
    public NoteItem Note { get; private set; }
    public string MediaURL { get; private set; }
    public string CreatedAt { get; private set; }
}
