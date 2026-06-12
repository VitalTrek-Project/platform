using NexumDevs.VitalTrek.Platform.Shared.Domain.Model;

namespace NexumDevs.VitalTrek.Platform.Navigation.Domain.Model.Errors;

public static class NavigationErrors
{
    public static readonly Error ExpeditionCreationFailed =
        new("Navigation.ExpeditionCreationFailed", "An error occurred while creating the expedition.");
}
