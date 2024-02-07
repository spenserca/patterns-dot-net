using PatternsDotNet.Specifications.Specs.Abstractions;

namespace PatternsDotNet.Specifications.Products;

public record DiscountTransactionSpecification() : CompositeSpecification<Transaction>
{
    public override bool IsSatisfiedBy(Transaction candidate)
    {
        return candidate.Modifier == TransactionModifier.Coupon
            || candidate.Type == TransactionType.Discount;
    }
}
