using Booky.Domain.Apstractions;

namespace Booky.Domain.Bookings.Events;

public record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;