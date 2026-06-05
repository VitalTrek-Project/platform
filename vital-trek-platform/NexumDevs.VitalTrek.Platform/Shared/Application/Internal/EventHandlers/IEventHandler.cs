namespace NexumDevs.VitalTrek.Platform.Shared.Domain.Model.Events;
using Cortex.Mediator.Notifications;

namespace NexumDevs.VitalTrek.Platform.shared.application.Internal.EventHandlers;

public interface IEventHandler<in TEvent> : INotificationHandler<TEvent> where TEvent : IEvent
{
}
