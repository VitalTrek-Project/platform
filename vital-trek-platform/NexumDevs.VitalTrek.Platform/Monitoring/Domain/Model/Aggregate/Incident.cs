using NexumDevs.VitalTrek.Platform.Monitoring.Domain.Model.Commands;
//using NexumDevs.VitalTrek.Platform.Monitoring.Domain.Model.Entities;

namespace NexumDevs.VitalTrek.Platform.Monitoring.Domain.Model.Aggregate;

public partial class Incident 
{
    public Incident(
        int expeditionId, 
        int reportedBy, 
        string description,
        string severity,
        string status,
        string reportedAt
    ) : this()
    {
        ExpeditionId = expeditionId;
        ReportedBy = reportedBy;
        Description = description;
        Severity = severity;
        Status = status;
        ReportedAt = reportedAt;

    }

    public Incident(CreateIncidentCommand command) : this(command.ExpeditionId, command.ReportedBy,
        command.Description, command.Severity, command.Status, command.ReportedAt)
    {
        
    }

    private Incident()
    {
        throw new NotImplementedException();
    }

    public int Id { get; }

    public int ExpeditionId { get; private set; }
    public int ReportedBy { get; private set; }
    public string Description { get; private set; }
    public string Severity { get; private set; }
    public string Status { get; private set; }
    public string ReportedAt { get; private set; }

}