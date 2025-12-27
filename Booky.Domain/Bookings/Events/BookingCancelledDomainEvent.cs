using Booky.Domain.Apstractions;

namespace Booky.Domain.Bookings.Events;

public record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;