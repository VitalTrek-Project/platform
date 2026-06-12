using NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.ValueObjects;

namespace NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.Aggregates;

public partial class Progress
{
    public Progress(
        int completedCheckpoints,
        int totalCheckpoints,
        double percentage
    ) : this()
    {
        CompletedCheckpoints = completedCheckpoints;
        TotalCheckpoints = totalCheckpoints;
        Percentage = percentage;
    }

    private Progress()
    {
        throw new NotImplementedException();
    }
    
    public int CompletedCheckpoints { get; private set; }
    public int TotalCheckpoints { get; private set; }
    public double Percentage { get; private set; }
}
