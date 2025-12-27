using Booky.Domain.Apstractions;

namespace Booky.Domain.Bookings;

public static class BookingErrors
{
    public static Error NotFound = new(
        "Booking.Found",
        "The booking was not found.");
    
    public static Error Overlap = new(
        "Booking.Overlap",
        "The booking overlaps with an existing booking.");
    
    public static Error NotReserved = new(
        "Booking.NotReserved",
        "The booking is not in a reserved state.");
    
    public static Error NotConfirmed = new(
        "Booking.NotConfirmed",
        "The booking is not in a confirmed state.");
    
    public static Error AlreadyStarted = new(
        "Booking.AlreadyStarted",
        "The booking has already started.");
}