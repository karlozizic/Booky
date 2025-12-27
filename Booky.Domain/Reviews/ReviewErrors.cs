using Booky.Domain.Apstractions;

namespace Booky.Domain.Reviews;

public class ReviewErrors
{
    public static readonly Error NotEligible = new(
        "Review.NotEligible",
        "The review is not eligible because the booking is not yet completed");
}