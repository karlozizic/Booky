using Booky.Domain.Apstractions;

namespace Booky.Domain.Bookings.Events;

public record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;