using PatternsDotNet.Specifications.Specs.Abstractions;

namespace PatternsDotNet.Specifications.Products;

public record InStockSpecification() : CompositeSpecification<Product>
{
    public override bool IsSatisfiedBy(Product candidate)
    {
        return candidate.CurrentStock > 0;
    }
}
