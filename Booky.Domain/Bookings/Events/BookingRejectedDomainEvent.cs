using Booky.Domain.Apstractions;

namespace Booky.Domain.Bookings.Events;

public record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;