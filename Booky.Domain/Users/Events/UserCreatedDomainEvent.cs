using Booky.Domain.Apstractions;

namespace Booky.Domain.Users.Events;

public record UserCreatedDomainEvent(Guid UserId): IDomainEvent;