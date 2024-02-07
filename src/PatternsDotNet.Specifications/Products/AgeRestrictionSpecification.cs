using PatternsDotNet.Specifications.Specs.Abstractions;

namespace PatternsDotNet.Specifications.Products;

public record AgeRestrictionSpecification(Customer Customer) : CompositeSpecification<Product>
{
    public override bool IsSatisfiedBy(Product candidate)
    {
        if (candidate?.AgeRestriction is null)
            return true;

        return Customer.Age >= candidate.AgeRestriction.MinimumAge;
    }
}
