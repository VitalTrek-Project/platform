using NexumDevs.VitalTrek.Platform.Monitoring.Domain.Model.Aggregate;
using NexumDevs.VitalTrek.Platform.Shared.Domain.Repositories;

namespace NexumDevs.VitalTrek.Platform.Monitoring.Domain.Repositories;

public interface IIncidentRepository : IBaseRepository<Incident>
{
    
    Task<IEnumerable<Incident>> FindByCategoryIdAsync(int incidentId, CancellationToken cancellationToken);

    //Task<bool> ExistsByTitleAsync(string title, CancellationToken cancellationToken);
}