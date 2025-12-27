using Booky.Domain.Apstractions;

namespace Booky.Domain.Reviews.Events;

public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;