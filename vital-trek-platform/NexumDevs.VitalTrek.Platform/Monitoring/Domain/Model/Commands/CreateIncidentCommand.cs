using System.Runtime.InteropServices.JavaScript;

namespace NexumDevs.VitalTrek.Platform.Monitoring.Domain.Model.Commands;

public record CreateIncidentCommand(
    int ExpeditionId, 
    int ReportedBy, 
    string Description,
    string Severity,
    string Status,
    string ReportedAt
    );
    