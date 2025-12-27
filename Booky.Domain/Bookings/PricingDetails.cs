using Booky.Domain.Apartments;
using Booky.Domain.Shared;

namespace Booky.Domain.Bookings;

public record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesFee,
    Money TotalPrice);