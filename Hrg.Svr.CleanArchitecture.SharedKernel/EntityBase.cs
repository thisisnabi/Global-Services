namespace Hrg.Svr.CleanArchitecture.SharedKernel;

public class EntityBase<TId> where TId : notnull
{
    public TId Id { get; set; }

    private List<DomainEventBase> _domainEvents = new();
    public IReadOnlyCollection<DomainEventBase>? DomainEvents => _domainEvents?.AsReadOnly();

    public EntityBase(TId id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
    {

        if (obj is null || GetType() != obj.GetType())
            return false;

        if (ReferenceEquals(this, obj))
            return true;

        EntityBase<TId> item = (EntityBase<TId>)obj;

        if (item.IsTransient() || IsTransient())
            return false;
        else
            return Id.Equals(item.Id);
    }

    public static bool EqualOperator(EntityBase<TId> left, EntityBase<TId> right)
    {
        return Equals(left, right);
    }

    public static bool NotEqualOperator(EntityBase<TId> left, EntityBase<TId> right)
    {
        return !Equals(left, right);
    }

    public bool IsTransient()
    {

        return Id.Equals(default(TId));
    }

    public override int GetHashCode()
    {
        if (IsTransient())
        {
            return Id.GetHashCode() ^ 31; // XOR for random distribution 
        }

        return 0;
    }

    #region Events

    public void AddDomainEvent(DomainEventBase eventItem)
    {
        _domainEvents ??= new List<DomainEventBase>();
        _domainEvents.Add(eventItem);
    }

    public void RemoveDomainEvent(DomainEventBase eventItem)
    {
        _domainEvents?.Remove(eventItem);
    }

    public void ClearDomainEvents()
    {
        _domainEvents?.Clear();
    }

    #endregion
}
