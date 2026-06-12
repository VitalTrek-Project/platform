namespace NexumDevs.VitalTrek.Platform.Navigation.Domain.Model;

public enum NavigationError
{
    None,
    ExpeditionNotFound,
    ExperienceNotFound,
    ProgressNotLoaded,
    OperationCancelled,
    DatabaseError,
    InternalServerError
}
