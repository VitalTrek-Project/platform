namespace NexumDevs.VitalTrek.Platform.Navigation.Domain.Model;

public enum NavigationError
{
    None,
    TourNotFound,
    GuideNotFound,
    TouristNotFound,
    ExpeditionNotFound,
    OperationCancelled,
    DatabaseError,
    InternalServerError
}
