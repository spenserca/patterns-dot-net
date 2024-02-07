using PatternsDotNet.Specifications.Specs.Abstractions;

namespace PatternsDotNet.Specifications.Specs;

public record AndSpecification<T>(ISpecification<T> Left, ISpecification<T> Right)
    : CompositeSpecification<T>
{
    public override bool IsSatisfiedBy(T candidate) =>
        Left.IsSatisfiedBy(candidate) && Right.IsSatisfiedBy(candidate);
}
