using Booky.Domain.Apstractions;

namespace Booky.Domain.Bookings.Events;

public record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;