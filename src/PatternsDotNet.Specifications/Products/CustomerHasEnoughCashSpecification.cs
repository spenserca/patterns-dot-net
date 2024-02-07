using PatternsDotNet.Specifications.Specs.Abstractions;

namespace PatternsDotNet.Specifications.Products;

public record CustomerHasEnoughCashSpecification(Product Product) : CompositeSpecification<Customer>
{
    public override bool IsSatisfiedBy(Customer candidate)
    {
        return candidate.TotalMoney >= Product.Price;
    }
}
