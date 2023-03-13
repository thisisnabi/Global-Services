using MediatR;

namespace Hrg.Svr.CleanArchitecture.SharedKernel;

public class DomainEventDispatcher
{
    private readonly IPublisher _publisher;

    public DomainEventDispatcher(IPublisher publisher)
    {
        _publisher = publisher;
    }

    public async Task DispatchAndClearEvents<TId>(IEnumerable<EntityBase<TId>> entitiesWithEvents) where TId : notnull
    {
        foreach (var entity in entitiesWithEvents)
        {
            var events = entity.DomainEvents?.ToArray();

            if (events is null)
            {
                continue;
            }

            entity.ClearDomainEvents();

            foreach (var domainEvent in events)
            {
                await _publisher.Publish(domainEvent).ConfigureAwait(false);
            }
        }
    }
}
