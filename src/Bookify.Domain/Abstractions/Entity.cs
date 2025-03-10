namespace Bookify.Domain.Abstractions;
public abstract class Entity : IEquatable<Entity>
{
    private readonly List<IDomainEvent> _domainEvents = [];
    public Guid Id { get; init; }
    protected Entity(Guid id)
    {
        Id = id;
    }

    public bool Equals(Entity? other)
    {
        if (other is null)
            return false;

        return Id == other.Id;
    }
    public override bool Equals(Object? obj) => Equals(obj as Entity);
    public override int GetHashCode() => Id.GetHashCode();
    public IReadOnlyList<IDomainEvent> GetDomainEvents() => [.. _domainEvents];
    public void ClearDomainEvents() => _domainEvents.Clear();
    protected void RaiseDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);
}
